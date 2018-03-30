using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team7B_ESNET  //Author---Shanmugam Manikandan.
{
    public partial class BookingLookup : Form
    {
        //class variable 
        SA46Team07BEntities SA46 = new SA46Team07BEntities();

       // using  pubilc static variable used in anywhere.
        public static string getBookName;
        Member m;
       public BookingLookup()
        {
            InitializeComponent();

            // display all booked details
            DisplayAllData();
        }
        // this will allowed only letters in search box
        private void tbSearchMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // after pressing enter key doing searching...
        private void tbSearchMemberName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
               // searching data in database...
                find();
            }
        }

        private void btnFindBookingID_Click(object sender, EventArgs e)
        {
            // finding button also searching data in database...
            find();

        }

        // finding data in database
        public void find()
        {
            

            var membername = tbSearchMemberName.Text.Trim();

            try
            {
                // finding bookingID by name of customer 
                var member = from x in SA46.Members where x.MemberName == membername select x;

                if (member.Count().Equals(0))
                {
                    // if customer data is not in database show message in statusbar
                    BookingStatus.Text = " Record Not Found...!";              
                   

                } 
                else // display the deatils of booking details. if customer not yet booking status to display
                {
                     m = member.First();
                    var n = m.MemberID;
                    var b = from y in SA46.Bookings where y.MemberID == n select new { y.Member.MemberName, y.BookingID, y.Facility.FacilityName, y.Member.PhoneNumber };
                    dataGridView1.DataSource = b.ToList();

                    if (dataGridView1.RowCount.Equals(0))
                    {
                        BookingStatus.Text = "Customer not yet to be Booking...";
                    }
                    else
                    {
                        BookingStatus.Text = "Ready..";
                    }
                  
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Sorry...!Please Check Your Server Connection.....!");
            }
        }
       

        private void btnOK_Click(object sender, EventArgs e)
        {

            selection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selection();
        }


        public void selection()
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            getBookName = selectedRow.Cells[1].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }


        public void DisplayAllData()
        {
            var b = from y in SA46.Bookings  select new { y.Member.MemberName, y.BookingID, y.Facility.FacilityName, y.Member.PhoneNumber };
            dataGridView1.DataSource = b.ToList();
        }
        
       
    }


}

