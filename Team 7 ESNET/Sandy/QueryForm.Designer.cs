namespace Team7B_ESNET
{
    partial class QueryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFacility = new System.Windows.Forms.ComboBox();
            this.tbFacility = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.gbTimeSlots = new System.Windows.Forms.GroupBox();
            this.labelFacility = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelExample2 = new System.Windows.Forms.Label();
            this.labelExample1 = new System.Windows.Forms.Label();
            this.btnExample2 = new System.Windows.Forms.Button();
            this.btnExample1 = new System.Windows.Forms.Button();
            this.btnSlot12 = new System.Windows.Forms.Button();
            this.btnSlot11 = new System.Windows.Forms.Button();
            this.btnSlot10 = new System.Windows.Forms.Button();
            this.btnSlot9 = new System.Windows.Forms.Button();
            this.btnSlot8 = new System.Windows.Forms.Button();
            this.btnSlot7 = new System.Windows.Forms.Button();
            this.btnSlot6 = new System.Windows.Forms.Button();
            this.btnSlot5 = new System.Windows.Forms.Button();
            this.btnSlot4 = new System.Windows.Forms.Button();
            this.btnSlot3 = new System.Windows.Forms.Button();
            this.btnSlot2 = new System.Windows.Forms.Button();
            this.btnSlot1 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsQueryStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProviderQueryForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipQueryForm = new System.Windows.Forms.ToolTip(this.components);
            this.gbTimeSlots.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQueryForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facility";
            // 
            // cbFacility
            // 
            this.cbFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFacility.FormattingEnabled = true;
            this.cbFacility.Items.AddRange(new object[] {
            "Badminton",
            "Basketball",
            "Squash",
            "Table-Tennis",
            "Tennis"});
            this.cbFacility.Location = new System.Drawing.Point(303, 66);
            this.cbFacility.Margin = new System.Windows.Forms.Padding(4);
            this.cbFacility.Name = "cbFacility";
            this.cbFacility.Size = new System.Drawing.Size(239, 28);
            this.cbFacility.TabIndex = 1;
            this.toolTipQueryForm.SetToolTip(this.cbFacility, "Choose Facility to Book");
            this.cbFacility.SelectedIndexChanged += new System.EventHandler(this.cbFacility_SelectedIndexChanged);
            // 
            // tbFacility
            // 
            this.tbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacility.Location = new System.Drawing.Point(249, 66);
            this.tbFacility.Margin = new System.Windows.Forms.Padding(4);
            this.tbFacility.Name = "tbFacility";
            this.tbFacility.ReadOnly = true;
            this.tbFacility.Size = new System.Drawing.Size(46, 27);
            this.tbFacility.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(249, 107);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(293, 27);
            this.dtpBookingDate.TabIndex = 5;
            this.toolTipQueryForm.SetToolTip(this.dtpBookingDate, "Choose Date to Book Facility For");
            this.dtpBookingDate.Value = new System.DateTime(2018, 3, 23, 1, 4, 44, 0);
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // btnAvailability
            // 
            this.btnAvailability.Location = new System.Drawing.Point(338, 150);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(204, 32);
            this.btnAvailability.TabIndex = 6;
            this.btnAvailability.Text = "Check Availability";
            this.btnAvailability.UseVisualStyleBackColor = true;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // gbTimeSlots
            // 
            this.gbTimeSlots.Controls.Add(this.labelFacility);
            this.gbTimeSlots.Controls.Add(this.labelDate);
            this.gbTimeSlots.Controls.Add(this.labelExample2);
            this.gbTimeSlots.Controls.Add(this.labelExample1);
            this.gbTimeSlots.Controls.Add(this.btnExample2);
            this.gbTimeSlots.Controls.Add(this.btnExample1);
            this.gbTimeSlots.Controls.Add(this.btnSlot12);
            this.gbTimeSlots.Controls.Add(this.btnSlot11);
            this.gbTimeSlots.Controls.Add(this.btnSlot10);
            this.gbTimeSlots.Controls.Add(this.btnSlot9);
            this.gbTimeSlots.Controls.Add(this.btnSlot8);
            this.gbTimeSlots.Controls.Add(this.btnSlot7);
            this.gbTimeSlots.Controls.Add(this.btnSlot6);
            this.gbTimeSlots.Controls.Add(this.btnSlot5);
            this.gbTimeSlots.Controls.Add(this.btnSlot4);
            this.gbTimeSlots.Controls.Add(this.btnSlot3);
            this.gbTimeSlots.Controls.Add(this.btnSlot2);
            this.gbTimeSlots.Controls.Add(this.btnSlot1);
            this.gbTimeSlots.Location = new System.Drawing.Point(66, 210);
            this.gbTimeSlots.Name = "gbTimeSlots";
            this.gbTimeSlots.Size = new System.Drawing.Size(595, 302);
            this.gbTimeSlots.TabIndex = 10;
            this.gbTimeSlots.TabStop = false;
            this.gbTimeSlots.Text = "Time Slots - Click to go to Booking Screen";
            this.gbTimeSlots.Visible = false;
            // 
            // labelFacility
            // 
            this.labelFacility.AutoSize = true;
            this.labelFacility.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacility.Location = new System.Drawing.Point(31, 30);
            this.labelFacility.Name = "labelFacility";
            this.labelFacility.Size = new System.Drawing.Size(124, 29);
            this.labelFacility.TabIndex = 27;
            this.labelFacility.Text = "Badminton";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(299, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 29);
            this.labelDate.TabIndex = 26;
            this.labelDate.Text = "Date";
            // 
            // labelExample2
            // 
            this.labelExample2.AutoSize = true;
            this.labelExample2.Location = new System.Drawing.Point(354, 251);
            this.labelExample2.Name = "labelExample2";
            this.labelExample2.Size = new System.Drawing.Size(107, 20);
            this.labelExample2.TabIndex = 25;
            this.labelExample2.Text = "Not Available";
            // 
            // labelExample1
            // 
            this.labelExample1.AutoSize = true;
            this.labelExample1.Location = new System.Drawing.Point(189, 251);
            this.labelExample1.Name = "labelExample1";
            this.labelExample1.Size = new System.Drawing.Size(76, 20);
            this.labelExample1.TabIndex = 24;
            this.labelExample1.Text = "Available";
            // 
            // btnExample2
            // 
            this.btnExample2.BackColor = System.Drawing.Color.LightCoral;
            this.btnExample2.Enabled = false;
            this.btnExample2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExample2.Location = new System.Drawing.Point(304, 246);
            this.btnExample2.Name = "btnExample2";
            this.btnExample2.Size = new System.Drawing.Size(35, 30);
            this.btnExample2.TabIndex = 23;
            this.btnExample2.UseVisualStyleBackColor = false;
            // 
            // btnExample1
            // 
            this.btnExample1.BackColor = System.Drawing.Color.Lime;
            this.btnExample1.Enabled = false;
            this.btnExample1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExample1.Location = new System.Drawing.Point(138, 246);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(35, 30);
            this.btnExample1.TabIndex = 22;
            this.btnExample1.UseVisualStyleBackColor = false;
            // 
            // btnSlot12
            // 
            this.btnSlot12.BackColor = System.Drawing.Color.Lime;
            this.btnSlot12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot12.Location = new System.Drawing.Point(427, 184);
            this.btnSlot12.Name = "btnSlot12";
            this.btnSlot12.Size = new System.Drawing.Size(123, 39);
            this.btnSlot12.TabIndex = 21;
            this.btnSlot12.Text = "9 pm - 10 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot12, "Choose this Slot Time and go to Booking Form");
            this.btnSlot12.UseVisualStyleBackColor = false;
            this.btnSlot12.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot11
            // 
            this.btnSlot11.BackColor = System.Drawing.Color.Lime;
            this.btnSlot11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot11.Location = new System.Drawing.Point(298, 184);
            this.btnSlot11.Name = "btnSlot11";
            this.btnSlot11.Size = new System.Drawing.Size(123, 39);
            this.btnSlot11.TabIndex = 20;
            this.btnSlot11.Text = "8 pm - 9 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot11, "Choose this Slot Time and go to Booking Form");
            this.btnSlot11.UseVisualStyleBackColor = false;
            this.btnSlot11.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot10
            // 
            this.btnSlot10.BackColor = System.Drawing.Color.Lime;
            this.btnSlot10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot10.Location = new System.Drawing.Point(169, 184);
            this.btnSlot10.Name = "btnSlot10";
            this.btnSlot10.Size = new System.Drawing.Size(123, 39);
            this.btnSlot10.TabIndex = 19;
            this.btnSlot10.Text = "7 pm - 8 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot10, "Choose this Slot Time and go to Booking Form");
            this.btnSlot10.UseVisualStyleBackColor = false;
            this.btnSlot10.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot9
            // 
            this.btnSlot9.BackColor = System.Drawing.Color.Lime;
            this.btnSlot9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot9.Location = new System.Drawing.Point(36, 184);
            this.btnSlot9.Name = "btnSlot9";
            this.btnSlot9.Size = new System.Drawing.Size(125, 39);
            this.btnSlot9.TabIndex = 18;
            this.btnSlot9.Text = "6 pm - 7 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot9, "Choose this Slot Time and go to Booking Form");
            this.btnSlot9.UseVisualStyleBackColor = false;
            this.btnSlot9.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot8
            // 
            this.btnSlot8.BackColor = System.Drawing.Color.Lime;
            this.btnSlot8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot8.Location = new System.Drawing.Point(427, 131);
            this.btnSlot8.Name = "btnSlot8";
            this.btnSlot8.Size = new System.Drawing.Size(123, 39);
            this.btnSlot8.TabIndex = 17;
            this.btnSlot8.Text = "5 pm - 6 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot8, "Choose this Slot Time and go to Booking Form");
            this.btnSlot8.UseVisualStyleBackColor = false;
            this.btnSlot8.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot7
            // 
            this.btnSlot7.BackColor = System.Drawing.Color.Lime;
            this.btnSlot7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot7.Location = new System.Drawing.Point(298, 131);
            this.btnSlot7.Name = "btnSlot7";
            this.btnSlot7.Size = new System.Drawing.Size(123, 39);
            this.btnSlot7.TabIndex = 16;
            this.btnSlot7.Text = "4 pm - 5 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot7, "Choose this Slot Time and go to Booking Form");
            this.btnSlot7.UseVisualStyleBackColor = false;
            this.btnSlot7.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot6
            // 
            this.btnSlot6.BackColor = System.Drawing.Color.Lime;
            this.btnSlot6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot6.Location = new System.Drawing.Point(169, 131);
            this.btnSlot6.Name = "btnSlot6";
            this.btnSlot6.Size = new System.Drawing.Size(123, 39);
            this.btnSlot6.TabIndex = 15;
            this.btnSlot6.Text = "3 pm - 4 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot6, "Choose this Slot Time and go to Booking Form");
            this.btnSlot6.UseVisualStyleBackColor = false;
            this.btnSlot6.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot5
            // 
            this.btnSlot5.BackColor = System.Drawing.Color.Lime;
            this.btnSlot5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot5.Location = new System.Drawing.Point(36, 131);
            this.btnSlot5.Name = "btnSlot5";
            this.btnSlot5.Size = new System.Drawing.Size(125, 39);
            this.btnSlot5.TabIndex = 14;
            this.btnSlot5.Text = "2 pm - 3 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot5, "Choose this Slot Time and go to Booking Form");
            this.btnSlot5.UseVisualStyleBackColor = false;
            this.btnSlot5.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot4
            // 
            this.btnSlot4.BackColor = System.Drawing.Color.Lime;
            this.btnSlot4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot4.Location = new System.Drawing.Point(427, 74);
            this.btnSlot4.Name = "btnSlot4";
            this.btnSlot4.Size = new System.Drawing.Size(123, 39);
            this.btnSlot4.TabIndex = 13;
            this.btnSlot4.Text = "1 pm - 2 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot4, "Choose this Slot Time and go to Booking Form");
            this.btnSlot4.UseVisualStyleBackColor = false;
            this.btnSlot4.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot3
            // 
            this.btnSlot3.BackColor = System.Drawing.Color.Lime;
            this.btnSlot3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot3.Location = new System.Drawing.Point(298, 74);
            this.btnSlot3.Name = "btnSlot3";
            this.btnSlot3.Size = new System.Drawing.Size(123, 39);
            this.btnSlot3.TabIndex = 12;
            this.btnSlot3.Text = "12 nn - 1 pm";
            this.toolTipQueryForm.SetToolTip(this.btnSlot3, "Choose this Slot Time and go to Booking Form");
            this.btnSlot3.UseVisualStyleBackColor = false;
            this.btnSlot3.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot2
            // 
            this.btnSlot2.BackColor = System.Drawing.Color.Lime;
            this.btnSlot2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot2.Location = new System.Drawing.Point(167, 74);
            this.btnSlot2.Name = "btnSlot2";
            this.btnSlot2.Size = new System.Drawing.Size(125, 39);
            this.btnSlot2.TabIndex = 11;
            this.btnSlot2.Text = "11 am - 12 nn";
            this.toolTipQueryForm.SetToolTip(this.btnSlot2, "Choose this Slot Time and go to Booking Form");
            this.btnSlot2.UseVisualStyleBackColor = false;
            this.btnSlot2.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnSlot1
            // 
            this.btnSlot1.BackColor = System.Drawing.Color.Lime;
            this.btnSlot1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSlot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot1.Location = new System.Drawing.Point(34, 74);
            this.btnSlot1.Name = "btnSlot1";
            this.btnSlot1.Size = new System.Drawing.Size(127, 39);
            this.btnSlot1.TabIndex = 10;
            this.btnSlot1.Text = "10 am - 11 am";
            this.toolTipQueryForm.SetToolTip(this.btnSlot1, "Choose this Slot Time and go to Booking Form");
            this.btnSlot1.UseVisualStyleBackColor = false;
            this.btnSlot1.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Info;
            this.welcome.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(68, 18);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(291, 29);
            this.welcome.TabIndex = 12;
            this.welcome.Text = "Search Facility Availability:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(168, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQueryStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 25);
            this.statusStrip1.TabIndex = 16;
            // 
            // tsQueryStatus
            // 
            this.tsQueryStatus.Name = "tsQueryStatus";
            this.tsQueryStatus.Size = new System.Drawing.Size(503, 20);
            this.tsQueryStatus.Text = "Note: Booking Slots are only available from tomorrow for the next 2 weeks";
            // 
            // errorProviderQueryForm
            // 
            this.errorProviderQueryForm.ContainerControl = this;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.btnAvailability);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFacility);
            this.Controls.Add(this.cbFacility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTimeSlots);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Availability";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.gbTimeSlots.ResumeLayout(false);
            this.gbTimeSlots.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderQueryForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFacility;
        private System.Windows.Forms.TextBox tbFacility;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.GroupBox gbTimeSlots;
        private System.Windows.Forms.Button btnSlot12;
        private System.Windows.Forms.Button btnSlot11;
        private System.Windows.Forms.Button btnSlot10;
        private System.Windows.Forms.Button btnSlot9;
        private System.Windows.Forms.Button btnSlot8;
        private System.Windows.Forms.Button btnSlot7;
        private System.Windows.Forms.Button btnSlot6;
        private System.Windows.Forms.Button btnSlot5;
        private System.Windows.Forms.Button btnSlot4;
        private System.Windows.Forms.Button btnSlot3;
        private System.Windows.Forms.Button btnSlot2;
        private System.Windows.Forms.Button btnSlot1;
        private System.Windows.Forms.Label labelExample2;
        private System.Windows.Forms.Label labelExample1;
        private System.Windows.Forms.Button btnExample2;
        private System.Windows.Forms.Button btnExample1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelFacility;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsQueryStatus;
        private System.Windows.Forms.ErrorProvider errorProviderQueryForm;
        private System.Windows.Forms.ToolTip toolTipQueryForm;
    }
}