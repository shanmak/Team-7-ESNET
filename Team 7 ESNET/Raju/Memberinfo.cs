using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team7B_ESNET
{
    /// <summary>
    /// code done by Prasanth Raju
    /// This module contains the creating the entry for the new members
    /// Updating the details for the members
    /// Searching the member details
    /// 
    /// </summary>
    public partial class MemberInfo : Form
    {
        SA46Team07BEntities context = new SA46Team07BEntities();
        public MemberInfo()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
           
         Member M = new Member();

            M.MemberName = Name_textBox.Text;
            if (rbGenderMale.Checked==true)
             {
                string m = "m";
                M.Gender = m;

            }
            else
            {
                string m    = "f";
                M.Gender = m;
            }
            M.Address = Address_textBox.Text;
            M.PhoneNumber = Phone_textBox.Text;
            context.Members.Add(M);
            context.SaveChanges();
        }

       

        private void Find_Click(object sender, EventArgs e)
        {
            Member M ;
            int i;
            bool res = Int32.TryParse(ID_textBox.Text, out i);
            if (!res)
            {
               
                toolStripStatusLabel1.Text = "Invalid Entry";

            }
            else
            {

                M = context.Members.Where(x => x.MemberID == i).FirstOrDefault();
                if (M != null)
                {
                    Name_textBox.Text = M.MemberName;
                    if (M.Gender == "m")
                    {
                        rbGenderMale.Checked = true;
                    }
                    else
                    {
                        rbGenderFemale.Checked = true;
                    }
                    Address_textBox.Text = M.Address;
                    Phone_textBox.Text = M.PhoneNumber;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Data not present";
                }
            }
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int i=0;
            Member M;
            if (ID_textBox.Text != "")
            {
                i = Convert.ToInt32(ID_textBox.Text);
            }
            M = context.Members.Where(x => x.MemberID == i).FirstOrDefault();
            if (M != null)
            {
                M.MemberName = Name_textBox.Text;
                M.Address = Address_textBox.Text;
                M.PhoneNumber = Phone_textBox.Text;
                if (rbGenderMale.Checked == true)
                {
                    M.Gender = "m";

                }
                else
                {
                    M.Gender = "f";
                }
            }else
            {
                toolStripStatusLabel1.Text = "Data not present in database to be updated";
            }
          //  toolStripStatusLabel1.Text = "Updated Successfully";
           // toolStripStatusLabel1.Text = "Ready";
                context.SaveChanges();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////this.Controls.Clear();
            // MemberInfo n = new MemberInfo();
            ID_textBox.Clear();
            Name_textBox.Clear();
            Address_textBox.Clear();
            Phone_textBox.Clear();


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
