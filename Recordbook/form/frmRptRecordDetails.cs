using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Recordbook.Report;
using CrystalDecisions.CrystalReports.Engine;

namespace Recordbook.form
{
    public partial class frmRptRecordDetails : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        string query = "";
        DataTable dt;




        public frmRptRecordDetails()
        {
            InitializeComponent();
        }

      
      


        private void frmNewPosition_Load(object sender, EventArgs e)
        {
           
            query = "Select  * from Dept_Name order by DeptName ";

            cmbdept.DataSource = dc.selectquery(query);
            cmbdept.ValueMember = "DeptName";
            cmbdept.DisplayMember = "DeptName";

            cmbdept.SelectedIndex = -1;
            cmbdept.Enabled = false;
        }

      

        

        private void optShelfNo_Click(object sender, EventArgs e)
        {
            txtShelfNo.Enabled = true;
            OptLeft.Enabled = true;
            OptRight.Enabled = true;
            cmbdept.Enabled = false;
        }

        private void optAll_Click(object sender, EventArgs e)
        {
            txtShelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cmbdept.Enabled = false;
        }

        private void optdept_Click(object sender, EventArgs e)
        {
            txtShelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cmbdept.Enabled = true;

        }

       
        private DataTable previewdata()
        {
            int sl;
            string VAL = "";
             string VALL = "";
            string VALR = "";

            if (optAll.Checked)
            {
                //query = "Select * from view_Overview_RecordRoom where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                query = "Select * from view_Overview_RecordRoom where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                dt = dc.selectquery(query);
            }
            else if (optdept.Checked)
            {

                query = "Select * from view_Overview_RecordRoom where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and  DeptName='" + cmbdept.Text + "' order by SELF_POSITION,FILE_NAME";
                dt = dc.selectquery(query);
            }
            else if(optShelfNo.Checked)
           {
                sl = int.Parse(txtShelfNo.Text);

                if ((sl > 0) && (sl < 10))
                {
                    VAL = "CBT00" + sl;
                }
                else
                {
                    VAL = "CBT0" + sl;
                }

                   if (optShelfNo.Checked == true && OptLeft.Checked == false && OptRight.Checked == false)
                       {
                        //query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VAL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VAL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'  order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                       }
                       else if (optShelfNo.Checked == true && OptLeft.Checked == true )
                       {
                   
                       VALL = VAL + "/" + "L";
                       //query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VALL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                       query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VALL + "%'  order by SELF_POSITION,FILE_NAME";
                       dt = dc.selectquery(query);
                       }
                      else if (optShelfNo.Checked == true &&  OptRight.Checked == true)
                       {
                   
                       VALR = VAL + "/" + "R";
                       //query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VALR + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                       query = "select * from View_File_Details where  SELF_POSITION LIKE '" + VALR + "%' order by SELF_POSITION,FILE_NAME";
                       dt = dc.selectquery(query);
                       }
             }

              return dt;
            }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (optShelfNo.Checked == true)
            {
                if (optShelfNo.Text.Length == 0)
                {
                    MessageBox.Show("Type Shelf No");
                    txtShelfNo.Focus();
                }
            }



            ReportViwer RP;
            DataTable dt = new DataTable();
            dt = previewdata();
            RP = new ReportViwer("record room details", dt);
            RP.Show();
        }

       
            

        }

       
    }

