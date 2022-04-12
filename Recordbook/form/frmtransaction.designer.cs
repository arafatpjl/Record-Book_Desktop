namespace Recordbook.form
{
    partial class frmtransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtransaction));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtSendDate = new System.Windows.Forms.TextBox();
            this.txtSendTime = new System.Windows.Forms.DateTimePicker();
            this.txtReturnTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtShelfPosition = new System.Windows.Forms.TextBox();
            this.txtFileNo = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtVolNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.Carrier = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarrierSec = new System.Windows.Forms.TextBox();
            this.txtCarrierId = new System.Windows.Forms.TextBox();
            this.txtCarrierName = new System.Windows.Forms.TextBox();
            this.txtCarrierrDeg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarrierDept = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceiverSec = new System.Windows.Forms.TextBox();
            this.txtReceiverId = new System.Windows.Forms.TextBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.txtReceiverDeg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReceiverDept = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboTransactionID = new System.Windows.Forms.ComboBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfileEntry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Carrier.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.dgvfileEntry.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvfileEntry.Location = new System.Drawing.Point(2, 466);
            this.dgvfileEntry.Name = "dgvfileEntry";
            this.dgvfileEntry.ReadOnly = true;
            this.dgvfileEntry.Size = new System.Drawing.Size(588, 176);
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
            this.label24.Location = new System.Drawing.Point(-1, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(601, 46);
            this.label24.TabIndex = 53;
            this.label24.Text = "File Transaction";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(-1, 643);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(601, 47);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtReturnDate);
            this.groupBox1.Controls.Add(this.txtSendDate);
            this.groupBox1.Controls.Add(this.txtSendTime);
            this.groupBox1.Controls.Add(this.txtReturnTime);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(293, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 151);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Period";
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReturnDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnDate.Location = new System.Drawing.Point(110, 80);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(168, 21);
            this.txtReturnDate.TabIndex = 5;
            this.txtReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReturnDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnDate_KeyPress);
            this.txtReturnDate.Leave += new System.EventHandler(this.txtReturnDate_Leave);
            // 
            // txtSendDate
            // 
            this.txtSendDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendDate.Location = new System.Drawing.Point(109, 17);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.Size = new System.Drawing.Size(169, 21);
            this.txtSendDate.TabIndex = 3;
            this.txtSendDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSendDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendDate_KeyPress);
            this.txtSendDate.Leave += new System.EventHandler(this.txtSendDate_Leave);
            // 
            // txtSendTime
            // 
            this.txtSendTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtSendTime.Location = new System.Drawing.Point(108, 48);
            this.txtSendTime.Name = "txtSendTime";
            this.txtSendTime.Size = new System.Drawing.Size(170, 21);
            this.txtSendTime.TabIndex = 4;
            this.txtSendTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendTime_KeyPress);
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtReturnTime.Location = new System.Drawing.Point(108, 107);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.Size = new System.Drawing.Size(170, 21);
            this.txtReturnTime.TabIndex = 6;
            this.txtReturnTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReturnTime_KeyPress);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "Send  Date     :";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 36;
            this.label14.Text = "Return Date    :";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "Return Time   :";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 25);
            this.label16.TabIndex = 34;
            this.label16.Text = "Send Time    :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtBuyerName);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtShelfPosition);
            this.groupBox2.Controls.Add(this.txtFileNo);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.txtVolNo);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtFileType);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 184);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Info";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 22);
            this.label22.TabIndex = 43;
            this.label22.Text = "Buyer  Name   :";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuyerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyerName.Location = new System.Drawing.Point(109, 156);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(170, 21);
            this.txtBuyerName.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 25);
            this.label17.TabIndex = 41;
            this.label17.Text = "File Location   :";
            // 
            // txtShelfPosition
            // 
            this.txtShelfPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfPosition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShelfPosition.Location = new System.Drawing.Point(109, 129);
            this.txtShelfPosition.Name = "txtShelfPosition";
            this.txtShelfPosition.Size = new System.Drawing.Size(170, 21);
            this.txtShelfPosition.TabIndex = 40;
            // 
            // txtFileNo
            // 
            this.txtFileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileNo.Location = new System.Drawing.Point(110, 16);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.Size = new System.Drawing.Size(169, 21);
            this.txtFileNo.TabIndex = 2;
            this.txtFileNo.TextChanged += new System.EventHandler(this.txtFileNo_TextChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(110, 44);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(169, 21);
            this.txtFileName.TabIndex = 38;
            // 
            // txtVolNo
            // 
            this.txtVolNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolNo.Location = new System.Drawing.Point(110, 74);
            this.txtVolNo.Name = "txtVolNo";
            this.txtVolNo.Size = new System.Drawing.Size(169, 21);
            this.txtVolNo.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 25);
            this.label18.TabIndex = 33;
            this.label18.Text = "File No            :";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 36;
            this.label19.Text = "File Type          :";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 25);
            this.label20.TabIndex = 35;
            this.label20.Text = "Volume No       :";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 25);
            this.label21.TabIndex = 34;
            this.label21.Text = "File Name         :";
            // 
            // txtFileType
            // 
            this.txtFileType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileType.Location = new System.Drawing.Point(109, 101);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(170, 21);
            this.txtFileType.TabIndex = 32;
            // 
            // Carrier
            // 
            this.Carrier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Carrier.Controls.Add(this.label2);
            this.Carrier.Controls.Add(this.txtCarrierSec);
            this.Carrier.Controls.Add(this.txtCarrierId);
            this.Carrier.Controls.Add(this.txtCarrierName);
            this.Carrier.Controls.Add(this.txtCarrierrDeg);
            this.Carrier.Controls.Add(this.label3);
            this.Carrier.Controls.Add(this.label4);
            this.Carrier.Controls.Add(this.label5);
            this.Carrier.Controls.Add(this.label6);
            this.Carrier.Controls.Add(this.txtCarrierDept);
            this.Carrier.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carrier.Location = new System.Drawing.Point(3, 111);
            this.Carrier.Name = "Carrier";
            this.Carrier.Size = new System.Drawing.Size(290, 163);
            this.Carrier.TabIndex = 74;
            this.Carrier.TabStop = false;
            this.Carrier.Text = "Carrier\'s Info";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Section   :";
            // 
            // txtCarrierSec
            // 
            this.txtCarrierSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrierSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrierSec.Location = new System.Drawing.Point(109, 131);
            this.txtCarrierSec.Name = "txtCarrierSec";
            this.txtCarrierSec.Size = new System.Drawing.Size(170, 21);
            this.txtCarrierSec.TabIndex = 40;
            // 
            // txtCarrierId
            // 
            this.txtCarrierId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCarrierId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrierId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrierId.Location = new System.Drawing.Point(110, 16);
            this.txtCarrierId.Name = "txtCarrierId";
            this.txtCarrierId.Size = new System.Drawing.Size(169, 21);
            this.txtCarrierId.TabIndex = 0;
            this.txtCarrierId.TextChanged += new System.EventHandler(this.txtCarrierId_TextChanged);
            // 
            // txtCarrierName
            // 
            this.txtCarrierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrierName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrierName.Location = new System.Drawing.Point(110, 46);
            this.txtCarrierName.Name = "txtCarrierName";
            this.txtCarrierName.Size = new System.Drawing.Size(169, 21);
            this.txtCarrierName.TabIndex = 38;
            // 
            // txtCarrierrDeg
            // 
            this.txtCarrierrDeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrierrDeg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrierrDeg.Location = new System.Drawing.Point(110, 76);
            this.txtCarrierrDeg.Name = "txtCarrierrDeg";
            this.txtCarrierrDeg.Size = new System.Drawing.Size(169, 21);
            this.txtCarrierrDeg.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Carrier ID     :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Department    :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Designation   :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Name    :";
            // 
            // txtCarrierDept
            // 
            this.txtCarrierDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarrierDept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrierDept.Location = new System.Drawing.Point(109, 101);
            this.txtCarrierDept.Name = "txtCarrierDept";
            this.txtCarrierDept.Size = new System.Drawing.Size(170, 21);
            this.txtCarrierDept.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtReceiverSec);
            this.groupBox4.Controls.Add(this.txtReceiverId);
            this.groupBox4.Controls.Add(this.txtReceiverName);
            this.groupBox4.Controls.Add(this.txtReceiverDeg);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtReceiverDept);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(293, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 160);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receiver\'s Info";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Section   :";
            // 
            // txtReceiverSec
            // 
            this.txtReceiverSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverSec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverSec.Location = new System.Drawing.Point(109, 131);
            this.txtReceiverSec.Name = "txtReceiverSec";
            this.txtReceiverSec.Size = new System.Drawing.Size(170, 21);
            this.txtReceiverSec.TabIndex = 40;
            // 
            // txtReceiverId
            // 
            this.txtReceiverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverId.Location = new System.Drawing.Point(110, 16);
            this.txtReceiverId.Name = "txtReceiverId";
            this.txtReceiverId.Size = new System.Drawing.Size(169, 21);
            this.txtReceiverId.TabIndex = 1;
            this.txtReceiverId.TextChanged += new System.EventHandler(this.txtReceiverId_TextChanged);
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverName.Location = new System.Drawing.Point(110, 46);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(169, 21);
            this.txtReceiverName.TabIndex = 38;
            // 
            // txtReceiverDeg
            // 
            this.txtReceiverDeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverDeg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverDeg.Location = new System.Drawing.Point(110, 76);
            this.txtReceiverDeg.Name = "txtReceiverDeg";
            this.txtReceiverDeg.Size = new System.Drawing.Size(169, 21);
            this.txtReceiverDeg.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Receiver ID     :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Department    :";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "Name            :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Designation    :";
            // 
            // txtReceiverDept
            // 
            this.txtReceiverDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiverDept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverDept.Location = new System.Drawing.Point(109, 102);
            this.txtReceiverDept.Name = "txtReceiverDept";
            this.txtReceiverDept.Size = new System.Drawing.Size(170, 21);
            this.txtReceiverDept.TabIndex = 32;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(490, 435);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 24);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.cboTransactionID);
            this.groupBox3.Controls.Add(this.txtTransID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 52);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Period";
            // 
            // cboTransactionID
            // 
            this.cboTransactionID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransactionID.FormattingEnabled = true;
            this.cboTransactionID.Location = new System.Drawing.Point(180, 17);
            this.cboTransactionID.Name = "cboTransactionID";
            this.cboTransactionID.Size = new System.Drawing.Size(200, 21);
            this.cboTransactionID.TabIndex = 40;
            this.cboTransactionID.SelectedIndexChanged += new System.EventHandler(this.cboTransactionID_SelectedIndexChanged);
            this.cboTransactionID.Click += new System.EventHandler(this.cboTransactionID_SelectedIndexChanged);
            // 
            // txtTransID
            // 
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransID.Location = new System.Drawing.Point(201, 17);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(158, 21);
            this.txtTransID.TabIndex = 39;
            this.txtTransID.TextChanged += new System.EventHandler(this.txtTransID_TextChanged);
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
            this.btnclose.Location = new System.Drawing.Point(486, 655);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 28);
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
            this.btnpreview.Location = new System.Drawing.Point(51, 655);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 28);
            this.btnpreview.TabIndex = 182;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Control;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(384, 655);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 28);
            this.btndelete.TabIndex = 181;
            this.btndelete.Text = "&Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(166, 655);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(82, 29);
            this.btnnew.TabIndex = 180;
            this.btnnew.Text = "&New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(270, 655);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 29);
            this.btnsave.TabIndex = 179;
            this.btnsave.Text = "&Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmtransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(592, 690);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Carrier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgvfileEntry);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmtransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmtransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfileEntry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Carrier.ResumeLayout(false);
            this.Carrier.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtShelfPosition;
        private System.Windows.Forms.TextBox txtFileNo;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtVolNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.GroupBox Carrier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarrierSec;
        private System.Windows.Forms.TextBox txtCarrierId;
        private System.Windows.Forms.TextBox txtCarrierName;
        private System.Windows.Forms.TextBox txtCarrierrDeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarrierDept;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReceiverSec;
        private System.Windows.Forms.TextBox txtReceiverId;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.TextBox txtReceiverDeg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReceiverDept;
        private System.Windows.Forms.Button btnadd;
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
        private System.Windows.Forms.DateTimePicker txtSendTime;
        private System.Windows.Forms.DateTimePicker txtReturnTime;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnpreview;
        internal System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtSendDate;
    }
}