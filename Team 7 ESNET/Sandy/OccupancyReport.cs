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
    public partial class OccupancyReport : Form
    {
        public OccupancyReport()
        {
            InitializeComponent();
            SA46Team07BEntities context = new SA46Team07BEntities();
            Sandy.CrystalReportOccup cr = new Sandy.CrystalReportOccup();
            cr.SetDataSource(context.Occupancies);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
