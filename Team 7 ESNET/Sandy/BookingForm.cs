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

    public partial class BookingForm : Form
    {
        SA46Team07BEntities ctx = new SA46Team07BEntities();
        private static List<Member> memberList = new List<Member>();
        private static int bookingMemberID;
        private static bool fromBooking;
        bool isMember;

        public static List<Member> MemberList { get => memberList; set => memberList = value; }
        public static int BookingMemberID { get => bookingMemberID; set => bookingMemberID = value; }
        public static bool FromBooking { get => fromBooking; private set => fromBooking = value; }

        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            MemberList = ctx.Members.ToList();

            //If Coming from Query Form, populate fields with Query Data
            if (QueryForm.FromQuery)
            {
                DisplayBookingInfo();
            }
        }

        private void DisplayBookingInfo()
        {
            // Fills Facility Booking Information Boxes
            tbFacilityID.Text = QueryForm.BookingFacID.ToString();
            dtpBookingDate.Value = QueryForm.BookingDate;
            tbSlot.Text = QueryForm.BookingSlot.ToString();
            Facility f = ctx.Facilities.Where(x => x.FacilityID == QueryForm.BookingFacID).First();
            cbFacility.Text = f.FacilityName.ToString();
            tbRentalCost.Text = string.Format("{0:C}", f.Cost);
            tbTime.Text = ctx.Slots.Where(x => x.SlotNum == QueryForm.BookingSlot).Select(x => x.SlotTime).First().ToString();
            tsBookingStatus.Text = "Available Time Slot Added";
        }

        private void DisplayMemberName()
        {
            // Shows Member Name based on ID entered
            int a;
            bool isInteger = Int32.TryParse(tbMemberID.Text.Trim(), out a);

            if (isInteger)
            {
                BookingMemberID = a;
                if (MemberList.Any(x => x.MemberID == BookingMemberID))
                {
                    isMember = true;
                    tbMemberName.Text = MemberList.Where(x => x.MemberID == BookingMemberID).Select(x => x.MemberName).First().ToString();
                    tsBookingStatus.Text = "Member ID: " + BookingMemberID;
                }
                else
                {
                    tsBookingStatus.Text = "Error: Member does not exist.";
                    errorProviderBookingForm.SetError(tbMemberID, "Please choose a valid Member ID!");
                    isMember = false;
                    tbMemberName.Text = "";
                }
            }
            else
            {
                tsBookingStatus.Text = "Please enter a valid MemberID Number";
            }
        }

        private void tbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            // Populates Name field upon hitting enter, or shows an error in status bar if incorrect input
            if (e.KeyCode == Keys.Enter)
            {
                DisplayMemberName();
            }
        }
        private void tbMemberID_Leave(object sender, EventArgs e)
        {
            DisplayMemberName();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            // Directs user to Member Lookup Form and Returns MemberID
            MemberLookup ml1 = new MemberLookup();

            if (ml1.ShowDialog() == DialogResult.OK)
            {
                tbMemberID.Text = BookingMemberID.ToString();
                DisplayMemberName();
            }
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            // Opens Query Form to allow user to select availabile time slots or change time slots
            QueryForm qf2 = new QueryForm();
            FromBooking = true;
            if (qf2.ShowDialog() == DialogResult.OK)
            {
                DisplayBookingInfo();
                FromBooking = false;
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // Performs Check for empty fields or wrong memberID
            if (!(BookingMemberID == 0 || isMember == false || QueryForm.BookingFacID == 0))
            {


                // Makes sure slot is still available at the time of hitting the booking button
                // Another user might have taken the slot in the meantime
                if (UpdateAvailability())   // If slot is available, books the slot
                {
                    Booking b = new Booking();
                    b.FacilityID = QueryForm.BookingFacID;
                    b.MemberID = Convert.ToInt32(tbMemberID.Text);
                    b.DateOfBooking = QueryForm.BookingDate;
                    b.Slot = QueryForm.BookingSlot;
                    b.Status = "Booked";
                    ctx.Bookings.Add(b);
                    ctx.SaveChanges();

                    tsBookingStatus.Text = "Slot Booked. Please wait for Receipt";
                    BookingReceipt receipt = new BookingReceipt();
                    receipt.Show();
                    QueryForm.FromQuery = false;
                    this.Close();
                }
                else
                {
                    tsBookingStatus.Text = "Sorry! That slot is no longer available!";
                }
            }
            else
            {
                // Sets Error Provider Messages/ Status Bar Message to alert user what to fill in
                if (string.IsNullOrEmpty(tbMemberID.Text))
                {
                    errorProviderBookingForm.SetError(tbMemberID, "Please choose a Member ID!");
                }
                if (string.IsNullOrEmpty(cbFacility.Text))
                {
                    errorProviderBookingForm.SetError(btnAvailability, "Please choose an booking date/time");
                }
                tsBookingStatus.Text = "Error: Please enter valid Member ID or Facility Booking Information.";
            }
        }

        private bool UpdateAvailability()
        {
            // Checks for availability upon Booking and books the slot if it is available
            // Please pardon the large switch as I am unable to specify field with the column name in EF
            Availability a = ctx.Availabilities.Where(x => (x.FacilityID == QueryForm.BookingFacID) && (x.DateOfBooking == QueryForm.BookingDate)).First();
            switch (QueryForm.BookingSlot)
            {
                case 1: if (!a.Slot1) return false; else a.Slot1 = false; break;
                case 2: if (!a.Slot2) return false; else a.Slot2 = false; break;
                case 3: if (!a.Slot3) return false; else a.Slot3 = false; break;
                case 4: if (!a.Slot4) return false; else a.Slot4 = false; break;
                case 5: if (!a.Slot5) return false; else a.Slot5 = false; break;
                case 6: if (!a.Slot6) return false; else a.Slot6 = false; break;
                case 7: if (!a.Slot7) return false; else a.Slot7 = false; break;
                case 8: if (!a.Slot8) return false; else a.Slot8 = false; break;
                case 9: if (!a.Slot9) return false; else a.Slot9 = false; break;
                case 10: if (!a.Slot10) return false; else a.Slot10 = false; break;
                case 11: if (!a.Slot11) return false; else a.Slot11 = false; break;
                case 12: if (!a.Slot12) return false; else a.Slot12 = false; break;
            }
            ctx.SaveChanges();
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            QueryForm.FromQuery = false;
            this.Close();
        }

        private void BookingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            QueryForm.FromQuery = false;
        }

        private void tbMemberID_TextChanged(object sender, EventArgs e)
        {
            // Removes Error upon typing ID
            if (!string.IsNullOrEmpty(tbMemberID.Text))
            {
                errorProviderBookingForm.SetError(tbMemberID, "");
            }
        }

        private void tbFacilityID_TextChanged(object sender, EventArgs e)
        {
            // Removes Error upon choosing Date
            if (!string.IsNullOrEmpty(tbFacilityID.Text))
            {
                errorProviderBookingForm.SetError(btnAvailability, "");
            }
        }
    }
}
