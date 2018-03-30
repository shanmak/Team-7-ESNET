namespace Team7B_ESNET
{
    partial class MemberLookup
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
            this.tbFindName = new System.Windows.Forms.TextBox();
            this.gvMember = new System.Windows.Forms.DataGridView();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
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
            // tbFindName
            // 
            this.tbFindName.Location = new System.Drawing.Point(194, 48);
            this.tbFindName.Name = "tbFindName";
            this.tbFindName.Size = new System.Drawing.Size(247, 27);
            this.tbFindName.TabIndex = 7;
            this.tbFindName.TextChanged += new System.EventHandler(this.tbFindName_TextChanged_1);
            // 
            // gvMember
            // 
            this.gvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMember.Location = new System.Drawing.Point(60, 94);
            this.gvMember.Name = "gvMember";
            this.gvMember.RowTemplate.Height = 24;
            this.gvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMember.Size = new System.Drawing.Size(559, 240);
            this.gvMember.TabIndex = 8;
            this.gvMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMember_CellDoubleClick);
            // 
            // btnFindMember
            // 
            this.btnFindMember.Location = new System.Drawing.Point(464, 48);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(155, 27);
            this.btnFindMember.TabIndex = 9;
            this.btnFindMember.Text = "Find Member";
            this.btnFindMember.UseVisualStyleBackColor = true;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(515, 363);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(60, 363);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 35);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MemberLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFindMember);
            this.Controls.Add(this.gvMember);
            this.Controls.Add(this.tbFindName);
            this.Controls.Add(this.labelMemberName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Members";
            this.Load += new System.EventHandler(this.MemberLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox tbFindName;
        private System.Windows.Forms.DataGridView gvMember;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
    }
}