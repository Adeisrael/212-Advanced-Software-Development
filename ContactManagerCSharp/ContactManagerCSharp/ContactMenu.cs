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
    public partial class ContactMenu : Form
    {
        public ContactMenu()
        {
            InitializeComponent();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            PersonalEditor personal = new PersonalEditor();
            personal.Show(); //show personal editor form when button is clicked 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessEditor business = new BusinessEditor();
            business.Show(); //show business editor form when button is clicked

        }
    }
}
