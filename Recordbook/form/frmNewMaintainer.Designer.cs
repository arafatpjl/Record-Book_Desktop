namespace Recordbook.form
{
    partial class frmNewMaintainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMaintainer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "New Maitainer ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-1, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 45);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtempcode
            // 
            this.txtempcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempcode.Location = new System.Drawing.Point(110, 93);
            this.txtempcode.Name = "txtempcode";
            this.txtempcode.Size = new System.Drawing.Size(80, 20);
            this.txtempcode.TabIndex = 38;
            this.txtempcode.TextChanged += new System.EventHandler(this.txtitemname_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Name Of maintainer   :";
            // 
            // txtempname
            // 
            this.txtempname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempname.Location = new System.Drawing.Point(189, 93);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(192, 20);
            this.txtempname.TabIndex = 41;
            // 
            // txtdesignation
            // 
            this.txtdesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesignation.Location = new System.Drawing.Point(110, 160);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(145, 20);
            this.txtdesignation.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 46;
            this.label7.Text = "Department  :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Section  :";
            // 
            // txtdept
            // 
            this.txtdept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdept.Location = new System.Drawing.Point(110, 217);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(145, 20);
            this.txtdept.TabIndex = 48;
            // 
            // txtsection
            // 
            this.txtsection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsection.Location = new System.Drawing.Point(110, 271);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(145, 20);
            this.txtsection.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Designation  :";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(347, 332);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(85, 30);
            this.btnclose.TabIndex = 173;
            this.btnclose.Text = "   &Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(253, 330);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(78, 31);
            this.BtnSave.TabIndex = 174;
            this.BtnSave.Text = " &Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmNewMaintainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 367);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtempcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNewMaintainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNewMaintainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclose;
        internal System.Windows.Forms.Button BtnSave;
    }
}