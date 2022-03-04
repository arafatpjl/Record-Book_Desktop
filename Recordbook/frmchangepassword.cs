using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recordbook
{
    public partial class frmchangepassword : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();



        public frmchangepassword()
        {
            InitializeComponent();
        }

        private void frmchangepassword_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtuser_name.Text == "")
            {
                MessageBox.Show("Type UserName");
                txtuser_name.Focus();
                return;
            }

            if (txtoldpassword.Text == "")
            {
                MessageBox.Show("Type OldPassword");
                txtoldpassword.Focus();
                return;
            }
            if (txtnewpassword.Text == "")
            {
                MessageBox.Show("Type NewPassword");
                txtnewpassword.Focus();
                return;
            }
            if (txtconfirmpassword.Text == "")
            {
                MessageBox.Show("Type Confirm Password");
                txtconfirmpassword.Focus();
                return;
            }
            if (txtnewpassword.Text != txtconfirmpassword.Text)
            {

                MessageBox.Show("Confirm Correct Password");
                txtconfirmpassword.Focus();
                return;
            }

            try
            {
                string userQuery = @"select *
                              FROM [Sys_User_Name]

                            where UserName='" + txtuser_name.Text.Trim()
                            + "' and UserPWord='" + com.EncryptIt(txtoldpassword.Text.Trim(), 11)
                            + "'";
                DataTable dtuser = dc.selectquery(userQuery);
                Recordbook.Extra.call.bforeUserInfo = dtuser;
            }
            catch
            {
            }
            try
            {

                string up_query = "UPDATE [Sys_User_Name] SET [UserPWord] = '" + com.EncryptIt(txtconfirmpassword.Text.ToString(), 11) + "' WHERE UserID=" + Recordbook.Extra.call.bforeUserInfo.Rows[0]["userid"] + "";
                dc.nonselcetquery(up_query);
                MessageBox.Show("Successfually Update");

                txtuser_name.Text = "";
                txtoldpassword.Text = "";
                txtnewpassword.Text = "";
                txtconfirmpassword.Text = "";


            }
            catch
            {
                MessageBox.Show("Wrong User Information");
            }
        }

        
    }
}
