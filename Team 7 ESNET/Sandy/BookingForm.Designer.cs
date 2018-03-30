namespace Team7B_ESNET
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelFacility = new System.Windows.Forms.Label();
            this.tbFacilityID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.gbBookingInfo = new System.Windows.Forms.GroupBox();
            this.tbRentalCost = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.cbFacility = new System.Windows.Forms.ComboBox();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.labelSlot = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsBookingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProviderBookingForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbBookingInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookingForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFacility
            // 
            this.labelFacility.AutoSize = true;
            this.labelFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacility.Location = new System.Drawing.Point(34, 82);
            this.labelFacility.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFacility.Name = "labelFacility";
            this.labelFacility.Size = new System.Drawing.Size(62, 20);
            this.labelFacility.TabIndex = 0;
            this.labelFacility.Text = "Facility";
            // 
            // tbFacilityID
            // 
            this.tbFacilityID.Location = new System.Drawing.Point(116, 79);
            this.tbFacilityID.Margin = new System.Windows.Forms.Padding(4);
            this.tbFacilityID.Name = "tbFacilityID";
            this.tbFacilityID.ReadOnly = true;
            this.tbFacilityID.Size = new System.Drawing.Size(56, 27);
            this.tbFacilityID.TabIndex = 1;
            this.tbFacilityID.TextChanged += new System.EventHandler(this.tbFacilityID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member ID";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(200, 64);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(100, 27);
            this.tbMemberID.TabIndex = 3;
            this.toolTip.SetToolTip(this.tbMemberID, "Enter numerical Member ID");
            this.tbMemberID.TextChanged += new System.EventHandler(this.tbMemberID_TextChanged);
            this.tbMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMemberID_KeyDown);
            this.tbMemberID.Leave += new System.EventHandler(this.tbMemberID_Leave);
            // 
            // btnFindMember
            // 
            this.btnFindMember.Location = new System.Drawing.Point(316, 63);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(42, 28);
            this.btnFindMember.TabIndex = 4;
            this.btnFindMember.Text = "...";
            this.toolTip.SetToolTip(this.btnFindMember, "Search Member Names");
            this.btnFindMember.UseVisualStyleBackColor = true;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(200, 104);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.ReadOnly = true;
            this.tbMemberName.Size = new System.Drawing.Size(354, 27);
            this.tbMemberName.TabIndex = 5;
            // 
            // gbBookingInfo
            // 
            this.gbBookingInfo.Controls.Add(this.tbRentalCost);
            this.gbBookingInfo.Controls.Add(this.labelCost);
            this.gbBookingInfo.Controls.Add(this.dtpBookingDate);
            this.gbBookingInfo.Controls.Add(this.cbFacility);
            this.gbBookingInfo.Controls.Add(this.btnAvailability);
            this.gbBookingInfo.Controls.Add(this.tbTime);
            this.gbBookingInfo.Controls.Add(this.tbSlot);
            this.gbBookingInfo.Controls.Add(this.labelSlot);
            this.gbBookingInfo.Controls.Add(this.labelDate);
            this.gbBookingInfo.Controls.Add(this.labelFacility);
            this.gbBookingInfo.Controls.Add(this.tbFacilityID);
            this.gbBookingInfo.Location = new System.Drawing.Point(77, 154);
            this.gbBookingInfo.Name = "gbBookingInfo";
            this.gbBookingInfo.Size = new System.Drawing.Size(524, 263);
            this.gbBookingInfo.TabIndex = 6;
            this.gbBookingInfo.TabStop = false;
            this.gbBookingInfo.Text = "Booking Information";
            // 
            // tbRentalCost
            // 
            this.tbRentalCost.AutoSize = true;
            this.tbRentalCost.Location = new System.Drawing.Point(390, 220);
            this.tbRentalCost.Name = "tbRentalCost";
            this.tbRentalCost.Size = new System.Drawing.Size(18, 20);
            this.tbRentalCost.TabIndex = 12;
            this.tbRentalCost.Text = "$";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(235, 220);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(97, 20);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Rental Cost";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Enabled = false;
            this.dtpBookingDate.Location = new System.Drawing.Point(116, 130);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(363, 27);
            this.dtpBookingDate.TabIndex = 10;
            // 
            // cbFacility
            // 
            this.cbFacility.Enabled = false;
            this.cbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacility.FormattingEnabled = true;
            this.cbFacility.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Soccer",
            "Squash",
            "Table Tennis",
            "Tennis"});
            this.cbFacility.Location = new System.Drawing.Point(180, 78);
            this.cbFacility.Margin = new System.Windows.Forms.Padding(4);
            this.cbFacility.Name = "cbFacility";
            this.cbFacility.Size = new System.Drawing.Size(297, 28);
            this.cbFacility.TabIndex = 9;
            // 
            // btnAvailability
            // 
            this.btnAvailability.Location = new System.Drawing.Point(352, 28);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(125, 29);
            this.btnAvailability.TabIndex = 8;
            this.btnAvailability.Text = "New Search";
            this.toolTip.SetToolTip(this.btnAvailability, "Search or Change Booking Information");
            this.btnAvailability.UseVisualStyleBackColor = true;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(180, 176);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(299, 27);
            this.tbTime.TabIndex = 7;
            // 
            // tbSlot
            // 
            this.tbSlot.Location = new System.Drawing.Point(116, 176);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.ReadOnly = true;
            this.tbSlot.Size = new System.Drawing.Size(56, 27);
            this.tbSlot.TabIndex = 6;
            // 
            // labelSlot
            // 
            this.labelSlot.AutoSize = true;
            this.labelSlot.Location = new System.Drawing.Point(34, 179);
            this.labelSlot.Name = "labelSlot";
            this.labelSlot.Size = new System.Drawing.Size(46, 20);
            this.labelSlot.TabIndex = 5;
            this.labelSlot.Text = "Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(34, 133);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(355, 448);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(160, 38);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Make Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Info;
            this.welcome.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(87, 15);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(181, 29);
            this.welcome.TabIndex = 13;
            this.welcome.Text = "Make a Booking:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBookingStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 25);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsBookingStatus
            // 
            this.tsBookingStatus.Name = "tsBookingStatus";
            this.tsBookingStatus.Size = new System.Drawing.Size(13, 20);
            this.tsBookingStatus.Text = " ";
            // 
            // errorProviderBookingForm
            // 
            this.errorProviderBookingForm.ContainerControl = this;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 533);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.btnFindMember);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbBookingInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Booking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.gbBookingInfo.ResumeLayout(false);
            this.gbBookingInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBookingForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacility;
        private System.Windows.Forms.TextBox tbFacilityID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.GroupBox gbBookingInfo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbSlot;
        private System.Windows.Forms.Label labelSlot;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbFacility;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsBookingStatus;
        private System.Windows.Forms.Label tbRentalCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.ErrorProvider errorProviderBookingForm;
        private System.Windows.Forms.ToolTip toolTip;
    }
}