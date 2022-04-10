using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recordbook.form
{
    public partial class frmSearching : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();


        DataTable dt = null;

        public frmSearching()
        {
            InitializeComponent();
        }

        private void frmSearching_Load(object sender, EventArgs e)
        {

            try
            {
              
                
                string squery = "SELECT DeptName,DeptId FROM Dept_Name ";
   
                cmbdept.DataSource = dc.selectquery(squery);
                cmbdept.ValueMember = "DeptId";
                cmbdept.DisplayMember = "DeptName";
                cmbdept.Text = "";
               //this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
                
               

            }

            catch
            {

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT distinct Dept_Name.DeptName, File_Info_Sub.File_Name  FROM File_Info_Main INNER JOIN Dept_Name ON File_Info_Main.Dept_ID = Dept_Name.DeptId INNER JOIN File_Info_Sub ON File_Info_Main.F_ID = File_Info_Sub.F_ID  where Dept_Name.DeptName='" +cmbdept.Text+ "' and File_Info_Main.deleterow=0 and File_Info_Sub.deleterow=0";
                cmbdesg.DataSource = dc.selectquery(query);
                cmbdesg.ValueMember = "File_Name";
                cmbdesg.DisplayMember = "File_Name";
                cmbdesg.Text = "";
                this.cmbdesg.SelectedIndexChanged += new System.EventHandler(this.cmbdesg_SelectedIndexChanged);
            }

            catch
            {
            }

        }

        private void cmbdesg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                string query = "select * from View_File_Details_USER Where File_No Like ('" + txtitemname.Text + "%') AND UserId='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' AND dbo.View_File_Details_USER.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' ";
                dt = dc.selectquery(query);
                int a = dt.Rows.Count;
                for (int i = 0; i <= a - 1; i++)
                {
                    ListViewItem lvwFA1er = new ListViewItem(Convert.ToString(i + 1));
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_Name"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_No"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_Type"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["VOLUME_NO"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["DeptName"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["SELF_POSITION"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Start_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["End_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["MName"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Buyer_Name"].ToString());
                    listView1.Items.Add(lvwFA1er);

                }
            }

            catch
            {
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
             if (cmbdept.Text == "")
            {
                MessageBox.Show("Select Department Name");
                cmbdept.Focus();
                return;
            }


            if (cmbdesg.Text == "")
            {
                MessageBox.Show("Select File Name");
                cmbdesg.Focus();
                return;
            }
            try
            {
                listView1.Items.Clear();
                //string abc = "select * from View_File_Details where DeptName='" + cmbdept.Text + "'  and File_name='" + cmbdesg.Text + "' and UserId='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' ";
                string abc = "select * from View_File_Details where DeptName='" + cmbdept.Text + "'  and File_name='" + cmbdesg.Text + "' ";
                dt = dc.selectquery(abc);
                int a = dt.Rows.Count;
                for (int i = 0; i <= a - 1; i++)
                {
                    ListViewItem lvwFA1er = new ListViewItem(Convert.ToString(i + 1));
                    //lvwFA1er.SubItems.Add(dt.Rows[i][""].ToString());
                    lvwFA1er.SubItems.Add( dt.Rows[i]["File_Name"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_No"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_Type"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["VOLUME_NO"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["DeptName"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["SELF_POSITION"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Start_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["End_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["MName"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Buyer_Name"].ToString());
                    listView1.Items.Add(lvwFA1er);

                }
            }
            catch
            {
            }
        
        }
    }
}
