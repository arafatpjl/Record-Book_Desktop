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
    public partial class frmTransactionReturn : Form
    {
      
        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        Recordbook.form.Find IS = new Find();

        string query = "";
        DataTable dt = null;
      

        public frmTransactionReturn()
        {
            InitializeComponent();
       
        }


        private void frmTransactionReturn_Load(object sender, EventArgs e)
        {
            query = "select Trans_No from dbo.new_TransNo INNER JOIN dbo.new_File_Transaction ON dbo.new_TransNo.T_ID = dbo.new_File_Transaction.Trans_ID WHERE dbo.new_TransNo.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND dbo.new_File_Transaction.DELETEROW=0 AND dbo.new_File_Transaction.TRANS_STATUS=1";

            cboTransactionID.DataSource = dc.selectquery(query);
            cboTransactionID.ValueMember = "Trans_No";
            cboTransactionID.DisplayMember = "Trans_No";
            cboTransactionID.Text = "";
            cboTransactionID.SelectedIndex = -1;
            this.cboTransactionID.SelectedIndexChanged += new System.EventHandler(this.cboTransactionID_SelectedIndexChanged);
            

        }

        private void cboTransactionID_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            

           try
            {
                if (cboTransactionID.SelectedIndex != -1)
                {
                    dgvfileEntry.Rows.Clear();

                query = @"SELECT dbo.File_Info_Sub.File_Name, dbo.File_Info_Sub.File_No, dbo.File_Info_Sub.Byr_id, dbo.File_Info_Main.Vol_ID, dbo.File_Info_Main.Type_ID,dbo.File_Info_Main.Pos_ID,
                      dbo.new_File_Transaction.Send_Date, dbo.new_File_Transaction.Send_Time, dbo.new_File_Transaction.Return_Date,
                       dbo.new_File_Transaction.Return_Time, dbo.new_File_Transaction.Carrier_ID, dbo.new_File_Transaction.Receiver_ID,dbo.new_File_Transaction.DeleteRow,
                       dbo.new_TransNo.Trans_No
                       FROM dbo.new_File_Transaction INNER JOIN
                       dbo.new_TransNo ON dbo.new_File_Transaction.CompId = dbo.new_TransNo.CompId AND
                       dbo.new_File_Transaction.Trans_ID = dbo.new_TransNo.T_ID INNER JOIN
                       dbo.File_Info_Main ON dbo.new_File_Transaction.File_ID = dbo.File_Info_Main.F_ID INNER JOIN
                       dbo.File_Info_Sub ON dbo.File_Info_Main.F_ID = dbo.File_Info_Sub.F_ID where Trans_No = '" + cboTransactionID.Text
                         + "' AND  dbo.new_File_Transaction.DeleteRow=0 AND dbo.new_File_Transaction.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
                
               dt=dc.selectquery(query);
               if (dt.Rows.Count > 0)
               {

                   string vid = dt.Rows[0]["Vol_ID"].ToString();
                   string TYPID = dt.Rows[0]["Type_ID"].ToString();
                   string PID = dt.Rows[0]["Pos_ID"].ToString();
                   string Byrid = dt.Rows[0]["Byr_id"].ToString();
                   string carrierid = dt.Rows[0]["Carrier_ID"].ToString();
                   string ReceiverID = dt.Rows[0]["Receiver_ID"].ToString();

                   dgvfileEntry.Rows.Add(dt.Rows[0]["File_Name"].ToString(), dt.Rows[0]["File_No"].ToString(), IS.findFile_Type(TYPID), IS.findvol_name(vid), IS.findShelfPostion(PID), DateTime.Parse(dt.Rows[0]["Send_Date"].ToString()).ToShortDateString(), DateTime.Parse(dt.Rows[0]["Return_Date"].ToString()).ToShortDateString(), DateTime.Parse(dt.Rows[0]["Send_Time"].ToString()).ToShortTimeString(), DateTime.Parse(dt.Rows[0]["Return_Time"].ToString()).ToShortTimeString());
               }
           }

            }

            catch
            {
            }
        }


       
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (cboTransactionID.SelectedIndex == -1)
            {
                MessageBox.Show("Select TransactionID  No");
                return;
            }

            ReportViwer RP;
            DataTable dt = new DataTable();
            //string Reportname = "";

            query = @"Select * from View_File_Transaction_Details Where DELETEROW=0  AND compId = '" + com.CompanyInfo.Rows[0]["CompID"].ToString()
                   + "' and T_ID = '" + IS.findtransId(cboTransactionID.SelectedValue.ToString()) + "' ORDER BY File_No ";
            //dc.selectquery(query);
            dt = dc.selectquery(query);
            RP = new ReportViwer("Return transaction Details", dt);
            RP.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvfileEntry.RowCount <= 0)
                {
                    MessageBox.Show("Record Not Found");
                    btnshow.Focus();
                    return;
                }
                query = "Insert into new_File_Return_Transaction values('" + IS.findtransId(cboTransactionID.SelectedValue.ToString()) + "','" + DateTime.Now.ToString("dd-MMM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "') ";
                dc.selectquery(query);


                query = "Update new_File_Transaction set Trans_Status=0 where Trans_ID='" + IS.findtransId(cboTransactionID.SelectedValue.ToString()) + "' and deleterow=0  ";
                dc.selectquery(query);


                query = "update File_Info_Sub set F_Status=0 where F_ID='" + IS.findftransId(IS.findtransId(cboTransactionID.SelectedValue.ToString())) + "' and deleterow=0  ";
                dc.selectquery(query);

                MessageBox.Show("Successfully Returned");

                cboTransactionID.SelectedIndex = -1;
                dgvfileEntry.Rows.Clear();
            }

            catch
            {
            }
        }

        

    }
}
