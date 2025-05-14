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
    public partial class Form1 : Form
    {

        private string uname="sadia";
        private string pass="123";
        public Form1()
        {
            InitializeComponent();
        }

        private void LBLPASS_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(uname==name.Text&&pass==password.Text)
            {
                 MessageBox.Show("login done");
            }
         
        }


    }
}
