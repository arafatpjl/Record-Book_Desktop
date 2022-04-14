namespace Recordbook.form
{
    partial class frmTransactionReturn
    {
        /// <summary>
        /// Required designer variable.frmTransactionReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionReturn));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvfileEntry = new System.Windows.Forms.DataGridView();
            this.File_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTransactionID = new System.Windows.Forms.ComboBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfileEntry)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 32;
            // 
            // dgvfileEntry
            // 
            this.dgvfileEntry.AllowUserToAddRows = false;
            this.dgvfileEntry.AllowUserToDeleteRows = false;
            this.dgvfileEntry.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvfileEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfileEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File_Name,
            this.File_No,
            this.FileType,
            this.VolumeNo,
            this.File_Location,
            this.SendDate,
            this.ReturnDate,
            this.SendTime,
            this.ReturnTime});
            this.dgvfileEntry.GridColor = System.Drawing.SystemColors.Info;
            this.dgvfileEntry.Location = new System.Drawing.Point(1, 107);
            this.dgvfileEntry.Name = "dgvfileEntry";
            this.dgvfileEntry.ReadOnly = true;
            this.dgvfileEntry.Size = new System.Drawing.Size(665, 179);
            this.dgvfileEntry.TabIndex = 28;
            // 
            // File_Name
            // 
            this.File_Name.HeaderText = "File_Name";
            this.File_Name.Name = "File_Name";
            this.File_Name.ReadOnly = true;
            // 
            // File_No
            // 
            this.File_No.HeaderText = "File_No";
            this.File_No.Name = "File_No";
            this.File_No.ReadOnly = true;
            // 
            // FileType
            // 
            this.FileType.HeaderText = "FileType";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            // 
            // VolumeNo
            // 
            this.VolumeNo.HeaderText = "VolumeNo";
            this.VolumeNo.Name = "VolumeNo";
            this.VolumeNo.ReadOnly = true;
            // 
            // File_Location
            // 
            this.File_Location.HeaderText = "File Location";
            this.File_Location.Name = "File_Location";
            this.File_Location.ReadOnly = true;
            // 
            // SendDate
            // 
            this.SendDate.HeaderText = "SendDate";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // SendTime
            // 
            this.SendTime.HeaderText = "SendTime";
            this.SendTime.Name = "SendTime";
            this.SendTime.ReadOnly = true;
            // 
            // ReturnTime
            // 
            this.ReturnTime.HeaderText = "ReturnTime";
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.ReadOnly = true;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(-2, -4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(668, 54);
            this.label24.TabIndex = 53;
            this.label24.Text = "File Return Transaction ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(-1, 289);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(668, 56);
            this.label25.TabIndex = 54;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Close.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Close.Location = new System.Drawing.Point(773, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 38);
            this.Close.TabIndex = 64;
            this.Close.Text = "x";
            this.Close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(404, 14);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(65, 24);
            this.btnshow.TabIndex = 48;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.cboTransactionID);
            this.groupBox3.Controls.Add(this.txtTransID);
            this.groupBox3.Controls.Add(this.btnshow);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 52);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Id";
            // 
            // cboTransactionID
            // 
            this.cboTransactionID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionID.FormattingEnabled = true;
            this.cboTransactionID.ItemHeight = 13;
            this.cboTransactionID.Location = new System.Drawing.Point(180, 17);
            this.cboTransactionID.Name = "cboTransactionID";
            this.cboTransactionID.Size = new System.Drawing.Size(200, 21);
            this.cboTransactionID.TabIndex = 40;
            this.cboTransactionID.SelectedIndexChanged += new System.EventHandler(this.cboTransactionID_SelectedIndexChanged);
            // 
            // txtTransID
            // 
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransID.Location = new System.Drawing.Point(201, 17);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(158, 21);
            this.txtTransID.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "Transaction Id     :";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(537, 302);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 31);
            this.btnclose.TabIndex = 183;
            this.btnclose.Text = "   &Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnpreview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpreview.Image = ((System.Drawing.Image)(resources.GetObject("btnpreview.Image")));
            this.btnpreview.Location = new System.Drawing.Point(305, 304);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 30);
            this.btnpreview.TabIndex = 182;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(423, 303);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 31);
            this.btnsave.TabIndex = 184;
            this.btnsave.Text = " &Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmTransactionReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(664, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgvfileEntry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTransactionReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTransactionReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfileEntry)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfileEntry;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboTransactionID;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTime;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnpreview;
        internal System.Windows.Forms.Button btnsave;
    }
}