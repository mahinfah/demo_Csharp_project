using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_project
{
   
    public partial class Form2 : Form
    {
        private string name, email, password, gender, dob, nid, number;

        private void button1_Click(object sender, EventArgs e)
        {


            name = tusername.Text;
            email = temail.Text;
            password = tpass.Text;
            if (tmale.Checked)
            {
                gender = "Male";
            }
            else if (tfemale.Checked)
            {
                gender = "Female";
            }
            
            dob = temail.Text;
            nid = tnid.Text;
            number = tnumber.Text;

            //            MessageBox.Show("Registration done");
            MessageBox.Show("Name :" + name + " \nEmail :" + email + "\nPassword: " + password + "\nGender: " + gender + "\nBirth Date :" + dob+ "\nNID No :"+nid+ "\nNumber: "+number);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
