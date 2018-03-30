namespace Team7B_ESNET
{
    partial class FacilitiesInfo
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
            this.update = new System.Windows.Forms.Button();
            this.FacilityID = new System.Windows.Forms.Label();
            this.FacilityName = new System.Windows.Forms.Label();
            this.RentcalCost = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.FacilityID_textBox = new System.Windows.Forms.TextBox();
            this.FacilityName_textBox = new System.Windows.Forms.TextBox();
            this.RentalCost_textBox = new System.Windows.Forms.TextBox();
            this.Location_textBox = new System.Windows.Forms.TextBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.Findmore = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Prebutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(173, 354);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 31);
            this.update.TabIndex = 0;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // FacilityID
            // 
            this.FacilityID.AutoSize = true;
            this.FacilityID.Location = new System.Drawing.Point(41, 96);
            this.FacilityID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FacilityID.Name = "FacilityID";
            this.FacilityID.Size = new System.Drawing.Size(84, 20);
            this.FacilityID.TabIndex = 1;
            this.FacilityID.Text = "Facility ID";
            this.FacilityID.Click += new System.EventHandler(this.label1_Click);
            // 
            // FacilityName
            // 
            this.FacilityName.AutoSize = true;
            this.FacilityName.Location = new System.Drawing.Point(41, 153);
            this.FacilityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.Size = new System.Drawing.Size(111, 20);
            this.FacilityName.TabIndex = 2;
            this.FacilityName.Text = "Facility Name";
            // 
            // RentcalCost
            // 
            this.RentcalCost.AutoSize = true;
            this.RentcalCost.Location = new System.Drawing.Point(41, 209);
            this.RentcalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RentcalCost.Name = "RentcalCost";
            this.RentcalCost.Size = new System.Drawing.Size(151, 20);
            this.RentcalCost.TabIndex = 3;
            this.RentcalCost.Text = "Rental Cost (SGD)";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(41, 269);
            this.Location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(73, 20);
            this.Location.TabIndex = 4;
            this.Location.Text = "Location";
            this.Location.Click += new System.EventHandler(this.label4_Click);
            // 
            // FacilityID_textBox
            // 
            this.FacilityID_textBox.Location = new System.Drawing.Point(296, 88);
            this.FacilityID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityID_textBox.Name = "FacilityID_textBox";
            this.FacilityID_textBox.Size = new System.Drawing.Size(143, 27);
            this.FacilityID_textBox.TabIndex = 5;
            this.FacilityID_textBox.TextChanged += new System.EventHandler(this.FacilityID_textBox_TextChanged);
            // 
            // FacilityName_textBox
            // 
            this.FacilityName_textBox.Location = new System.Drawing.Point(235, 147);
            this.FacilityName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityName_textBox.Name = "FacilityName_textBox";
            this.FacilityName_textBox.Size = new System.Drawing.Size(272, 27);
            this.FacilityName_textBox.TabIndex = 6;
            // 
            // RentalCost_textBox
            // 
            this.RentalCost_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.RentalCost_textBox.Location = new System.Drawing.Point(235, 206);
            this.RentalCost_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.RentalCost_textBox.Name = "RentalCost_textBox";
            this.RentalCost_textBox.Size = new System.Drawing.Size(272, 27);
            this.RentalCost_textBox.TabIndex = 7;
            // 
            // Location_textBox
            // 
            this.Location_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Location_textBox.Location = new System.Drawing.Point(235, 263);
            this.Location_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Location_textBox.Name = "Location_textBox";
            this.Location_textBox.Size = new System.Drawing.Size(272, 27);
            this.Location_textBox.TabIndex = 8;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.Info;
            this.Welcome.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Welcome.Location = new System.Drawing.Point(13, 9);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(502, 29);
            this.Welcome.TabIndex = 9;
            this.Welcome.Text = "Welcome to Sports Facilities Information System";
            this.Welcome.Click += new System.EventHandler(this.label5_Click);
            // 
            // Findmore
            // 
            this.Findmore.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Findmore.Location = new System.Drawing.Point(533, 88);
            this.Findmore.Margin = new System.Windows.Forms.Padding(4);
            this.Findmore.Name = "Findmore";
            this.Findmore.Size = new System.Drawing.Size(88, 31);
            this.Findmore.TabIndex = 11;
            this.Findmore.Text = "Find";
            this.Findmore.UseVisualStyleBackColor = true;
            this.Findmore.Click += new System.EventHandler(this.Findmore_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(34, 354);
            this.Create.Margin = new System.Windows.Forms.Padding(4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(93, 31);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(328, 354);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(111, 31);
            this.Delete_button.TabIndex = 13;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 25);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(49, 20);
            this.StatusLabel.Text = "Status";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Nextbutton.Location = new System.Drawing.Point(457, 88);
            this.Nextbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(50, 31);
            this.Nextbutton.TabIndex = 15;
            this.Nextbutton.Text = ">";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click_1);
            // 
            // Prebutton
            // 
            this.Prebutton.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Prebutton.Location = new System.Drawing.Point(235, 88);
            this.Prebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Prebutton.Name = "Prebutton";
            this.Prebutton.Size = new System.Drawing.Size(49, 31);
            this.Prebutton.TabIndex = 16;
            this.Prebutton.Text = "<";
            this.Prebutton.UseVisualStyleBackColor = true;
            this.Prebutton.Click += new System.EventHandler(this.Prebutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbutton.Location = new System.Drawing.Point(499, 354);
            this.Resetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(100, 31);
            this.Resetbutton.TabIndex = 17;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // FacilitiesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Findmore);
            this.Controls.Add(this.Prebutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Location_textBox);
            this.Controls.Add(this.RentalCost_textBox);
            this.Controls.Add(this.FacilityName_textBox);
            this.Controls.Add(this.FacilityID_textBox);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.RentcalCost);
            this.Controls.Add(this.FacilityName);
            this.Controls.Add(this.FacilityID);
            this.Controls.Add(this.update);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacilitiesInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilities Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label FacilityID;
        private System.Windows.Forms.Label FacilityName;
        private System.Windows.Forms.Label RentcalCost;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox FacilityID_textBox;
        private System.Windows.Forms.TextBox FacilityName_textBox;
        private System.Windows.Forms.TextBox RentalCost_textBox;
        private System.Windows.Forms.TextBox Location_textBox;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button Findmore;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Prebutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}

