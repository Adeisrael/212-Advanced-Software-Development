using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerCSharp
{
    public class DbConn
    {//Connection of MySql Database with Data Credentials 
        private string connString = "Server=db212it.chmhkq40bexm.us-east-1.rds.amazonaws.com;User ID=admin;Password=migrate123;Database=HarrisContactDb";

        public DataTable GetAllPersonal()//Extract all the Data for Personal Contacts from the Database and project them in a DataTable
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();

                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn))//Using MySql command CALL selectAllPersonal gets all PersonalContact from the Database

                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())//loop to read all the information from Personal Contact
                    {
                        personalContacts.Add(new PersonalContact //Adds new personal contact to the PersonalContactList
                        { //Gets data from Personal Contact Class
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            HomeTel = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8)
                        });

                    }
                //Creates and Adds column headers for the DataTable and Adds list to the DataTable
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFname");
                personalContactDt.Columns.Add("ContactLname");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("HomeTel");
                personalContactDt.Columns.Add("ContactAddr1");
                personalContactDt.Columns.Add("ContactAddr2");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactPostCode");

                foreach(var item in personalContacts) //loop to input items from PersonalContactList to the DataTable
                {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactEmail"] = item.ContactEmail;
                    row["HomeTel"] = item.HomeTel;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;

                    personalContactDt.Rows.Add(row);//inserts Record into the DataTable
                }
                //returns personalContact Datatable 
                return personalContactDt;
            }
        }

        //INSERT PERSONAL CONTACTS
        public async void InsertPersonal(PersonalContact personalContact) 
        {
            using(var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();//open database connection
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";//parameters where data would be inserted using command text
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", personalContact.HomeTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdatePersonal(PersonalContact personalContact)//update Personal Contact
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";//update each parameter through the Contact ID 
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);//added parameter contact ID 
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.HomeTel);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //DELETE PERSONAL
        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";//Call parameter 1 (contact id) and delete
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();//run query
                }
            }

        }

        public DataTable GetAllBusiness()
        {
            using (var conn = new MySqlConnection(connString))//accessing private class with connString
            {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();",conn))//SELECT BUSINESS CONTACT
                    using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {

                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            BusinessTel = reader.GetString(4),
                            ContactAddr1 = reader.GetString(5),
                            ContactAddr2 = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8)
                        });
                    }
                //Creates and Adds column headers for the DataTable and Adds list to the DataTable
                businessContactDt.Columns.Add("ContactID");
                businessContactDt.Columns.Add("ContactFname");
                businessContactDt.Columns.Add("ContactLname");
                businessContactDt.Columns.Add("ContactEmail");
                businessContactDt.Columns.Add("BusinessTel");
                businessContactDt.Columns.Add("ContactAddr1");
                businessContactDt.Columns.Add("ContactAddr2");
                businessContactDt.Columns.Add("ContactCity");
                businessContactDt.Columns.Add("ContactPostcode");

                foreach (var item in businessContacts)
                {
                    var row = businessContactDt.NewRow();
                    //adds items from business contacts to the Datatable
                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactEmail"] = item.ContactEmail;
                    row["BusinessTel"] = item.BusinessTel;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }
        }

        public async void InsertBusiness(BusinessContact businessContact)//INSERT BUSINESS CONTACT
        {
            using (var conn = new MySqlConnection(connString))//accessing private class with connString
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFname);//inserting the value for ContactFname from business contacts in parameter 1
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async void UpdateBusinessContact(BusinessContact businessContact)//UPDATE BUSINESS CONTACT
        {
            using (var conn = new MySqlConnection(connString))//accessing private class with connString
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updateBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";//update parameter through contact ID  
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async void DeleteBusiness(int id)//DELETE BUSINES CONTACT
        {
            using (var conn = new MySqlConnection(connString))//accessing private class with connString
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";//delete business contacts in database with the ID
                    cmd.Parameters.AddWithValue("p1",id); // parameter 1 containing ContactID                
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }
    }
}
