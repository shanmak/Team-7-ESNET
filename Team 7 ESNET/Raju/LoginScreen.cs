using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team7B_ESNET
{
    //code done by Prasanth Raju
    //validate the login details and allow the admin to enter the system
    public partial class LoginScreen : Form
    {
        static int attempt = 3;
        
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SA46Team07BEntities context = new SA46Team07BEntities();
            string user = tbUsername.Text;
            string pwd = tbPassword.Text;
            var qry = (from x in context.Logins select x.UserID).First();
            var qry1 = (from x in context.Logins select x.Password).First();
            if ((qry == user) && (qry1 == pwd))
            {
                attempt = 0;
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else if ((attempt <= 3) && (attempt > 0))
            {
                MessageBox.Show ("Invalid credentials......You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
                   
              //  MessageBox.Show("Invalid credentials....Please re-enter your userid and password");
            }
            else
            {
                MessageBox.Show("you are not granted with access");

                this.Close();
            }

        }
    }
}
