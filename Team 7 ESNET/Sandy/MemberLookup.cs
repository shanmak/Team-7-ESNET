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
    public partial class MemberLookup : Form
    {
        SA46Team07BEntities ctx = new SA46Team07BEntities();
        
        public MemberLookup()
        {
            InitializeComponent();
        }

        private void MemberLookup_Load(object sender, EventArgs e)
        {
            BookingForm.MemberList = ctx.Members.ToList();
            ShowMemberData();
        }

        private void ShowMemberData()
        {
            // Populates the Member Info Grid
            gvMember.DataSource = BookingForm.MemberList.Select(x => new { x.MemberID, x.MemberName, x.Gender, x.Address, x.PhoneNumber}).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            // Triggers the search in the Member List Grid View
            string search = tbFindName.Text;
            gvMember.DataSource = BookingForm.MemberList
                .Where(x => x.MemberName.ToUpper().StartsWith(search.ToUpper()))
                .Select(x => new { x.MemberID, x.MemberName, x.Gender, x.Address, x.PhoneNumber}).ToList();
        }

        private void tbFindName_TextChanged_1(object sender, EventArgs e)
        {
            // Allows Searching as the user types
            btnFindMember.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refreshes grid
            ShowMemberData();
            tbFindName.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Selects MemberID from currently selected row and goes back to Booking Form
            int index = gvMember.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvMember.Rows[index];
            BookingForm.BookingMemberID = Convert.ToInt32(selectedRow.Cells["MemberID"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void gvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK.PerformClick();
        }
    }
}
