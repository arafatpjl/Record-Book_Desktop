namespace Recordbook.form
{
    partial class frmRptRecordDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptRecordDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShelfNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OptLeft = new System.Windows.Forms.RadioButton();
            this.OptRight = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optdept = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optShelfNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "Report : Record Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-1, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 46);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cabinet  No   :";
            // 
            // txtShelfNo
            // 
            this.txtShelfNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfNo.Location = new System.Drawing.Point(240, 54);
            this.txtShelfNo.Multiline = true;
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(80, 43);
            this.txtShelfNo.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cabinet\'s Side  :";
            // 
            // OptLeft
            // 
            this.OptLeft.AutoSize = true;
            this.OptLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptLeft.Location = new System.Drawing.Point(23, 54);
            this.OptLeft.Name = "OptLeft";
            this.OptLeft.Size = new System.Drawing.Size(47, 17);
            this.OptLeft.TabIndex = 44;
            this.OptLeft.TabStop = true;
            this.OptLeft.Text = "Left";
            this.OptLeft.UseVisualStyleBackColor = true;
            // 
            // OptRight
            // 
            this.OptRight.AutoSize = true;
            this.OptRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptRight.Location = new System.Drawing.Point(95, 54);
            this.OptRight.Name = "OptRight";
            this.OptRight.Size = new System.Drawing.Size(55, 17);
            this.OptRight.TabIndex = 45;
            this.OptRight.TabStop = true;
            this.OptRight.Text = "Right";
            this.OptRight.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.optdept);
            this.groupBox1.Controls.Add(this.optAll);
            this.groupBox1.Controls.Add(this.optShelfNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 53);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criteria";
            // 
            // optdept
            // 
            this.optdept.AutoSize = true;
            this.optdept.Location = new System.Drawing.Point(267, 19);
            this.optdept.Name = "optdept";
            this.optdept.Size = new System.Drawing.Size(90, 17);
            this.optdept.TabIndex = 2;
            this.optdept.Text = "Department";
            this.optdept.UseVisualStyleBackColor = true;
            this.optdept.Click += new System.EventHandler(this.optdept_Click);
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAll.Location = new System.Drawing.Point(176, 19);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(39, 17);
            this.optAll.TabIndex = 1;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.Click += new System.EventHandler(this.optAll_Click);
            // 
            // optShelfNo
            // 
            this.optShelfNo.AutoSize = true;
            this.optShelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optShelfNo.Location = new System.Drawing.Point(30, 19);
            this.optShelfNo.Name = "optShelfNo";
            this.optShelfNo.Size = new System.Drawing.Size(120, 17);
            this.optShelfNo.TabIndex = 0;
            this.optShelfNo.Text = "Cabinet No Wise";
            this.optShelfNo.UseVisualStyleBackColor = true;
            this.optShelfNo.Click += new System.EventHandler(this.optShelfNo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbdept);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.OptLeft);
            this.groupBox2.Controls.Add(this.OptRight);
            this.groupBox2.Controls.Add(this.txtShelfNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 163);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cabinet";
            // 
            // cmbdept
            // 
            this.cmbdept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(130, 113);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(205, 21);
            this.cmbdept.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Department  :";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(341, 334);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(82, 30);
            this.btnclose.TabIndex = 181;
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
            this.btnpreview.Location = new System.Drawing.Point(224, 335);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(91, 30);
            this.btnpreview.TabIndex = 180;
            this.btnpreview.Text = "&Preview";
            this.btnpreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // frmRptRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(456, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRptRecordDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNewPosition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShelfNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton OptLeft;
        private System.Windows.Forms.RadioButton OptRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.RadioButton optShelfNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optdept;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button btnpreview;
    }
}