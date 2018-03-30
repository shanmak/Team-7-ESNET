namespace Team7B_ESNET
{
    partial class MemberInfo
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
            this.Create = new System.Windows.Forms.Button();
            this.MemberID_Lable = new System.Windows.Forms.Label();
            this.MemberName_Label = new System.Windows.Forms.Label();
            this.Address_Lable = new System.Windows.Forms.Label();
            this.MemberPhone_Lable = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbGenderMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(131, 394);
            this.Create.Margin = new System.Windows.Forms.Padding(4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(131, 34);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // MemberID_Lable
            // 
            this.MemberID_Lable.AutoSize = true;
            this.MemberID_Lable.BackColor = System.Drawing.SystemColors.Menu;
            this.MemberID_Lable.Location = new System.Drawing.Point(81, 105);
            this.MemberID_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberID_Lable.Name = "MemberID_Lable";
            this.MemberID_Lable.Size = new System.Drawing.Size(76, 17);
            this.MemberID_Lable.TabIndex = 2;
            this.MemberID_Lable.Text = "Member ID";
            // 
            // MemberName_Label
            // 
            this.MemberName_Label.AutoSize = true;
            this.MemberName_Label.Location = new System.Drawing.Point(81, 161);
            this.MemberName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberName_Label.Name = "MemberName_Label";
            this.MemberName_Label.Size = new System.Drawing.Size(100, 17);
            this.MemberName_Label.TabIndex = 3;
            this.MemberName_Label.Text = "Member Name";
            // 
            // Address_Lable
            // 
            this.Address_Lable.AutoSize = true;
            this.Address_Lable.Location = new System.Drawing.Point(81, 254);
            this.Address_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address_Lable.Name = "Address_Lable";
            this.Address_Lable.Size = new System.Drawing.Size(60, 17);
            this.Address_Lable.TabIndex = 4;
            this.Address_Lable.Text = "Address";
            // 
            // MemberPhone_Lable
            // 
            this.MemberPhone_Lable.AutoSize = true;
            this.MemberPhone_Lable.Location = new System.Drawing.Point(81, 344);
            this.MemberPhone_Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberPhone_Lable.Name = "MemberPhone_Lable";
            this.MemberPhone_Lable.Size = new System.Drawing.Size(104, 17);
            this.MemberPhone_Lable.TabIndex = 5;
            this.MemberPhone_Lable.Text = "Member Phone";
            // 
            // ID_textBox
            // 
            this.ID_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ID_textBox.Location = new System.Drawing.Point(241, 95);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(140, 23);
            this.ID_textBox.TabIndex = 6;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Phone_textBox.Location = new System.Drawing.Point(241, 341);
            this.Phone_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(249, 23);
            this.Phone_textBox.TabIndex = 7;
            // 
            // Address_textBox
            // 
            this.Address_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Address_textBox.Location = new System.Drawing.Point(241, 247);
            this.Address_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Address_textBox.Multiline = true;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(249, 78);
            this.Address_textBox.TabIndex = 8;
            // 
            // Name_textBox
            // 
            this.Name_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Name_textBox.Location = new System.Drawing.Point(241, 150);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(249, 23);
            this.Name_textBox.TabIndex = 9;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(304, 394);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(131, 34);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Info;
            this.welcome.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(64, 36);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(347, 24);
            this.welcome.TabIndex = 11;
            this.welcome.Text = "Welcome to Member Infomation System !";
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(390, 93);
            this.Find.Margin = new System.Windows.Forms.Padding(4);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 31);
            this.Find.TabIndex = 13;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(81, 202);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 17);
            this.labelGender.TabIndex = 14;
            this.labelGender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGenderFemale);
            this.groupBox1.Controls.Add(this.rbGenderMale);
            this.groupBox1.Location = new System.Drawing.Point(241, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 45);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.AutoSize = true;
            this.rbGenderFemale.Location = new System.Drawing.Point(131, 15);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(72, 21);
            this.rbGenderFemale.TabIndex = 1;
            this.rbGenderFemale.Text = "Female";
            this.rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.AutoSize = true;
            this.rbGenderMale.Checked = true;
            this.rbGenderMale.Location = new System.Drawing.Point(25, 15);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(56, 21);
            this.rbGenderMale.TabIndex = 0;
            this.rbGenderMale.TabStop = true;
            this.rbGenderMale.Text = "Male";
            this.rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 439);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(593, 22);
            this.status.TabIndex = 17;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 461);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.MemberPhone_Lable);
            this.Controls.Add(this.Address_Lable);
            this.Controls.Add(this.MemberName_Label);
            this.Controls.Add(this.MemberID_Lable);
            this.Controls.Add(this.Create);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberInfo";
            this.Text = "Member Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label MemberID_Lable;
        private System.Windows.Forms.Label MemberName_Label;
        private System.Windows.Forms.Label Address_Lable;
        private System.Windows.Forms.Label MemberPhone_Lable;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGenderFemale;
        private System.Windows.Forms.RadioButton rbGenderMale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

