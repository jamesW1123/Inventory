using Inventory.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Inventory.Objects
{
    class Item
    {

        //number, barcode, name, manufacturer, vendorid, cost, sell, onorder, onhand, minonhand, description
        private int number;
        private int barcode;
        private string name;
        private string manufacturer;
        private int vendorid;
        private decimal cost;
        private decimal sell;
        private int onorder;
        private int onhand;
        private int minonhand;
        private string description;

        public int Number { get => number; set => number = value; }
        public int Barcode { get => barcode; set => barcode = value; }
        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int Vendorid { get => vendorid; set => vendorid = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public decimal Sell { get => sell; set => sell = value; }
        public int Onorder { get => onorder; set => onorder = value; }
        public int Onhand { get => onhand; set => onhand = value; }
        public int Minonhand { get => minonhand; set => minonhand = value; }
        public string Description { get => description; set => description = value; }
                
        /// <summary>
        /// This constructor creates a new Item object that is empty
        /// </summary>
        public Item()
        {
            Number = -1;
            Barcode = -1;
            Name = "";
            Manufacturer = "";
            Vendorid = 0;
            Cost = 0;
            Sell = 0;
            Onorder = 0;
            Onhand = 0;
            Minonhand = 0;
            Description = "";
        }

        /// <summary>
        /// This contructor is to create an Item object from existing data in te database
        /// using the Item ID passed as a parameter 
        /// </summary>
        /// <param name="id"></param>
        public Item(int id, bool isBarcode)
        {
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    DataTable dt = new DataTable();
                    if (isBarcode)
                    {
                        dt = Database.ExecuteDataTable(db, "SELECT * FROM item WHERE barcode = ?", new List<object> { id });
                    }
                    else
                    {
                        dt = Database.ExecuteDataTable(db, "SELECT * FROM item WHERE number = ?", new List<object> { id });
                    }
                                        
                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        //number, barcode, name, manufacturer, vendorid, cost, sell, onorder, onhand, minonhand, description
                        Number = row.Field<int>("number");
                        Barcode = row.Field<int>("barcode");
                        Name = row.Field<string>("name");
                        Manufacturer = row.Field<string>("manufacturer");
                        Vendorid = row.Field<int>("vendorid");
                        Cost = row.Field<decimal>("cost");
                        Sell = (DBNull.Value.Equals(row["sell"]) ? 0 : row.Field<decimal>("sell"));
                        Onorder = (DBNull.Value.Equals(row["onorder"]) ? 0 : row.Field<int>("onorder"));
                        Onhand = (DBNull.Value.Equals(row["onhand"]) ? 0 : row.Field<int>("onhand"));
                        Minonhand = (DBNull.Value.Equals(row["minonhand"]) ? 0 : row.Field<int>("minonhand"));
                        Description = (DBNull.Value.Equals(row["description"]) ? "" : row.Field<string>("description"));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
            }
        }
        
        /// <summary>
        /// Saves a new item to the database
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool saveNew(Item i)
        {

            if (!isValid(i))
            { return false; }
            else
            {
                List<object> parameters = new List<object>();
                string sqlQuery = "INSERT INTO item(number, barcode, name, manufacturer, vendorid, cost, sell, onorder, onhand, minonhand, description)\n" +
                    "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                parameters.Add(i.Number);
                parameters.Add(i.Barcode);
                parameters.Add(i.Name);
                parameters.Add(i.Manufacturer);
                parameters.Add(i.Vendorid);
                parameters.Add(i.Cost);
                parameters.Add(i.Sell);
                parameters.Add(i.Onorder);
                parameters.Add(i.Onhand);
                parameters.Add(i.Minonhand);
                parameters.Add(i.Description);

                try
                {
                    using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                    {
                        Database.ExecuteNonQuery(db, sqlQuery, parameters);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("exception: " + ex);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Updates an existing item in the database
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool saveUpdate(Item i)
        {

            if (!isValid(i))
            { return false; }
            else
            {
                List<object> parameters = new List<object>();
                string sqlQuery = "UPDATE item SET name = ?, barcode = ?, manufacturer = ?, vendorid = ?, cost = ?, sell = ?, onorder = ?, onhand = ?, minonhand = ?, description = ?\n" +
                    "WHERE number = ?";

                parameters.Add(i.Name);
                parameters.Add(i.Barcode);
                parameters.Add(i.Manufacturer);
                parameters.Add(i.Vendorid);
                parameters.Add(i.Cost);
                parameters.Add(i.Sell);
                parameters.Add(i.Onorder);
                parameters.Add(i.Onhand);
                parameters.Add(i.Minonhand);
                parameters.Add(i.Description);
                parameters.Add(i.Number);

                try
                {
                    using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                    {
                        Database.ExecuteNonQuery(db, sqlQuery, parameters);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("exception: " + ex);
                    return false;
                }
            }

            return true;
        }
                
        public string ToString(Item i)
        {
            string result = "";

            result += "NUMBER:" + i.Number;
            result += ",BARCODE:" + i.Barcode;
            result += ",NAME:" + i.Name;
            result += ",MANUFACTURER:" + i.Manufacturer;
            result += ",VENDOR:" + new Vendor(i.Vendorid).Name;
            result += ",COST:" + i.Cost;
            result += ",SELL:" + i.Sell;
            result += ",ONORDER:" + i.Onorder;
            result += ",ONHAND:" + i.Onhand;
            result += ",MINONHAND:" + i.Minonhand;
            result += ",DESCRIPTION:" + i.Description;

            return result;
        }

        /// <summary>
        /// Update the quatitiy on hand for this item, and change it to the quantity passed in.
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        internal bool updateQuantity(int quantity)
        {            
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    Database.ExecuteNonQuery(db, "UPDATE item SET onhand = ? WHERE number = ?", new List<object> { quantity, this.Number });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check if the item has all of the required fields set and correct
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        protected bool isValid(Item i)
        {
            if (i.Number <= 0)
            {
                MessageBox.Show("Item must have a unique item number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(i.Barcode <= 0)
            {
                MessageBox.Show("Item must have a unique barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(i.Name))
            {
                MessageBox.Show("Item name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(i.Manufacturer))
            {
                MessageBox.Show("Manufacturer cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (i.Vendorid <= 0)
            {
                MessageBox.Show("Vendor cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (i.Cost <= 0)
            {
                MessageBox.Show("Cost cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
