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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SplashPhoto;
        }

        private void CloseWindows()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void menuMakeBooking_Click(object sender, EventArgs e)
        {
            CloseWindows();
            BookingForm bf1 = new BookingForm();
            bf1.MdiParent = this;
            bf1.Show();
        }

        private void menuCancelBooking_Click(object sender, EventArgs e)
        {
            CloseWindows();
            CancelBookingForm cf1 = new CancelBookingForm();
            cf1.MdiParent = this;
            cf1.Show();
        }

        private void menuCheckAvailability_Click(object sender, EventArgs e)
        {
            CloseWindows();
            QueryForm qf1 = new QueryForm();
            qf1.MdiParent = this;
            qf1.Show();
        }

        private void menuMakeBooking_Click_1(object sender, EventArgs e)
        {
            CloseWindows();
            BookingForm bf1 = new BookingForm();
            bf1.MdiParent = this;
            bf1.Show();
        }

        private void menuCustInfo_Click(object sender, EventArgs e)
        {
            CloseWindows();
            MemberInfo mi1 = new MemberInfo();
            mi1.MdiParent = this;
            mi1.Show();
        }

        private void menuFacilityInfo_Click(object sender, EventArgs e)
        {
            CloseWindows();
            FacilitiesInfo fi1 = new FacilitiesInfo();
            fi1.MdiParent = this;
            fi1.Show();
        }

        private void menuCancelBooking_Click_1(object sender, EventArgs e)
        {
            CloseWindows();
            CancelBookingForm cb1 = new CancelBookingForm();
            cb1.MdiParent = this;
            cb1.Show();
        }

        private void occupancyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWindows();
            OccupancyReport or1 = new OccupancyReport();
            or1.MdiParent = this;
            or1.Show();
        }

        private void bookingCancellationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWindows();
            report bc1 = new report();
            bc1.MdiParent = this;
            bc1.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseWindows();
            MemberList ml1 = new MemberList();
            ml1.MdiParent = this;
            ml1.Show();
        }
    }
}
