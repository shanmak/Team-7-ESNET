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
    public partial class QueryForm : Form
    {
        SA46Team07BEntities ctx = new SA46Team07BEntities();
        List<Availability> avails = new List<Availability>();
        List<Button> slotButtons;
        private static int bookingFacID;
        private static DateTime bookingDate;
        private static int bookingSlot;
        private static bool fromQuery;
        bool availBtnClicked = false;

        public static bool FromQuery { get => fromQuery; set => fromQuery = value; }
        public static int BookingFacID { get => bookingFacID; set => bookingFacID = value; }
        public static DateTime BookingDate { get => bookingDate; set => bookingDate = value; }
        public static int BookingSlot { get => bookingSlot; set => bookingSlot = value; }

        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            avails = ctx.Availabilities.ToList();

            // Allows Booking only for 14 days from tomorrow
            dtpBookingDate.MinDate = DateTime.Today.AddDays(1);
            dtpBookingDate.MaxDate = DateTime.Today.AddDays(14);

            //Fills Data if you have a previous query
            if (FromQuery)
            {
                tbFacility.Text = BookingFacID.ToString();
                Facility f = ctx.Facilities.Where(x => x.FacilityID == QueryForm.BookingFacID).First();
                cbFacility.Text = f.FacilityName.ToString();
                dtpBookingDate.Value = BookingDate;
            }
            else
            {
                BookingDate = DateTime.Today.AddDays(1);
            }

        }

        private void cbFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates FacilityID box and opens up available time slots view

            switch (cbFacility.Text)
            {
                case "Badminton": tbFacility.Text = "1"; break;
                case "Basketball": tbFacility.Text = "2"; break;
                case "Tennis": tbFacility.Text = "3"; break;
                case "Table-Tennis": tbFacility.Text = "4"; break;
                case "Squash": tbFacility.Text = "5"; break;
                default: tbFacility.Text = ""; break;
            }

            if (availBtnClicked) CheckAvail();

            errorProviderQueryForm.SetError(cbFacility, "");
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            if (availBtnClicked) CheckAvail();
        }

        private void SetButton(bool available, Button b)
        {
            if (available == true)
            {
                b.BackColor = Color.Lime;
                b.Enabled = true;
            }

            // Disables Time Slot Button and changes color to red when not available
            else
            {
                b.BackColor = Color.LightCoral;
                b.Enabled = false;
            }
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            // If Facility selection box is empty, show an error
            if (string.IsNullOrEmpty(cbFacility.Text))
            {
                errorProviderQueryForm.SetError(cbFacility, "Please choose a facility!");
            }

            // On first click - show time slots
            else
            {
                availBtnClicked = true;
                CheckAvail();
                gbTimeSlots.Visible = true;
            }
        }


        private void CheckAvail()
        {
            // Checks for availability and populates time slots
            tsQueryStatus.Text = "Note: Booking Slots are only available from tomorrow for the next 2 weeks";
            BookingFacID = Convert.ToInt32(tbFacility.Text);
            BookingDate = dtpBookingDate.Value.Date;

            labelDate.Text = dtpBookingDate.Value.Date.ToString("dddd, dd MMMM yyyy");
            labelFacility.Text = cbFacility.Text;

            Availability a = avails.Where(x => (x.FacilityID == BookingFacID)
            && (x.DateOfBooking == BookingDate)).FirstOrDefault();

            if (a == null)
            {
                tsQueryStatus.Text = "Date not available. Please select another Date";   
            }
            else
            {
                List<Boolean> slots = new List<Boolean>() { a.Slot1, a.Slot2, a.Slot3, a.Slot4, a.Slot5,
                a.Slot6, a.Slot7, a.Slot8, a.Slot9, a.Slot10, a.Slot11, a.Slot12};
                slotButtons = new List<Button>() { btnSlot1, btnSlot2, btnSlot3, btnSlot4, btnSlot5,
                btnSlot6, btnSlot7, btnSlot8, btnSlot9, btnSlot10, btnSlot11, btnSlot12};
                for (int i = 0; i < slots.Count; i++)
                {
                    SetButton(slots[i], slotButtons[i]);
                }
            }
        }

        private void btnSlot_Click(object sender, EventArgs e)
        {
            // Sends Chosen Time Slot back to the Booking Form
            int count = 1;
            FromQuery = true;
            foreach (Button b in slotButtons)
            {
                if (sender == b)
                {
                    BookingSlot = count;

                   //Execute this if we came from the booking form
                    if (BookingForm.FromBooking)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    //Send user to new booking form if we started with the Query Form
                    else
                    {
                        BookingForm bf2 = new BookingForm();
                        bf2.MdiParent = this.MdiParent;
                        bf2.Show();
                        this.Hide();
                    }
                }
                count++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!BookingForm.FromBooking)
                FromQuery = false;
            this.Close();
        }
    }
}
