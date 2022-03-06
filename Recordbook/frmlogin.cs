using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Management;

namespace Recordbook
{
    public partial class frmlogin : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        public frmlogin()
        {
            InitializeComponent();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        public void keyDownNext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

      

        private void btnchange_Click(object sender, EventArgs e)
        {
            Recordbook.frmchangepassword shw = new frmchangepassword();
            shw.ShowDialog();
        }

        //private void btnedit_Click(object sender, EventArgs e)
        //{
            
        //}

        private string GetMac()
        {
            string Mac = string.Empty;

            ManagementClass MC = new ManagementClass("Win32_NetworkAdapter");
            ManagementObjectCollection MOCol = MC.GetInstances();
            foreach (ManagementObject MO in MOCol)
                if (MO != null)
                {
                    if (MO["MacAddress"] != null)
                    {
                        Mac = MO["MACAddress"].ToString();
                        if (Mac != string.Empty)
                            break;
                    }
                }
            return Mac;
        }

       
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser_name.Text == "")
            {
                MessageBox.Show("Type UserName");
                txtuser_name.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Type Userpassword");
                txtpassword.Focus();
                return;
            }
            try
            {



                string userQuery = @"select *
                              FROM [Sys_User_Name]

                            where UserName='" + txtuser_name.Text.Trim()
                            + "' and YsnActive='1' and UserPWord='" + com.EncryptIt(txtpassword.Text.Trim(), 11)
                            + "'";
                DataTable dtuser = dc.selectquery(userQuery);



                if (txtpassword.Text == com.DecryptIt(dtuser.Rows[0]["UserPWord"].ToString(), 11))
                {

                    //  userID = txtuserId.Text.Trim();

                    Recordbook.Extra.call.UserInfo = dtuser;
                    Recordbook.Extra.call.User = dtuser.Rows[0]["UserName"].ToString();



                    string QueryControl = @"       SELECT *
                                          FROM [tblControl] where ID in (" + Recordbook.Extra.call.UserInfo.Rows[0]["Control_id"] + ")";


                    Recordbook.Extra.call.UserControlInfo = dc.selectquery(QueryControl); ;

                    try
                    {

                        string up_query = "UPDATE [Sys_User_Name] SET [last_login_date] = '" + DateTime.Now.ToString() + "', last_login_Mac='" + GetMac() + "' WHERE UserName='" + txtuser_name.Text.Trim() + "'";
                        dc.nonselcetquery(up_query);
                    }
                    catch
                    {

                    }

                    this.Hide();
                    Recordbook.form.frmmenu shw = new form.frmmenu();
                    shw.ShowDialog();

                }

            }
            catch
            {
                MessageBox.Show(" Wrong Username And Password ");
            }
        }

        private void keyDownNextbtnchange_KeyDown(object sender, KeyEventArgs e)
        {

        }

       

     

    }
}
