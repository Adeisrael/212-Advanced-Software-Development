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
    public partial class PersonalEditor : Form
    {
        DbConn dbConn = new DbConn();//create an instance of DB connection in the Form

        public PersonalEditor()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            dGVPersonalDetails.DataSource = dbConn.GetAllPersonal();//GET all personal records in the datagrid view when form is loaded 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGVPersonalDetails.DataSource = dbConn.GetAllPersonal();
        }


        ///////CREATE PERSONAL RECORDS 
        private void btnAddNew_Click(object sender, EventArgs e)
        {   
            //Enable text boxes when AddNew button is clicked
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbHomeTel.Enabled = true;
            tbAddress1.Enabled = true;
            tbAddress2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;

            //other button functions when AddNew button is clicked
            btnUpdate.Enabled = false;// disable Update button when AddNew is clicked
            btnDelete.Enabled = false;// disable Delete button when AddNew is clicked
            btnSaveNew.Enabled = true;//enable SaveNew button when AddNew is clicked

            //Empty textboxes when Addnew Button is clicked 
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbHomeTel.Text = String.Empty;
            tbAddress1.Text = String.Empty;
            tbAddress2.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbPostcode.Text = String.Empty;
        }

        ///////READ PERSONAL RECORDS
        private void dGVPersonalDetails_CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            //insert data in Text box with highlighted row in datagridview
            int index = Int32.Parse(dGVPersonalDetails.SelectedCells[0].Value.ToString());
            tbFname.Text = dGVPersonalDetails.SelectedCells[1].Value.ToString();
            tbLname.Text = dGVPersonalDetails.SelectedCells[2].Value.ToString();
            tbEmail.Text = dGVPersonalDetails.SelectedCells[3].Value.ToString();
            tbHomeTel.Text = dGVPersonalDetails.SelectedCells[4].Value.ToString();
            tbAddress1.Text = dGVPersonalDetails.SelectedCells[5].Value.ToString();
            tbAddress2.Text = dGVPersonalDetails.SelectedCells[6].Value.ToString();
            tbCity.Text = dGVPersonalDetails.SelectedCells[7].Value.ToString();
            tbPostcode.Text = dGVPersonalDetails.SelectedCells[8].Value.ToString();
        }



        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            PersonalContact personalContact = new PersonalContact();//create a new instance of personal contact
            //insert records present in text boxes into PersonalContact table in the database  
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.HomeTel = tbHomeTel.Text;
            personalContact.ContactAddr1 = tbAddress1.Text;
            personalContact.ContactAddr2 = tbAddress2.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            dbConn.InsertPersonal(personalContact);//inserts new personalcontact records into the database 

            //Accesiblity of Textboxes when SaveNew button is clicked
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbHomeTel.Enabled = false;
            tbAddress1.Enabled = false;
            tbAddress2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;
            //Functions of buttons when SaveNew button is clicked
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = false;
            dGVPersonalDetails.DataSource = dbConn.GetAllPersonal();//gets all personalrecords and shows on the datagridview
        }

        /////UPDATE PERSONAL RECORDS
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbEmail.Enabled = true;
            tbHomeTel.Enabled = true;
            tbAddress1.Enabled = true;
            tbAddress2.Enabled = true;
            tbCity.Enabled = true;
            tbPostcode.Enabled = true;

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(dGVPersonalDetails.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();//create a new instance of personal contact
            //insert records in text boxes into PersonalContact table in the database  
            personalContact.ContactID = index;
            personalContact.ContactFname = tbFname.Text;
            personalContact.ContactLname = tbLname.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.HomeTel = tbHomeTel.Text;
            personalContact.ContactAddr1 = tbAddress1.Text;
            personalContact.ContactAddr2 = tbAddress2.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            dbConn.UpdatePersonal(personalContact);//updates PersonalContacts with the new personal Contact instance 
            dGVPersonalDetails.DataSource = dbConn.GetAllPersonal();//gets personal contact details in the datagridview

            //Accessiblity of textboxes
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbEmail.Enabled = false;
            tbHomeTel.Enabled = false;
            tbAddress1.Enabled = false;
            tbAddress2.Enabled = false;
            tbCity.Enabled = false;
            tbPostcode.Enabled = false;

            //function of buttons when Save button is clicked
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAddNew.Enabled = true;
            btnSave.Enabled = false;
        }

        
        /////DELETE PERSONAL RECORDS
        private void btnDelete_Click(object sender, EventArgs e)//DELETE RECORD
        {
            string message = "Are you sure you want to Delete Record?";//verification box 
            string caption = "Do you want to delete contact with ID of " + Int32.Parse(dGVPersonalDetails.SelectedCells[0].Value.ToString());//verification caption with ID
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;//Message box buttons
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DeletePersonal(Int32.Parse(dGVPersonalDetails.SelectedCells[0].Value.ToString()));//Delete personal record with selected ID

                dGVPersonalDetails.DataSource = dbConn.GetAllPersonal();//gets all personal records into the datagridview  
            }  
       
        }
    }
}
