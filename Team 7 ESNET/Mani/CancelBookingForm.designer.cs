namespace Team7B_ESNET
{
    partial class CancelBookingForm
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
            this.labelBookingID = new System.Windows.Forms.Label();
            this.tbBookingID = new System.Windows.Forms.TextBox();
            this.tbMemberName = new System.Windows.Forms.TextBox();
            this.btnFindBookingID = new System.Windows.Forms.Button();
            this.tbFacilityName = new System.Windows.Forms.TextBox();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.labelFacilityName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSlot = new System.Windows.Forms.Label();
            this.tbSlotTime = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.BookingDate = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBookingID
            // 
            this.labelBookingID.AutoSize = true;
            this.labelBookingID.Location = new System.Drawing.Point(122, 82);
            this.labelBookingID.Name = "labelBookingID";
            this.labelBookingID.Size = new System.Drawing.Size(91, 20);
            this.labelBookingID.TabIndex = 0;
            this.labelBookingID.Text = "Booking ID";
            // 
            // tbBookingID
            // 
            this.tbBookingID.Location = new System.Drawing.Point(268, 76);
            this.tbBookingID.Name = "tbBookingID";
            this.tbBookingID.Size = new System.Drawing.Size(100, 27);
            this.tbBookingID.TabIndex = 1;
            this.tbBookingID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookingID_KeyPress);
            this.tbBookingID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBookingID_KeyUp);
            // 
            // tbMemberName
            // 
            this.tbMemberName.Location = new System.Drawing.Point(268, 124);
            this.tbMemberName.Name = "tbMemberName";
            this.tbMemberName.ReadOnly = true;
            this.tbMemberName.Size = new System.Drawing.Size(152, 27);
            this.tbMemberName.TabIndex = 2;
            // 
            // btnFindBookingID
            // 
            this.btnFindBookingID.Location = new System.Drawing.Point(375, 76);
            this.btnFindBookingID.Name = "btnFindBookingID";
            this.btnFindBookingID.Size = new System.Drawing.Size(45, 27);
            this.btnFindBookingID.TabIndex = 3;
            this.btnFindBookingID.Text = "...";
            this.btnFindBookingID.UseVisualStyleBackColor = true;
            this.btnFindBookingID.Click += new System.EventHandler(this.btnFindBookingID_Click);
            // 
            // tbFacilityName
            // 
            this.tbFacilityName.Location = new System.Drawing.Point(268, 172);
            this.tbFacilityName.Name = "tbFacilityName";
            this.tbFacilityName.ReadOnly = true;
            this.tbFacilityName.Size = new System.Drawing.Size(152, 27);
            this.tbFacilityName.TabIndex = 4;
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(122, 130);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(119, 20);
            this.labelMemberName.TabIndex = 5;
            this.labelMemberName.Text = "Member Name";
            // 
            // labelFacilityName
            // 
            this.labelFacilityName.AutoSize = true;
            this.labelFacilityName.Location = new System.Drawing.Point(122, 178);
            this.labelFacilityName.Name = "labelFacilityName";
            this.labelFacilityName.Size = new System.Drawing.Size(111, 20);
            this.labelFacilityName.TabIndex = 6;
            this.labelFacilityName.Text = "Facility Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Booking Date";
            // 
            // labelSlot
            // 
            this.labelSlot.AutoSize = true;
            this.labelSlot.Location = new System.Drawing.Point(122, 274);
            this.labelSlot.Name = "labelSlot";
            this.labelSlot.Size = new System.Drawing.Size(103, 20);
            this.labelSlot.TabIndex = 9;
            this.labelSlot.Text = "Booking Slot";
            // 
            // tbSlotTime
            // 
            this.tbSlotTime.Location = new System.Drawing.Point(268, 268);
            this.tbSlotTime.Name = "tbSlotTime";
            this.tbSlotTime.ReadOnly = true;
            this.tbSlotTime.Size = new System.Drawing.Size(152, 27);
            this.tbSlotTime.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(375, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 46);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Cancel Booking";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(196, 390);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 46);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Info;
            this.welcome.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(131, 21);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(206, 29);
            this.welcome.TabIndex = 14;
            this.welcome.Text = "Cancel a Booking...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Booking Status";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(268, 322);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(152, 27);
            this.tbStatus.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStatusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 25);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbStatusBar
            // 
            this.tbStatusBar.Name = "tbStatusBar";
            this.tbStatusBar.Size = new System.Drawing.Size(50, 20);
            this.tbStatusBar.Text = "Ready";
            // 
            // BookingDate
            // 
            this.BookingDate.Location = new System.Drawing.Point(268, 224);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.ReadOnly = true;
            this.BookingDate.Size = new System.Drawing.Size(152, 27);
            this.BookingDate.TabIndex = 18;
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 503);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbSlotTime);
            this.Controls.Add(this.labelSlot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFacilityName);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.tbFacilityName);
            this.Controls.Add(this.btnFindBookingID);
            this.Controls.Add(this.tbMemberName);
            this.Controls.Add(this.tbBookingID);
            this.Controls.Add(this.labelBookingID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Bookings";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookingID;
        private System.Windows.Forms.TextBox tbBookingID;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.Button btnFindBookingID;
        private System.Windows.Forms.TextBox tbFacilityName;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Label labelFacilityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSlot;
        private System.Windows.Forms.TextBox tbSlotTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tbStatusBar;
        private System.Windows.Forms.TextBox BookingDate;
    }
}