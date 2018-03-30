using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team7B_ESNET  // Author--Shanmugam Manikandan.
{
    public partial class CancelBookingForm : Form
    {
        // class variable it can access within this class
        SA46Team07BEntities SA46 = new SA46Team07BEntities();
        Booking book;
        int bookinid;
        Availability availability;
        public CancelBookingForm()
        {
            InitializeComponent();

            // when open this form cancel button is disable for Percaution..!
            cancelDis();
        }

        // this Event-handler only allowed numbers in bookingID textbox 
        private void tbBookingID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // This event-handler, after pressing Enter key doing searching....!
        private void tbBookingID_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // method for search in database
                find();
            }
        }

        // if the customer forgot BookingID this handler boot search booking form..!
        // and get back the BookinId 
        private void btnFindBookingID_Click(object sender, EventArgs e)
        {
            //Before going to search-booking form it clear the pervious details in cancel form
            clear();
            tbStatusBar.Text = "Ready..";

            BookingLookup bl1 = new BookingLookup();        
                   
            if (bl1.ShowDialog() == DialogResult.OK)
            {
                //getting ID from search-booking form assign here by using public static variable

                tbBookingID.Text = BookingLookup.getBookName;

                //aftre finding ID to show the booking details by this method

                find();
            }
        }

        //by using this method show the details of booking details 
        public void find()
        {
            //check if textbox is Empty is true.show the status in statusbar
            if (tbBookingID.Text == string.Empty)
            {
                tbStatusBar.Text = "Please Enter the Booking ID";
                clear();
            }
            else
            {
                
                try
                {
                    // geting the bookingID enter
                    bookinid = Convert.ToInt32(tbBookingID.Text.Trim());                        
                        
                    var databook = SA46.Bookings.Where(x => x.BookingID == bookinid);

                    // check bookingID is available in database. if its not available update statusbar
                    if (databook.Count().Equals(0))
                    {
                        tbStatusBar.Text = "Your Booing ID is NOT FOUND";
                        clear();
                    }
                    //  if the bookingID is available in database its show details 
                    else
                    {
                        book = databook.First();
                        show();
                    }


                }

                // Everything is ok but details not visible, so that providing a message to user 
                catch (Exception e)
                {
                    MessageBox.Show("Sorry...! Please Check Your Server Connection.....!");
                }
            }
        }

        // This show the booking details
        public void show()
        {
            tbMemberName.Text = book.Member.MemberName;
            tbFacilityName.Text = book.Facility.FacilityName;
            BookingDate.Text = book.DateOfBooking.ToShortDateString();
            tbSlotTime.Text = book.Slot.ToString();
            tbStatus.Text = book.Status;

            // if cancellation is already done means, its disabled the cancel button 
            // show status 
            if (tbStatus.Text == "cancel")
            {
                tbStatusBar.Text = "Your Booking was already Cancel....";

                // disable cancel button 
                cancelDis();
            }
            // else not cancel,cancel button is enabled
            else
            {
                // Enabled cancel button only for Raedy condition 
                btnSubmit.Enabled = true;
                tbStatusBar.Text = "Ready";
               
            }

           
        }

        // this is for cancel button 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
              // it change the status in database 
                var bookinid = Convert.ToInt32(tbBookingID.Text);
                book = SA46.Bookings.Where(x => x.BookingID == bookinid).First();
                book.Status = "cancel";

            // this is for after cancellation that slot will be to make available 
                var available = from x in SA46.Availabilities where x.FacilityID == book.FacilityID && x.DateOfBooking == book.DateOfBooking select x;
                availability = available.First();

                switch (book.Slot)
                {
                    case 1: availability.Slot1 = true; break;
                    case 2: availability.Slot2 = true; break;
                    case 3: availability.Slot3 = true; break;
                    case 4: availability.Slot4 = true; break;
                    case 5: availability.Slot5 = true; break;
                    case 6: availability.Slot6 = true; break;
                    case 7: availability.Slot7 = true; break;
                    case 8: availability.Slot8 = true; break;
                    case 9: availability.Slot9 = true; break;
                    case 10: availability.Slot10 = true; break;
                    case 11: availability.Slot11 = true; break;
                    case 12: availability.Slot12 = true; break;
                }

                MessageBox.Show("cancel successfully...");
                SA46.SaveChanges();
            // now change the status in textbox into cancel
                tbStatus.Text = "cancel";
            // after cancellation, cancel button disabled.
                cancelDis();

                     
        }

        // method for clear the details in from 
        public void clear()
        {
            tbBookingID.Clear();
            tbMemberName.Clear();
            tbFacilityName.Clear();
            BookingDate.Clear();
            tbSlotTime.Clear();
            tbStatus.Clear();
        }

        // exit this form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           
        // method for cancel button dsabled.
         public void cancelDis()
        {
            btnSubmit.Enabled = false;
        }
    }
}
