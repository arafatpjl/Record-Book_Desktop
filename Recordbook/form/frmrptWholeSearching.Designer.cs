namespace Recordbook.form
{
    partial class frmrptWholeSearching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrptWholeSearching));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.label6 = new System.Windows.Forms.Label();
            this.cboFileName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optMcode = new System.Windows.Forms.RadioButton();
            this.optBuyerName = new System.Windows.Forms.RadioButton();
            this.OptTrans = new System.Windows.Forms.RadioButton();
            this.OptFileName = new System.Windows.Forms.RadioButton();
            this.optdept = new System.Windows.Forms.RadioButton();
            this.OptShelfNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtshelfNo = new System.Windows.Forms.TextBox();
            this.OptLeft = new System.Windows.Forms.RadioButton();
            this.OptRight = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTransaction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBuyerName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFileNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMcode = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "File Name  :";
            // 
            // cboFileName
            // 
            this.cboFileName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFileName.FormattingEnabled = true;
            this.cboFileName.IntegralHeight = false;
            this.cboFileName.Location = new System.Drawing.Point(330, 126);
            this.cboFileName.Name = "cboFileName";
            this.cboFileName.Size = new System.Drawing.Size(189, 21);
            this.cboFileName.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(829, 43);
            this.label2.TabIndex = 68;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-2, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 53);
            this.label1.TabIndex = 67;
            this.label1.Text = "New File Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "Cabinet No  :";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(4, 225);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(823, 195);
            this.listView1.TabIndex = 78;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.optMcode);
            this.groupBox1.Controls.Add(this.optBuyerName);
            this.groupBox1.Controls.Add(this.OptTrans);
            this.groupBox1.Controls.Add(this.OptFileName);
            this.groupBox1.Controls.Add(this.optdept);
            this.groupBox1.Controls.Add(this.OptShelfNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 59);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // optMcode
            // 
            this.optMcode.AutoSize = true;
            this.optMcode.Location = new System.Drawing.Point(682, 26);
            this.optMcode.Name = "optMcode";
            this.optMcode.Size = new System.Drawing.Size(101, 17);
            this.optMcode.TabIndex = 5;
            this.optMcode.TabStop = true;
            this.optMcode.Text = "Maintainer ID";
            this.optMcode.UseVisualStyleBackColor = true;
            this.optMcode.Click += new System.EventHandler(this.optMcode_Click);
            // 
            // optBuyerName
            // 
            this.optBuyerName.AutoSize = true;
            this.optBuyerName.Location = new System.Drawing.Point(549, 26);
            this.optBuyerName.Name = "optBuyerName";
            this.optBuyerName.Size = new System.Drawing.Size(93, 17);
            this.optBuyerName.TabIndex = 4;
            this.optBuyerName.TabStop = true;
            this.optBuyerName.Text = "Buyer Name";
            this.optBuyerName.UseVisualStyleBackColor = true;
            this.optBuyerName.Click += new System.EventHandler(this.optBuyerName_Click);
            // 
            // OptTrans
            // 
            this.OptTrans.AutoSize = true;
            this.OptTrans.Location = new System.Drawing.Point(393, 26);
            this.OptTrans.Name = "OptTrans";
            this.OptTrans.Size = new System.Drawing.Size(112, 17);
            this.OptTrans.TabIndex = 3;
            this.OptTrans.TabStop = true;
            this.OptTrans.Text = "Transaction No";
            this.OptTrans.UseVisualStyleBackColor = true;
            this.OptTrans.Click += new System.EventHandler(this.OptTrans_Click);
            // 
            // OptFileName
            // 
            this.OptFileName.AutoSize = true;
            this.OptFileName.Location = new System.Drawing.Point(269, 26);
            this.OptFileName.Name = "OptFileName";
            this.OptFileName.Size = new System.Drawing.Size(81, 17);
            this.OptFileName.TabIndex = 2;
            this.OptFileName.TabStop = true;
            this.OptFileName.Text = "File Name";
            this.OptFileName.UseVisualStyleBackColor = true;
            this.OptFileName.Click += new System.EventHandler(this.OptFileName_Click);
            // 
            // optdept
            // 
            this.optdept.AutoSize = true;
            this.optdept.Location = new System.Drawing.Point(147, 26);
            this.optdept.Name = "optdept";
            this.optdept.Size = new System.Drawing.Size(90, 17);
            this.optdept.TabIndex = 1;
            this.optdept.TabStop = true;
            this.optdept.Text = "Department";
            this.optdept.UseVisualStyleBackColor = true;
            this.optdept.Click += new System.EventHandler(this.optdept_Click);
            // 
            // OptShelfNo
            // 
            this.OptShelfNo.AutoSize = true;
            this.OptShelfNo.Location = new System.Drawing.Point(17, 26);
            this.OptShelfNo.Name = "OptShelfNo";
            this.OptShelfNo.Size = new System.Drawing.Size(88, 17);
            this.OptShelfNo.TabIndex = 0;
            this.OptShelfNo.TabStop = true;
            this.OptShelfNo.Text = "Cabinet No";
            this.OptShelfNo.UseVisualStyleBackColor = true;
            this.OptShelfNo.Click += new System.EventHandler(this.OptShelfNo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtshelfNo);
            this.groupBox2.Controls.Add(this.OptLeft);
            this.groupBox2.Controls.Add(this.OptRight);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 64);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cabinet";
            // 
            // txtshelfNo
            // 
            this.txtshelfNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtshelfNo.Location = new System.Drawing.Point(83, 20);
            this.txtshelfNo.Multiline = true;
            this.txtshelfNo.Name = "txtshelfNo";
            this.txtshelfNo.Size = new System.Drawing.Size(69, 25);
            this.txtshelfNo.TabIndex = 83;
            // 
            // OptLeft
            // 
            this.OptLeft.AutoSize = true;
            this.OptLeft.Location = new System.Drawing.Point(158, 13);
            this.OptLeft.Name = "OptLeft";
            this.OptLeft.Size = new System.Drawing.Size(76, 17);
            this.OptLeft.TabIndex = 1;
            this.OptLeft.TabStop = true;
            this.OptLeft.Text = "Left Side";
            this.OptLeft.UseVisualStyleBackColor = true;
            // 
            // OptRight
            // 
            this.OptRight.AutoSize = true;
            this.OptRight.Location = new System.Drawing.Point(158, 37);
            this.OptRight.Name = "OptRight";
            this.OptRight.Size = new System.Drawing.Size(84, 17);
            this.OptRight.TabIndex = 0;
            this.OptRight.TabStop = true;
            this.OptRight.Text = "Right Side";
            this.OptRight.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Department  :";
            // 
            // cboTransaction
            // 
            this.cboTransaction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTransaction.FormattingEnabled = true;
            this.cboTransaction.IntegralHeight = false;
            this.cboTransaction.Location = new System.Drawing.Point(638, 125);
            this.cboTransaction.Name = "cboTransaction";
            this.cboTransaction.Size = new System.Drawing.Size(189, 21);
            this.cboTransaction.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "Transaction No  :";
            // 
            // cboDept
            // 
            this.cboDept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDept.FormattingEnabled = true;
            this.cboDept.IntegralHeight = false;
            this.cboDept.Location = new System.Drawing.Point(336, 157);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(189, 21);
            this.cboDept.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 86;
            this.label7.Text = "Buyer Name  :";
            // 
            // cboBuyerName
            // 
            this.cboBuyerName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBuyerName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuyerName.FormattingEnabled = true;
            this.cboBuyerName.IntegralHeight = false;
            this.cboBuyerName.ItemHeight = 13;
            this.cboBuyerName.Location = new System.Drawing.Point(638, 152);
            this.cboBuyerName.Name = "cboBuyerName";
            this.cboBuyerName.Size = new System.Drawing.Size(189, 21);
            this.cboBuyerName.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 89;
            this.label8.Text = "File No  :";
            // 
            // txtFileNo
            // 
            this.txtFileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNo.Location = new System.Drawing.Point(70, 188);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.Size = new System.Drawing.Size(167, 20);
            this.txtFileNo.TabIndex = 90;
            this.txtFileNo.TextChanged += new System.EventHandler(this.txtFileNo_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 91;
            this.label9.Text = "Maintainer ID  :";
            // 
            // txtMcode
            // 
            this.txtMcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMcode.Location = new System.Drawing.Point(351, 189);
            this.txtMcode.Name = "txtMcode";
            this.txtMcode.Size = new System.Drawing.Size(104, 20);
            this.txtMcode.TabIndex = 92;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(544, 195);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(65, 24);
            this.btnshow.TabIndex = 94;
            this.btnshow.Text = "Search";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(715, 431);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 30);
            this.btnclose.TabIndex = 185;
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
            this.btnpreview.Location = new System.Drawing.Point(596, 431);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 30);
            this.btnpreview.TabIndex = 184;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // frmrptWholeSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtMcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFileNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboBuyerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboDept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmrptWholeSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmrptWholeSearching_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMcode;
        private System.Windows.Forms.RadioButton optBuyerName;
        private System.Windows.Forms.RadioButton OptTrans;
        private System.Windows.Forms.RadioButton OptFileName;
        private System.Windows.Forms.RadioButton optdept;
        private System.Windows.Forms.RadioButton OptShelfNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtshelfNo;
        private System.Windows.Forms.RadioButton OptLeft;
        private System.Windows.Forms.RadioButton OptRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBuyerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFileNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMcode;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnpreview;
    }
}