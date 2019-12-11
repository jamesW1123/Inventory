using Inventory.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Inventory.Objects
{
    class Vendor
    {

        //id, name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2
        private int id;
        private string name;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string fax;
        private string contact1;
        private string contact2;
        private string email1;
        private string email2;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Contact1 { get => contact1; set => contact1 = value; }
        public string Contact2 { get => contact2; set => contact2 = value; }
        public string Email1 { get => email1; set => email1 = value; }
        public string Email2 { get => email2; set => email2 = value; }

        /// <summary>
        /// This constructor creates a new Vendor object that is empty
        /// </summary>
        public Vendor()
        {
            Name = "";
            Street = "";
            City = "";
            State = "";
            Zip = "";
            Phone = "";
            Fax = "";
            Contact1 = "";
            Contact2 = "";
            Email1 = "";
            Email2 = "";
        }

        /// <summary>
        /// This contructor is to create an Vendor object from existing data in te database
        /// using the Vendor ID passed as a parameter
        /// </summary>
        /// <param name="id"></param>
        public Vendor(int id)
        {
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    DataTable dt = new DataTable();
                    dt = Database.ExecuteDataTable(db, "SELECT * FROM vendor WHERE id = ?", new List<object> { id });

                    if (dt.Rows.Count == 1)
                    {
                        DataRow row = dt.Rows[0];

                        //id, name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2
                        ID = id;
                        Name = row.Field<string>("name");
                        Street = row.Field<string>("street");
                        City = row.Field<string>("city");
                        State = row.Field<string>("state");
                        Zip = row.Field<string>("zip");
                        Phone = row.Field<string>("phone");
                        Fax = row.Field<string>("fax");
                        Contact1 = row.Field<string>("contact1");
                        Contact2 = row.Field<string>("contact2");
                        Email1= row.Field<string>("email1");
                        Email2 = row.Field<string>("email2");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
            }
        }             

        /// <summary>
        /// Saves a new vendor to the database
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool saveNew(Vendor v)
        {

            if (!isValid(v))
            { return false; }
            else
            {
                //name, streetm city, state, zip, phone, fax, contact1, contact2, email1, email2
                List<object> parameters = new List<object>();
                string sqlQuery = "INSERT INTO vendor(name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2)\n" +
                    "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT SCOPE_IDENTITY();";

                parameters.Add(v.Name);
                parameters.Add(v.Street);
                parameters.Add(v.City);
                parameters.Add(v.State);
                parameters.Add(v.Zip);
                parameters.Add(v.Phone);
                parameters.Add(v.Fax);
                parameters.Add(v.Contact1);
                parameters.Add(v.Contact2);
                parameters.Add(v.Email1);
                parameters.Add(v.Email2);

                try
                {
                    using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                    {
                        v.ID = Database.ExecuteQuery<int>(db, sqlQuery, parameters);
                        //Database.ExecuteNonQuery(db, sqlQuery, parameters);
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
        /// Update an existing vendor in the database
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool saveUpdate(Vendor v)
        {
            if (!isValid(v))
            { return false; }
            else
            {
                //name, streetm city, state, zip, phone, fax, contact1, contact2, email1, email2
                List<object> parameters = new List<object>();
                string sqlQuery = "UPDATE vendor SET name = ?, street = ?, city = ?, state = ?, zip = ?, phone = ?, fax = ?, contact1 = ?, contact2 = ?, email1 = ?, email2 = ?)\n" +
                    "WHERE id = ?";

                parameters.Add(v.Name);
                parameters.Add(v.Street);
                parameters.Add(v.City);
                parameters.Add(v.State);
                parameters.Add(v.Zip);
                parameters.Add(v.Phone);
                parameters.Add(v.Fax);
                parameters.Add(v.Contact1);
                parameters.Add(v.Contact2);
                parameters.Add(v.Email1);
                parameters.Add(v.Email2);
                parameters.Add(v.ID);
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
        /// Check if the vendor has all of the required fields set and correct
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private bool isValid(Vendor v)
        {
            if (string.IsNullOrWhiteSpace(v.Name))
            {
                MessageBox.Show("Name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.Street))
            {
                MessageBox.Show("Street cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.City))
            {
                MessageBox.Show("City cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.State))
            {
                MessageBox.Show("State cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.Zip))
            {
                MessageBox.Show("Zip cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.Phone))
            {
                MessageBox.Show("Phone cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.Contact1))
            {
                MessageBox.Show("Primary Contact cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(v.Email1))
            {
                MessageBox.Show("Primary Email cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
