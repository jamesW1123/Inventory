using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading;

namespace Inventory.DB
{
    public static class Database
    {
        public static OdbcConnection OdbcAuthDB(string connectionString, int connectionAttempts = 0)
        {
            OdbcConnection db = new OdbcConnection(connectionString);

            try
            {
                db.Open();
            }
            catch (Exception ex)
            {
                db.Dispose();
                if (ex.Message.Contains("Connection error: An error occurred during the TCPIP connection attempt") && connectionAttempts < 5)
                {
                    Thread.Sleep(100);
                    return OdbcAuthDB(connectionString, connectionAttempts + 1);
                }
                else
                {
                    throw;
                }
            }
            return db;
        }

        public static DataTable ExecuteDataTable(OdbcConnection db, string sqlQuery, IEnumerable<object> parameters = null)
        {
            return ExecuteDataTable(db, sqlQuery, false, parameters);
        }

        public static DataTable ExecuteDataTable(OdbcConnection db, string sqlQuery, bool fetchKeys, IEnumerable<object> parameters = null)
        {
            DataTable dt = new DataTable();

            using (OdbcDataAdapter oda = new OdbcDataAdapter(sqlQuery, db))
            {
                if (parameters != null)
                    foreach (object param in parameters)
                    {
                        oda.SelectCommand.Parameters.AddWithValue("?", param);
                    }
                if (fetchKeys) oda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                oda.Fill(dt);
            }
            return dt;
        }

        public static int ExecuteNonQuery(OdbcConnection db, string sqlQuery, IEnumerable<object> parameters = null)
        {
            using (OdbcCommand oc = new OdbcCommand(sqlQuery, db))
            {
                if (parameters != null)
                    foreach (object param in parameters)
                    {
                        oc.Parameters.AddWithValue("?", param);
                    }
                return oc.ExecuteNonQuery();
            }
        }

        public static T ExecuteQuery<T>(OdbcConnection db, string sqlQuery, IEnumerable<object> parameters = null)
        {
            using (OdbcCommand oc = new OdbcCommand(sqlQuery, db))
            {
                if (parameters != null)
                    foreach (object param in parameters)
                    {
                        oc.Parameters.AddWithValue("?", param);
                    }
                object retVal = oc.ExecuteScalar();
                if (retVal == DBNull.Value || retVal == null)
                {
                    return default(T);
                }
                else
                {
                    return ((T)retVal);
                }
            }
        }

        public static List<object> GetDataAsString(OdbcConnection db, string sqlQuery, IEnumerable<object> parameters = null)
        {
            List<object> result = new List<object>();
            DataTable dt = ExecuteDataTable(db, sqlQuery, false, parameters);
            foreach (DataRow row in dt.Rows)
            {
                result.Add((row[0]).ToString());
            }
            return result;
        }                
    }
}
