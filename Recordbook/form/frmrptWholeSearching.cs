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
    public partial class frmrptWholeSearching : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        Recordbook.form.Find IS = new Find();


        DataTable dt = null;
        string query = "";

        

        public frmrptWholeSearching()
        {
            InitializeComponent();
        }

       

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

       
        private void cmbdesg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmrptWholeSearching_Load(object sender, EventArgs e)
        {
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cboFileName.Enabled = false;
            cboTransaction.Enabled = false;
            cboDept.Enabled = false;
            cboBuyerName.Enabled = false;
            txtMcode.Enabled = false;


            query = "Select  * from Dept_Name Order by DeptName";

           cboDept.DataSource = dc.selectquery(query);
           cboDept.ValueMember = "Deptid";
           cboDept.DisplayMember = "DeptName";

           cboDept.SelectedIndex = -1;


           query = " SELECT distinct File_Name from View_File_Details_User where compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' order by  File_Name";

           cboFileName.DataSource = dc.selectquery(query);
           cboFileName.ValueMember = "File_Name";
           cboFileName.DisplayMember = "File_Name";

           cboFileName.SelectedIndex = -1;


           query = "Select * from New_Buyer_Name ORDER BY Buyer_Name";

           cboBuyerName.DataSource = dc.selectquery(query);
           cboBuyerName.ValueMember = "Byrid";
           cboBuyerName.DisplayMember = "Buyer_Name";

           cboBuyerName.SelectedIndex = -1;


           query = "select DISTINCT Trans_No from View_File_Transaction_Details_User WHERE compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' ";

           cboTransaction.DataSource = dc.selectquery(query);
           cboTransaction.ValueMember = "Trans_No";
           cboTransaction.DisplayMember = "Trans_No";

           cboTransaction.SelectedIndex = -1;
           

        }


        private void OptShelfNo_Click(object sender, EventArgs e)
        {
            txtshelfNo.Text = "";
            txtshelfNo.Enabled = true;
            OptLeft.Enabled = true;
            OptRight.Enabled = true;
            cboFileName.Enabled = false;
            cboTransaction.Enabled = false;
            cboDept.Enabled = false;
            cboBuyerName.Enabled = false;
            txtMcode.Enabled = false;

        }

        private void optdept_Click(object sender, EventArgs e)
        { 
            cboDept.Enabled = true;
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cboFileName.Enabled = false;
            cboTransaction.Enabled = false;
            cboBuyerName.Enabled = false;
            txtMcode.Enabled = false;
        }

        private void OptFileName_Click(object sender, EventArgs e)
        {
           
            cboFileName.Enabled = true;
            cboDept.Enabled = false;
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cboTransaction.Enabled = false;
            cboBuyerName.Enabled = false;
            txtMcode.Enabled = false;
        }

        private void OptTrans_Click(object sender, EventArgs e)
        {
            //cboTransaction.Clear
            cboTransaction.Enabled = true;
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cboFileName.Enabled = false;
            cboDept.Enabled = false;
            cboBuyerName.Enabled = false;
            txtMcode.Enabled = false;    

        }

        private void optBuyerName_Click(object sender, EventArgs e)
        {
            //cboBuyerName.Clear
            cboBuyerName.Enabled = true;
            cboDept.Enabled = false;
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
            cboFileName.Enabled = false;
            cboTransaction.Enabled = false;
            txtMcode.Enabled = false;
        }

        private void optMcode_Click(object sender, EventArgs e)
        {
            txtMcode.Text = "";
            txtMcode.Enabled = true;
            cboFileName.Enabled = false;
            cboTransaction.Enabled = false;
            cboDept.Enabled = false;
            cboBuyerName.Enabled = false;
            txtshelfNo.Enabled = false;
            OptLeft.Enabled = false;
            OptRight.Enabled = false;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int sl ;
            string VAL="";
            string VALL = "";
            string VALR = "";

            if ((OptShelfNo.Checked) && txtshelfNo.Text != "")
            {
                sl = int.Parse(txtshelfNo.Text);
                 if ((sl > 0) && (sl < 10))
                 {
                     VAL = "CBT00" + sl;

                 }
                 else
                 {
                     VAL = "CBT0" + sl;
                 }
            }

            listView1.Items.Clear();

            if (OptTrans.Checked)
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();

                if (cboTransaction.Text.Length !=0)
                {
                    query = "select * from View_File_Transaction_Details_User where TRANS_ID ='" + IS.findtransId(cboTransaction.SelectedValue.ToString()) + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                    dt=dc.selectquery(query);
                }
                else
                {
                    query = "select * from View_File_Transaction_Details_User where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                    dt= dc.selectquery(query);
                }
                colheader();

            }
            else
              {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                colheader();

                if (OptShelfNo.Checked == true && OptLeft.Checked == false && OptRight.Checked==false)
                {
                    query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VAL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' ORDER BY File_No";
                    dt = dc.selectquery(query);

                }
                     //query = query +" ";

                else if (OptShelfNo.Checked == true && OptLeft.Checked == true && OptRight.Checked == false)
                {
                    listView1.Items.Clear();
                    VALL = VAL + "/" + "L";
                    query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VALL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'ORDER BY SELF_POSITION,File_No";
                    dt = dc.selectquery(query);
                }
                else if (OptShelfNo.Checked == true && OptLeft.Checked == false && OptRight.Checked == true)
                {
                    listView1.Items.Clear();
                    VALR = VAL + "/" + "R";
                    query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VALR + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'ORDER BY SELF_POSITION,File_No";
                    dt = dc.selectquery(query);
                }
                  
                else if (optdept.Checked)
                {
                    listView1.Items.Clear();
                    if (cboDept.Text.Length != 0)
                    {
                        query = "Select * from view_Overview_RecordRoom_User Where deptName='" + cboDept.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User Where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                    }

                }
                else if (OptFileName.Checked)
                { 
                    listView1.Items.Clear();
                    if (cboFileName.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User Where File_Name='" + cboFileName.Text + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by FILE_NO,SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by FILE_NO,SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                    }
                }
                else if (optBuyerName.Checked)
                {
                    listView1.Items.Clear();
                    if (cboBuyerName.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User  where Buyer_Name='" + cboBuyerName.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
                        dt = dc.selectquery(query);

                    }
                }

                else if (optMcode.Checked)
                {
                    listView1.Items.Clear();
                    if (txtMcode.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User  where Mcode='" + txtMcode.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                        dt = dc.selectquery(query);

                    }
                }

                 
            }


            prcLoadData();

            
        }

        private void colheader()

        {
            
            if (OptTrans.Checked)
            {

                listView1.Columns.Add("Id", 30, HorizontalAlignment.Left);
                listView1.Columns.Add("Transaction No", 100 ,HorizontalAlignment.Left);
                listView1.Columns.Add("File NO", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("File Type", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Volume No", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Department", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Shelf Position", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Send Date", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Return Date", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Sender Name", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Receiver Name", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Carrier Name", 100, HorizontalAlignment.Left);
            }
            else
            {
                listView1.Columns.Add("IdNo", 40, HorizontalAlignment.Left);
                listView1.Columns.Add("File Name", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("File NO", 120, HorizontalAlignment.Left);
                listView1.Columns.Add("File Type", 80, HorizontalAlignment.Left);
                listView1.Columns.Add("Volume No", 80, HorizontalAlignment.Left);
                listView1.Columns.Add("Department", 150, HorizontalAlignment.Left);
                listView1.Columns.Add("Shelf Position", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Start Date", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("End Date", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Maintainer", 150, HorizontalAlignment.Left);
               

            }

        }
        private void prcLoadData()
        {

            if (OptTrans.Checked)
            {
                int a = dt.Rows.Count;
                for (int i = 0; i <= a - 1; i++)
                {
                    ListViewItem lvwFA1er = new ListViewItem(Convert.ToString(i + 1));
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Trans_No"].ToString());
                    //lvwFA1er.SubItems.Add(dt.Rows[i]["File_Name"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_No"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["File_Type"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["VOLUME_NO"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["DeptName"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["SELF_POSITION"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Send_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Return_Date"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Send_Time"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["Return_Time"].ToString());
                    lvwFA1er.SubItems.Add(dt.Rows[i]["C_Code"].ToString());
                    listView1.Items.Add(lvwFA1er);

                }
            }
            else
            {
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
        }

      

        private DataTable previewdata()
        {
            int sl;
            string VAL = "";
            string VALL = "";
            string VALR = "";
            if (OptShelfNo.Checked == true) 
            {
                if ((OptShelfNo.Checked==true) && ((OptLeft.Checked==true) || (OptLeft.Checked==false)) && txtshelfNo.Text=="")
                    {
                        query = "Select * from view_Overview_RecordRoom_User where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);
                    }
                else
                {
                    if(txtshelfNo.Text == "" )
                    {
                        sl=0;
                    }
                    else
                    {
                        sl=int.Parse(txtshelfNo.Text);
                    }

                    if (OptShelfNo.Checked)
                    {
                        
                        if ((sl > 0) && (sl < 10))
                        {
                            VAL = "CBT00" + sl;
                        }
                        else
                        {
                            VAL = "CBT0" + sl;
                        }

                       if (OptShelfNo.Checked == true && OptLeft.Checked == false && OptRight.Checked == false)
                       {
                        query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VAL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                       }
                       else if (OptShelfNo.Checked == true && OptLeft.Checked == true )
                       {
                   
                       VALL = VAL + "/" + "L";
                       query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VALL + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                       dt = dc.selectquery(query);
                       }
                      else if (OptShelfNo.Checked == true &&  OptRight.Checked == true)
                       {
                   
                       VALR = VAL + "/" + "R";
                       query = "select * from View_File_Details_User where  SELF_POSITION LIKE '" + VALR + "%' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                       dt = dc.selectquery(query);
                       }
                    }


                }


             }
             
               if (optdept.Checked)
                {
                    
                    if (cboDept.Text.Length != 0)
                    {
                        query = "Select * from view_Overview_RecordRoom_User Where deptName='" + cboDept.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                    }

                }
               if (OptFileName.Checked)
                {
               
                    if (cboFileName.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User Where File_Name='" + cboFileName.Text + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User  order by SELF_POSITION,FILE_NAME";
                        dt = dc.selectquery(query);

                    }
                }


               if (OptTrans.Checked)
               {
                   

                   if (cboTransaction.Text.Length != 0)
                   {
                       query = "select * from View_File_Transaction_Details_User where TRANS_ID ='" + IS.findtransId(cboTransaction.SelectedValue.ToString()) + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' order by SELF_POSITION,FILE_NAME";
                       dt = dc.selectquery(query);
                   }
                   else
                   {
                       query = "select * from View_File_Transaction_Details_User where  CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
                       dt = dc.selectquery(query);
                   }
                  

               }

               if (optBuyerName.Checked)
                {
                   
                    if (cboBuyerName.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User  where Buyer_Name='" + cboBuyerName.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
                        dt = dc.selectquery(query);

                    }
                }

                else if (optMcode.Checked)
                {
                    listView1.Items.Clear();
                    if (txtMcode.Text.Length != 0)
                    {

                        query = "Select * from view_Overview_RecordRoom_User  where Mcode='" + txtMcode.Text + "' AND CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
                        dt = dc.selectquery(query);
                    }
                    else
                    {
                        query = "Select * from view_Overview_RecordRoom_User where CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND USERID='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "'";
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
            if (OptShelfNo.Checked == true)
            {
                if (txtshelfNo.Text == "")
                {
                    MessageBox.Show("Select Cabinet No");
                    txtshelfNo.Focus();
                    return;

                }
                else
                {
                    ReportViwer RP;
                    DataTable dt = new DataTable();
                    dt = previewdata();
                    RP = new ReportViwer("record room details", dt);
                    RP.Show();
                }
            }

            if (optdept.Checked == true)
            {
                if (cboDept.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Deaprtment Name");
                    cboDept.Focus();
                    return;

                }
                else
                {
                    ReportViwer RP;
                    DataTable dt = new DataTable();
                    dt = previewdata();
                    RP = new ReportViwer("record details Dept", dt);
                    RP.Show();
                }
            }

            if (OptFileName.Checked == true)
            {
                if (cboFileName.SelectedIndex == -1)
                {
                    MessageBox.Show("Select File Name");
                    cboFileName.Focus();
                    return;

                }
                else
                {

                    ReportViwer RP;
                    DataTable dt = new DataTable();
                    dt = previewdata();
                    RP = new ReportViwer("record details FileName", dt);
                    RP.Show();
                }
            }
            if (OptTrans.Checked == true)
            {
                if (cboTransaction.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Transaction No");
                    cboTransaction.Focus();
                    return;

                }
                else
                {
                    ReportViwer RP;
                    DataTable dt = new DataTable();
                    dt = previewdata();
                    RP = new ReportViwer("Transaction File", dt);
                    RP.Show();
                }
            }
            if (optBuyerName.Checked == true)
            {
                if (cboBuyerName.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Buyer Name");
                    cboBuyerName.Focus();
                    return;

                }
                else
                {
                    ReportViwer RP;
                    DataTable dt = new DataTable();
                    dt = previewdata();
                    RP = new ReportViwer("record details Buyer", dt);
                    RP.Show();
                }
            }
            if (optMcode.Checked == true)
            {
                ReportViwer RP;
                DataTable dt = new DataTable();
                dt = previewdata();
                RP = new ReportViwer("record details Mcode", dt);
                RP.Show();
            }
        }

        private void txtFileNo_TextChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView1.Columns.Clear();
            colheader();

            string query = "select * from View_File_Details_USER Where File_No Like ('" + txtFileNo.Text + "%') AND UserId='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' AND dbo.View_File_Details_USER.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
            dt = dc.selectquery(query);

            prcLoadData();

        }

        }

      

      
  
    }


