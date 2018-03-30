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
    public partial class FacilitiesInfo : Form

    {
        SA46Team07BEntities context = new SA46Team07BEntities();
        Facility f = new Facility();
        public FacilitiesInfo()
        {
            InitializeComponent();
        }
        public void status()
        {
            StatusLabel.Text = "Ready";
        }
        private void PopulateTextboxes()
        {
            FacilityID_textBox.Text = f.FacilityID.ToString();
            FacilityName_textBox.Text = f.FacilityName;
            RentalCost_textBox.Text = String.Format("{0:0.00}",f.Cost);
            Location_textBox.Text = f.Location;
        }
        private void RetrieveUIValues()
        {
            f.FacilityID = Convert.ToInt32(FacilityID_textBox.Text);
            f.FacilityName = FacilityName_textBox.Text;
            f.Cost = Convert.ToDecimal(RentalCost_textBox.Text);
            f.Location = Location_textBox.Text;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FacilityID_textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Findmore_Click(object sender, EventArgs e)
        {
            if (FacilityID_textBox.Text == "")
            {
                FacilityID_textBox.Text = null;
                FacilityName_textBox.Text = null;
                RentalCost_textBox.Text = null;
                Location_textBox.Text = null;
                StatusLabel.Text = "Finding... Please enter a FacilityID";
            }
            else
            {
                int j = Convert.ToInt32(FacilityID_textBox.Text);
                if (j > context.Facilities.Count())
                {
                    StatusLabel.Text = "no found ! The facility is not exist ";
                }
                else
                {
                    for (int i = 1; i <= context.Facilities.Count(); i++)
                    {
                        f = context.Facilities.Where(x => x.FacilityID == i).FirstOrDefault();
                        if (f.FacilityID.ToString() == FacilityID_textBox.Text.Trim())
                        {
                            PopulateTextboxes();
                            StatusLabel.Text = "Find complete ! ";
                            break;
                        }
                    }
                }
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (FacilityID_textBox.Text == "")
            {
                FacilityName_textBox.Text = null;
                RentalCost_textBox.Text = null;
                Location_textBox.Text = null;
                StatusLabel.Text = "Updating...Please select the Facility which you want to update ";
            }
            else
            {
                RetrieveUIValues();
                context.SaveChanges();
                FacilityID_textBox.Text = null;
                FacilityName_textBox.Text = null;
                RentalCost_textBox.Text = null;
                Location_textBox.Text = null;
                StatusLabel.Text = "Update complete ! ";
            }
                
        }
        private void Create_Click(object sender, EventArgs e)
        {
            if (FacilityID_textBox.Text == "" || FacilityName_textBox.Text == "" || RentalCost_textBox.Text == "" || Location_textBox.Text == "")
            {
                StatusLabel.Text = "Creating... Please enter detail information  ";
            }
            else
            {
                f.FacilityID = Convert.ToInt32(FacilityID_textBox.Text);
                f.FacilityName = FacilityName_textBox.Text;
                f.Cost = Convert.ToDecimal(RentalCost_textBox.Text);
                f.Location = Location_textBox.Text;
                context.Facilities.Add(f);
                context.SaveChanges();
                FacilityID_textBox.Text = null;
                FacilityName_textBox.Text = null;
                RentalCost_textBox.Text = null;
                Location_textBox.Text = null;
                StatusLabel.Text = "Create complete ! ";
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            
            if (FacilityID_textBox.Text == "" && FacilityName_textBox.Text == "" && RentalCost_textBox.Text == "" && Location_textBox.Text == "")
            {
                StatusLabel.Text = "Deleting... Please select the facility which you want to delete ";
            }
            else
            {
                int i = Convert.ToInt32(FacilityID_textBox.Text);
                f = context.Facilities.Where(x => x.FacilityID == i).FirstOrDefault();
                context.Facilities.Remove(f);
                context.SaveChanges();
                FacilityID_textBox.Text = null;
                FacilityName_textBox.Text = null;
                RentalCost_textBox.Text = null;
                Location_textBox.Text = null;
                StatusLabel.Text = "Delete complete ! ";
            }
        }

        private void Prebutton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(FacilityID_textBox.Text);
            if (i > 1)
            {
                do
                {
                    i--;
                    f = context.Facilities.Where(x => x.FacilityID == i).FirstOrDefault();
                } while (f==null);
                PopulateTextboxes();
                status();
            }
            else
            if(i==1)
            {
                StatusLabel.Text = "This is the first facility!";
            }
        }

        private void Nextbutton_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(FacilityID_textBox.Text);
            if (i < context.Facilities.Count()&&i!=0)
            {
                do
                {
                    i++;
                    f = context.Facilities.Where(x => x.FacilityID == i).FirstOrDefault();

                }
                while (f == null);
                PopulateTextboxes();
                status();

            }
            else
            if (i== context.Facilities.Count())
            {
                StatusLabel.Text = "This is the last facility!";
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            FacilityID_textBox.Text = null;
            FacilityName_textBox.Text = null;
            RentalCost_textBox.Text = null;
            Location_textBox.Text = null;
            status();

        }
    }
}

