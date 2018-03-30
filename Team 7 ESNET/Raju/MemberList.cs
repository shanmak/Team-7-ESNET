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
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
            SA46Team07BEntities context = new SA46Team07BEntities();
            CrystalReportMembers cr = new CrystalReportMembers();
            cr.SetDataSource(context.Members);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
