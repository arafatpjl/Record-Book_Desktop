namespace Recordbook.form
{
    partial class frmRptDateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptDateInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_invoiceinfo = new System.Windows.Forms.DataGridView();
            this.File_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "File Invoice";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-4, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 43);
            this.label2.TabIndex = 17;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "File  No  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgv_invoiceinfo
            // 
            this.dgv_invoiceinfo.AllowUserToAddRows = false;
            this.dgv_invoiceinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_invoiceinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoiceinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File_No});
            this.dgv_invoiceinfo.Location = new System.Drawing.Point(68, 125);
            this.dgv_invoiceinfo.Name = "dgv_invoiceinfo";
            this.dgv_invoiceinfo.ReadOnly = true;
            this.dgv_invoiceinfo.Size = new System.Drawing.Size(363, 223);
            this.dgv_invoiceinfo.TabIndex = 52;
            this.dgv_invoiceinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_volumeinfo_CellClick);
            this.dgv_invoiceinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_volumeinfo_CellContentClick);
            // 
            // File_No
            // 
            this.File_No.HeaderText = "File_No";
            this.File_No.Name = "File_No";
            this.File_No.ReadOnly = true;
            this.File_No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.File_No.Width = 200;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(299, 369);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 31);
            this.btnclose.TabIndex = 178;
            this.btnclose.Text = "   &Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(299, 95);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(65, 24);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnpreview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpreview.Image = ((System.Drawing.Image)(resources.GetObject("btnpreview.Image")));
            this.btnpreview.Location = new System.Drawing.Point(185, 369);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 30);
            this.btnpreview.TabIndex = 180;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilename.Location = new System.Drawing.Point(133, 63);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(231, 20);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilename_KeyDown);
            // 
            // frmRptDateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.ControlBox = false;
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgv_invoiceinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRptDateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RptDateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoiceinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_invoiceinfo;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_No;
        private System.Windows.Forms.TextBox txtFilename;
    }
}