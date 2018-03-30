namespace Team7B_ESNET
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createAndMaintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFacilityInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCheckAvailability = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupancyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bookingCancellationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.createAndMaintainToolStripMenuItem,
            this.menuCheckAvailability,
            this.menuMakeBooking,
            this.menuCancelBooking,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // createAndMaintainToolStripMenuItem
            // 
            this.createAndMaintainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustInfo,
            this.menuFacilityInfo});
            this.createAndMaintainToolStripMenuItem.Name = "createAndMaintainToolStripMenuItem";
            this.createAndMaintainToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.createAndMaintainToolStripMenuItem.Text = "Create and Maintain";
            // 
            // menuCustInfo
            // 
            this.menuCustInfo.Name = "menuCustInfo";
            this.menuCustInfo.Size = new System.Drawing.Size(229, 26);
            this.menuCustInfo.Text = "Customer Information";
            this.menuCustInfo.Click += new System.EventHandler(this.menuCustInfo_Click);
            // 
            // menuFacilityInfo
            // 
            this.menuFacilityInfo.Name = "menuFacilityInfo";
            this.menuFacilityInfo.Size = new System.Drawing.Size(229, 26);
            this.menuFacilityInfo.Text = "Facility Information";
            this.menuFacilityInfo.Click += new System.EventHandler(this.menuFacilityInfo_Click);
            // 
            // menuCheckAvailability
            // 
            this.menuCheckAvailability.Name = "menuCheckAvailability";
            this.menuCheckAvailability.Size = new System.Drawing.Size(138, 24);
            this.menuCheckAvailability.Text = "Check Availability";
            this.menuCheckAvailability.Click += new System.EventHandler(this.menuCheckAvailability_Click);
            // 
            // menuMakeBooking
            // 
            this.menuMakeBooking.Name = "menuMakeBooking";
            this.menuMakeBooking.Size = new System.Drawing.Size(116, 24);
            this.menuMakeBooking.Text = "Make Booking";
            this.menuMakeBooking.Click += new System.EventHandler(this.menuMakeBooking_Click_1);
            // 
            // menuCancelBooking
            // 
            this.menuCancelBooking.Name = "menuCancelBooking";
            this.menuCancelBooking.Size = new System.Drawing.Size(124, 24);
            this.menuCancelBooking.Text = "Cancel Booking";
            this.menuCancelBooking.Click += new System.EventHandler(this.menuCancelBooking_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.occupancyReportToolStripMenuItem,
            this.bookingCancellationReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // occupancyReportToolStripMenuItem
            // 
            this.occupancyReportToolStripMenuItem.Name = "occupancyReportToolStripMenuItem";
            this.occupancyReportToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.occupancyReportToolStripMenuItem.Text = "Occupancy Report";
            this.occupancyReportToolStripMenuItem.Click += new System.EventHandler(this.occupancyReportToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "tsStatus1";
            // 
            // tsStatus1
            // 
            this.tsStatus1.Name = "tsStatus1";
            this.tsStatus1.Size = new System.Drawing.Size(50, 20);
            this.tsStatus1.Text = "Ready";
            // 
            // bookingCancellationReportToolStripMenuItem
            // 
            this.bookingCancellationReportToolStripMenuItem.Name = "bookingCancellationReportToolStripMenuItem";
            this.bookingCancellationReportToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.bookingCancellationReportToolStripMenuItem.Text = "Booking/Cancellation Report";
            this.bookingCancellationReportToolStripMenuItem.Click += new System.EventHandler(this.bookingCancellationReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(276, 26);
            this.toolStripMenuItem2.Text = "Member List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Facility Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createAndMaintainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCustInfo;
        private System.Windows.Forms.ToolStripMenuItem menuFacilityInfo;
        private System.Windows.Forms.ToolStripMenuItem menuCheckAvailability;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus1;
        private System.Windows.Forms.ToolStripMenuItem menuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem menuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupancyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingCancellationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

