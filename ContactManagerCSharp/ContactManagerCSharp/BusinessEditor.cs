using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManagerCSharp
{
    public partial class BusinessEditor : Form
    {

        DbConn dbConn = new DbConn(); //create an instance of the Databse onnection in the form

        public BusinessEditor()
        {
            InitializeComponent();
        }

        private void BusinessEditor_Load(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();//Get all buiness records in datagrid view when form is load 

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();
        }

        //CREATE BUSINESS RECORDS
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbBusTel.Enabled = true;
            tbAddress1.Enabled = true;
            tbAddress2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;

            //Button functions when AddNew button is clicked
            btnUpdate.Enabled = false;//disable update button
            btnDelete.Enabled = false;//disable delete button
            btnSaveNew.Enabled = true;//enable savenew button

            //Empty textboxes when AddNew button is clicked
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbBusTel.Text = String.Empty;
            tbAddress1.Text = String.Empty;
            tbAddress2.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
        }

        //READ BUSINESS RECORDS
        private void dGVBusinessRecords_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            //populates datagridview with data in the text boxes
            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
            tbFname.Text = dGVBusinessRecords.SelectedCells[1].Value.ToString();
            tbLname.Text = dGVBusinessRecords.SelectedCells[2].Value.ToString();
            tbEmail.Text = dGVBusinessRecords.SelectedCells[3].Value.ToString();
            tbBusTel.Text = dGVBusinessRecords.SelectedCells[4].Value.ToString();
            tbAddress1.Text = dGVBusinessRecords.SelectedCells[5].Value.ToString();
            tbAddress2.Text = dGVBusinessRecords.SelectedCells[6].Value.ToString();
            tbCity.Text = dGVBusinessRecords.SelectedCells[7].Value.ToString();
            tbPostcode.Text = dGVBusinessRecords.SelectedCells[8].Value.ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();//creates a new instance of Business Contacts
            //insert records present in text boxes into BusinessContact table in the database  
            businessContact.ContactFname = tbFname.Text;
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.BusinessTel = tbBusTel.Text;
            businessContact.ContactAddr1 = tbAddress1.Text;
            businessContact.ContactAddr2 = tbAddress2.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            dbConn.InsertBusiness(businessContact);//inserts business Contacts to the record

            //accessiblity of text boxes when save new is clicked
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbBusTel.Enabled = false;
            tbAddress1.Enabled = false;
            tbAddress2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;

            //accessiblity of buttons when SaveNew is clicked
            btnUpdate.Enabled = true;//enable update button
            btnDelete.Enabled = true;//enable delete button
            btnSaveNew.Enabled = false;//disable save new button

        }

        //UPDATE BUSINESS RECORDS
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Accessiblity of textboxes when update button is clicked
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbBusTel.Enabled = true;
            tbAddress1.Enabled = true;
            tbAddress2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;

            //Accessiblity of buttons when update button is clicked
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
        }

        //UPDATE BUSINESS RECORDS
        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());
            BusinessContact businessContact = new BusinessContact();//creates new busines contact instance 
            //populate businesscontact through records in the text box
            businessContact.ContactID = index;
            businessContact.ContactFname = tbFname.Text;
            businessContact.ContactLname = tbLname.Text;
            businessContact.ContactEmail = tbEmail.Text;
            businessContact.BusinessTel = tbBusTel.Text;
            businessContact.ContactAddr1 = tbAddress1.Text;
            businessContact.ContactAddr2 = tbAddress2.Text;
            businessContact.ContactCity = tbCity.Text;
            businessContact.ContactPostcode = tbPostcode.Text;
            dbConn.UpdateBusinessContact(businessContact);//updates business contact in the database with new populated instace
            dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();//gets BusinessRecords from database into the datagridview 

            //Accessiblity of textboxes when save button is clicked
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbBusTel.Enabled = false;
            tbAddress1.Enabled = false;
            tbAddress2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;

            //Accessiblity of buttons when Save button is clicked
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNew.Enabled = true;
            btnSave.Enabled = false;
        }

        //DELETE BUSINESS RECORD
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Delete Record?";//message in dialogbox
            string caption = "Do you want to delete the contact with the record with ID of " + Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString());//Heading of the dialogbox
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);//Message box showing variables message, caption and buttons
            if(result == DialogResult.Yes)//result if Yes is clicked
            {
                dbConn.DeleteBusiness(Int32.Parse(dGVBusinessRecords.SelectedCells[0].Value.ToString()));//Deletes record that is linked to Contact ID

                dGVBusinessRecords.DataSource = dbConn.GetAllBusiness();//gets all business records from the database and shows them in the datagridview 
            }




        }
    }
}
