namespace Team7B_ESNET
{
    partial class BookingLookup
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
            this.labelMemberName = new System.Windows.Forms.Label();
            this.tbSearchMemberName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindBookingID = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbStatusBar = new System.Windows.Forms.StatusStrip();
            this.BookingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(56, 51);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(119, 20);
            this.labelMemberName.TabIndex = 6;
            this.labelMemberName.Text = "Member Name";
            // 
            // tbSearchMemberName
            // 
            this.tbSearchMemberName.Location = new System.Drawing.Point(194, 48);
            this.tbSearchMemberName.Name = "tbSearchMemberName";
            this.tbSearchMemberName.Size = new System.Drawing.Size(247, 27);
            this.tbSearchMemberName.TabIndex = 7;
            this.tbSearchMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchMemberName_KeyPress);
            this.tbSearchMemberName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchMemberName_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(92, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 243);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MemberName";
            this.Column1.HeaderText = "MemberName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookingID";
            this.Column2.HeaderText = "BookingID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FacilityName";
            this.Column3.HeaderText = "FacilityName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phonenumber";
            this.Column4.HeaderText = "MemberPhoneNumber";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnFindBookingID
            // 
            this.btnFindBookingID.Location = new System.Drawing.Point(464, 48);
            this.btnFindBookingID.Name = "btnFindBookingID";
            this.btnFindBookingID.Size = new System.Drawing.Size(155, 27);
            this.btnFindBookingID.TabIndex = 9;
            this.btnFindBookingID.Text = "Find Bookings";
            this.btnFindBookingID.UseVisualStyleBackColor = true;
            this.btnFindBookingID.Click += new System.EventHandler(this.btnFindBookingID_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(337, 363);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbStatusBar
            // 
            this.tbStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookingStatus});
            this.tbStatusBar.Location = new System.Drawing.Point(0, 428);
            this.tbStatusBar.Name = "tbStatusBar";
            this.tbStatusBar.Size = new System.Drawing.Size(682, 25);
            this.tbStatusBar.TabIndex = 12;
            this.tbStatusBar.Text = "statusStrip1";
            // 
            // BookingStatus
            // 
            this.BookingStatus.Name = "BookingStatus";
            this.BookingStatus.Size = new System.Drawing.Size(50, 20);
            this.BookingStatus.Text = "Ready";
            // 
            // BookingLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.tbStatusBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFindBookingID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbSearchMemberName);
            this.Controls.Add(this.labelMemberName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbStatusBar.ResumeLayout(false);
            this.tbStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox tbSearchMemberName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFindBookingID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.StatusStrip tbStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel BookingStatus;
    }
}