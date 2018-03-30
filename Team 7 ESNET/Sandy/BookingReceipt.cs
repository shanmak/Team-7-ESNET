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
    public partial class BookingReceipt : Form
    {
        public BookingReceipt()
        {
            InitializeComponent();
            SA46Team07BEntities context = new SA46Team07BEntities();
            CrystalReportBookingReceipt cr = new CrystalReportBookingReceipt();
            cr.SetDataSource(context.BookingViews);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;

        }

    }
}
