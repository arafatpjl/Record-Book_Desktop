namespace Recordbook.form
{
    partial class frmfileEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfileEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.txtfileno = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtedat = new System.Windows.Forms.TextBox();
            this.txtsdat = new System.Windows.Forms.TextBox();
            this.cmbbuyer = new System.Windows.Forms.ComboBox();
            this.cmbfiletype = new System.Windows.Forms.ComboBox();
            this.cmbvolum = new System.Windows.Forms.ComboBox();
            this.optright = new System.Windows.Forms.RadioButton();
            this.optleft = new System.Windows.Forms.RadioButton();
            this.cmbflocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcabinet = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbdepartment = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsdate = new System.Windows.Forms.TextBox();
            this.dgvItemEntry = new System.Windows.Forms.DataGridView();
            this.File_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deptid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 32;
            // 
            // txtmid
            // 
            this.txtmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmid.Location = new System.Drawing.Point(124, 15);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(69, 20);
            this.txtmid.TabIndex = 14;
            this.txtmid.TextChanged += new System.EventHandler(this.txtmid_TextChanged);
            // 
            // txtfileno
            // 
            this.txtfileno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtfileno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfileno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfileno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtfileno.Location = new System.Drawing.Point(8, 31);
            this.txtfileno.Name = "txtfileno";
            this.txtfileno.Size = new System.Drawing.Size(156, 20);
            this.txtfileno.TabIndex = 16;
            this.txtfileno.TextChanged += new System.EventHandler(this.txtfileno_TextChanged);
            // 
            // txtsection
            // 
            this.txtsection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsection.Location = new System.Drawing.Point(371, 79);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(209, 20);
            this.txtsection.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Maintain By     :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Designation  :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Section   :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Department  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtdesignation);
            this.panel1.Controls.Add(this.txtdepartment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtmid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtsection);
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 113);
            this.panel1.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(189, 15);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 20);
            this.txtname.TabIndex = 29;
            // 
            // txtdesignation
            // 
            this.txtdesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesignation.Location = new System.Drawing.Point(124, 46);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(208, 20);
            this.txtdesignation.TabIndex = 28;
            // 
            // txtdepartment
            // 
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Location = new System.Drawing.Point(124, 79);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(208, 20);
            this.txtdepartment.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.txtedat);
            this.panel2.Controls.Add(this.txtsdat);
            this.panel2.Controls.Add(this.cmbbuyer);
            this.panel2.Controls.Add(this.cmbfiletype);
            this.panel2.Controls.Add(this.cmbvolum);
            this.panel2.Controls.Add(this.optright);
            this.panel2.Controls.Add(this.optleft);
            this.panel2.Controls.Add(this.cmbflocation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbcabinet);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.cmbdepartment);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtfileno);
            this.panel2.Location = new System.Drawing.Point(3, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 137);
            this.panel2.TabIndex = 27;
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Location = new System.Drawing.Point(170, 32);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(149, 20);
            this.txtFileName.TabIndex = 30;
            // 
            // txtedat
            // 
            this.txtedat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtedat.Location = new System.Drawing.Point(658, 82);
            this.txtedat.Name = "txtedat";
            this.txtedat.Size = new System.Drawing.Size(141, 20);
            this.txtedat.TabIndex = 8;
            this.txtedat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtedat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedat_KeyPress);
            this.txtedat.Leave += new System.EventHandler(this.txtedat_Leave);
            // 
            // txtsdat
            // 
            this.txtsdat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsdat.Location = new System.Drawing.Point(526, 83);
            this.txtsdat.Name = "txtsdat";
            this.txtsdat.Size = new System.Drawing.Size(124, 20);
            this.txtsdat.TabIndex = 7;
            this.txtsdat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsdat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdat_KeyPress);
            this.txtsdat.Leave += new System.EventHandler(this.txtsdat_Leave);
            // 
            // cmbbuyer
            // 
            this.cmbbuyer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbbuyer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuyer.FormattingEnabled = true;
            this.cmbbuyer.IntegralHeight = false;
            this.cmbbuyer.Location = new System.Drawing.Point(623, 30);
            this.cmbbuyer.Name = "cmbbuyer";
            this.cmbbuyer.Size = new System.Drawing.Size(176, 21);
            this.cmbbuyer.TabIndex = 3;
            this.cmbbuyer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbuyer_KeyPress);
            // 
            // cmbfiletype
            // 
            this.cmbfiletype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbfiletype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfiletype.FormattingEnabled = true;
            this.cmbfiletype.IntegralHeight = false;
            this.cmbfiletype.Location = new System.Drawing.Point(478, 31);
            this.cmbfiletype.Name = "cmbfiletype";
            this.cmbfiletype.Size = new System.Drawing.Size(129, 21);
            this.cmbfiletype.TabIndex = 2;
            this.cmbfiletype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbfiletype_KeyPress);
            // 
            // cmbvolum
            // 
            this.cmbvolum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbvolum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvolum.FormattingEnabled = true;
            this.cmbvolum.IntegralHeight = false;
            this.cmbvolum.Location = new System.Drawing.Point(338, 30);
            this.cmbvolum.Name = "cmbvolum";
            this.cmbvolum.Size = new System.Drawing.Size(129, 21);
            this.cmbvolum.TabIndex = 1;
            this.cmbvolum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbvolum_KeyPress);
            // 
            // optright
            // 
            this.optright.Location = new System.Drawing.Point(318, 86);
            this.optright.Name = "optright";
            this.optright.Size = new System.Drawing.Size(55, 24);
            this.optright.TabIndex = 54;
            this.optright.Text = "Right";
            this.optright.UseVisualStyleBackColor = true;
            this.optright.CheckedChanged += new System.EventHandler(this.optright_CheckedChanged);
            // 
            // optleft
            // 
            this.optleft.AutoSize = true;
            this.optleft.Location = new System.Drawing.Point(318, 61);
            this.optleft.Name = "optleft";
            this.optleft.Size = new System.Drawing.Size(43, 17);
            this.optleft.TabIndex = 53;
            this.optleft.TabStop = true;
            this.optleft.Text = "Left";
            this.optleft.UseVisualStyleBackColor = true;
            this.optleft.CheckedChanged += new System.EventHandler(this.optleft_CheckedChanged);
            // 
            // cmbflocation
            // 
            this.cmbflocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbflocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbflocation.FormattingEnabled = true;
            this.cmbflocation.IntegralHeight = false;
            this.cmbflocation.Location = new System.Drawing.Point(379, 86);
            this.cmbflocation.Name = "cmbflocation";
            this.cmbflocation.Size = new System.Drawing.Size(141, 21);
            this.cmbflocation.TabIndex = 6;
            this.cmbflocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbflocation_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "File Location :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "File Type :";
            // 
            // cmbcabinet
            // 
            this.cmbcabinet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbcabinet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcabinet.FormattingEnabled = true;
            this.cmbcabinet.IntegralHeight = false;
            this.cmbcabinet.Location = new System.Drawing.Point(199, 86);
            this.cmbcabinet.Name = "cmbcabinet";
            this.cmbcabinet.Size = new System.Drawing.Size(96, 21);
            this.cmbcabinet.TabIndex = 5;
            this.cmbcabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbcabinet_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(721, 108);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 24);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbdepartment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.Location = new System.Drawing.Point(8, 86);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.Size = new System.Drawing.Size(171, 21);
            this.cmbdepartment.TabIndex = 4;
            this.cmbdepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdepartment_KeyPress);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(655, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 16);
            this.label23.TabIndex = 35;
            this.label23.Text = "Buyer Name  :";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 16);
            this.label22.TabIndex = 34;
            this.label22.Text = "Department :";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(351, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Volume No :";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(214, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 24);
            this.label17.TabIndex = 29;
            this.label17.Text = "Cabinet No :";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(549, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Start Date :";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(186, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "File Name  :";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "File No :";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(699, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "End Date  :";
            // 
            // txtsdate
            // 
            this.txtsdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsdate.Location = new System.Drawing.Point(501, 335);
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.Size = new System.Drawing.Size(110, 20);
            this.txtsdate.TabIndex = 38;
            // 
            // dgvItemEntry
            // 
            this.dgvItemEntry.AllowUserToAddRows = false;
            this.dgvItemEntry.AllowUserToDeleteRows = false;
            this.dgvItemEntry.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvItemEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File_Name,
            this.File_No,
            this.FTypeid,
            this.FileType,
            this.Volid,
            this.VolumeNo,
            this.Deptid,
            this.Department,
            this.File_Location,
            this.StartDate,
            this.EndDate,
            this.Byrid,
            this.Column9});
            this.dgvItemEntry.Location = new System.Drawing.Point(3, 306);
            this.dgvItemEntry.Name = "dgvItemEntry";
            this.dgvItemEntry.ReadOnly = true;
            this.dgvItemEntry.Size = new System.Drawing.Size(815, 200);
            this.dgvItemEntry.TabIndex = 28;
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
            // FTypeid
            // 
            this.FTypeid.HeaderText = "FTypeid";
            this.FTypeid.Name = "FTypeid";
            this.FTypeid.ReadOnly = true;
            this.FTypeid.Visible = false;
            // 
            // FileType
            // 
            this.FileType.HeaderText = "FileType";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            // 
            // Volid
            // 
            this.Volid.HeaderText = "Volid";
            this.Volid.Name = "Volid";
            this.Volid.ReadOnly = true;
            this.Volid.Visible = false;
            // 
            // VolumeNo
            // 
            this.VolumeNo.HeaderText = "VolumeNo";
            this.VolumeNo.Name = "VolumeNo";
            this.VolumeNo.ReadOnly = true;
            // 
            // Deptid
            // 
            this.Deptid.HeaderText = "Deptid";
            this.Deptid.Name = "Deptid";
            this.Deptid.ReadOnly = true;
            this.Deptid.Visible = false;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // File_Location
            // 
            this.File_Location.HeaderText = "File Location";
            this.File_Location.Name = "File_Location";
            this.File_Location.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Byrid
            // 
            this.Byrid.HeaderText = "Byrid";
            this.Byrid.Name = "Byrid";
            this.Byrid.ReadOnly = true;
            this.Byrid.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "BuyerName";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(-2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(820, 49);
            this.label24.TabIndex = 53;
            this.label24.Text = "Create new File";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(-1, 512);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(819, 51);
            this.label25.TabIndex = 54;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Control;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(573, 523);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 31);
            this.btndelete.TabIndex = 176;
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
            this.btnnew.Location = new System.Drawing.Point(342, 525);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(82, 29);
            this.btnnew.TabIndex = 175;
            this.btnnew.Text = "&New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnpreview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpreview.Image = ((System.Drawing.Image)(resources.GetObject("btnpreview.Image")));
            this.btnpreview.Location = new System.Drawing.Point(221, 525);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 30);
            this.btnpreview.TabIndex = 177;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(685, 523);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 30);
            this.btnclose.TabIndex = 178;
            this.btnclose.Text = "   &Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.Control;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(455, 523);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 31);
            this.btnsave.TabIndex = 179;
            this.btnsave.Text = "&Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // frmfileEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dgvItemEntry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmfileEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHeadDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.TextBox txtfileno;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsdate;
        private System.Windows.Forms.ComboBox cmbdepartment;
        private System.Windows.Forms.DataGridView dgvItemEntry;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcabinet;
        private System.Windows.Forms.RadioButton optright;
        private System.Windows.Forms.RadioButton optleft;
        private System.Windows.Forms.ComboBox cmbflocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbvolum;
        private System.Windows.Forms.ComboBox cmbfiletype;
        private System.Windows.Forms.ComboBox cmbbuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volid;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deptid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        internal System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnew;
        internal System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtedat;
        private System.Windows.Forms.TextBox txtsdat;
        private System.Windows.Forms.TextBox txtFileName;
    }
}