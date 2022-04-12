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
using System.Globalization;

namespace Recordbook.form
{
    public partial class frmtransaction : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        Recordbook.form.Find IS = new Find();


        string query = "";
        DataTable dt = null;
        string Deptshortname;
        int intTNO;
        string txttransid = "";
        string itntransid = "";

        public frmtransaction()
        {
            InitializeComponent();
       
        }

       

        public void txtCarrierId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select * from InfoEmp where  Empcode='" + txtCarrierId.Text + "'and CompID='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
               DataTable dt = dc.selectquery(query);
                //this.txtCarrierId.TextChanged += new System.EventHandler(this.txtCarrierId_TextChanged);
                if (dt.Rows.Count > 0)
                {

                    txtCarrierName.Text = dt.Rows[0]["Empname"].ToString();
                    txtCarrierrDeg.Text = dt.Rows[0]["Designation"].ToString();
                    txtCarrierDept.Text = dt.Rows[0]["Department"].ToString();
                    txtCarrierSec.Text  = dt.Rows[0]["Section"].ToString();
                }
                else
                {
                    //txtCarrierId.Text = "";
                    txtCarrierName.Text = "";
                    txtCarrierrDeg.Text = "";
                    txtCarrierDept.Text = "";
                    txtCarrierSec.Text = "";
                    //if (txtCarrierId.Text.Length == 0)
                    //{
                    //    MessageBox.Show("Wrong Carrier Code...Type Right Code");
                    //}

                }
                    
            }

            catch
            {
            }
                
        }


        private void txtReceiverId_TextChanged(object sender, EventArgs e)
        {


            try
            {
               
                query = @"select * from InfoEmp
                          where  Empcode='" + txtReceiverId.Text 
                          + "'and CompID='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
                DataTable dt = dc.selectquery(query);

                if (dt.Rows.Count > 0)
                {

                    txtReceiverName.Text = dt.Rows[0]["Empname"].ToString();
                    txtReceiverDeg.Text = dt.Rows[0]["Designation"].ToString();
                    txtReceiverDept.Text = dt.Rows[0]["Department"].ToString();
                    txtReceiverSec.Text = dt.Rows[0]["Section"].ToString();
                }
                else
                {
                    //txtReceiverId.Text = "";
                    txtReceiverName.Text = "";
                    txtReceiverDeg.Text = "";
                    txtReceiverDept.Text = "";
                    txtReceiverSec.Text = "";
                    //if (txtReceiverId.Text.Length == 0)
                    //{
                    //    MessageBox.Show("Wrong Receiver Code...Type Right Code");
                    //}

                }
                
            }

            catch
            {
            }

        }

       

        private void frmtransaction_Load(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            cboTransactionID.Visible = false;
        }

        private void txtFileNo_TextChanged(object sender, EventArgs e)
        {
            if (txtFileNo.Text.Length != 0)
            {
                if (btnnew.Text == "&New")
                {
                    query = "Select * from View_File_Details where File_No='" + txtFileNo.Text + "' and F_status=0";

                }
                else
                {
                    query = "Select * from View_File_Details where File_No='" + txtFileNo.Text + "'";
                }
                DataTable dt = dc.selectquery(query);
                if(dt.Rows.Count>0)
                {

                    txtFileName.Text = dt.Rows[0]["FILE_NAME"].ToString();
                    txtVolNo.Text = dt.Rows[0]["VOLUME_NO"].ToString();
                    txtFileType.Text = dt.Rows[0]["File_Type"].ToString();
                    txtShelfPosition.Text = dt.Rows[0]["SELF_POSITION"].ToString();
                    txtBuyerName.Text = dt.Rows[0]["Buyer_Name"].ToString();
                    txtSendDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
                    txtSendTime.Text = DateTime.Now.ToString("hh:mm:ss");

                }
                
            }
        }

        private void cbotransload()
        {


            query = "select Trans_No from dbo.new_TransNo INNER JOIN dbo.new_File_Transaction ON dbo.new_TransNo.T_ID = dbo.new_File_Transaction.Trans_ID WHERE dbo.new_TransNo.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND dbo.new_File_Transaction.DELETEROW=0 AND dbo.new_File_Transaction.TRANS_STATUS=1";
          
                cboTransactionID.DataSource = dc.selectquery(query); 
                cboTransactionID.ValueMember = "Trans_No";
                cboTransactionID.DisplayMember = "Trans_No";
                cboTransactionID.Text = "";
                cboTransactionID.SelectedIndex = -1;
                this.cboTransactionID.SelectedIndexChanged += new System.EventHandler(this.cboTransactionID_SelectedIndexChanged);
            

        }
          

        private void refresh()
        {
            //txtTransID.Text = "";
            txtCarrierId.Text = "";
            txtCarrierName.Text = "";
            txtCarrierrDeg.Text = "";
            txtCarrierDept.Text = "";
            txtCarrierSec.Text = "";
            txtReceiverId.Text = "";
            txtReceiverName.Text = "";
            txtReceiverDeg.Text = "";
            txtReceiverDept.Text = "";
            txtReceiverSec.Text = "";
            txtShelfPosition.Text = "";
            txtSendDate.Text = "";
            txtSendTime.Text = "";
            txtReturnDate.Text = "";
            txtReturnTime.Text = "";
            txtFileName.Text = "";
            txtFileNo.Text = "";
            txtVolNo.Text = "";
            txtFileType.Text = "";
            txtBuyerName.Text = "";
            cboTransactionID.SelectedIndex = -1;
            dgvfileEntry.Rows.Clear();
           
        }

        private  void cboTransactionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cboTransactionID.SelectedIndex = -1;
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

                DataTable dt = dc.selectquery(query);
                if (dt.Rows.Count > 0)
                {


                    string vid = dt.Rows[0]["Vol_ID"].ToString();
                    string TYPID = dt.Rows[0]["Type_ID"].ToString();
                    string PID = dt.Rows[0]["Pos_ID"].ToString();
                    string Byrid = dt.Rows[0]["Byr_id"].ToString();
                    string carrierid = dt.Rows[0]["Carrier_ID"].ToString();
                    string ReceiverID = dt.Rows[0]["Receiver_ID"].ToString();

                    txtFileName.Text = dt.Rows[0]["FILE_NAME"].ToString();
                    txtFileNo.Text = dt.Rows[0]["File_No"].ToString();
                    txtVolNo.Text = IS.findvol_name(vid);
                    txtFileType.Text = IS.findFile_Type(TYPID);
                    txtShelfPosition.Text = IS.findShelfPostion(PID);
                    txtBuyerName.Text = IS.bUYER_NAME(Byrid);
                    txtSendDate.Text = DateTime.Parse(dt.Rows[0]["Send_Date"].ToString()).ToShortDateString();
                    txtReturnDate.Text = DateTime.Parse(dt.Rows[0]["Return_Date"].ToString()).ToShortDateString();
                    txtSendTime.Text = DateTime.Parse(dt.Rows[0]["Send_Time"].ToString()).ToShortTimeString();
                    txtReturnTime.Text = DateTime.Parse(dt.Rows[0]["Return_Time"].ToString()).ToShortTimeString();
                    txtCarrierId.Text = IS.findCarrierCode(carrierid);
                    txtReceiverId.Text = IS.findReceiverCode(ReceiverID);

                    txtCarrierId_TextChanged(null, null);
                    txtReceiverId_TextChanged(null, null);

                }
            }

            catch
            {
            }

           
        }

        private void txtTransID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = @"SELECT dbo.File_Info_Sub.File_Name, dbo.File_Info_Sub.File_No, dbo.File_Info_Sub.Byr_id, dbo.File_Info_Main.Vol_ID, dbo.File_Info_Main.Type_ID,dbo.File_Info_Main.Pos_ID,
                      dbo.new_File_Transaction.Send_Date, dbo.new_File_Transaction.Send_Time, dbo.new_File_Transaction.Return_Date,
                       dbo.new_File_Transaction.Return_Time, dbo.new_File_Transaction.Carrier_ID, dbo.new_File_Transaction.Receiver_ID,dbo.new_File_Transaction.DeleteRow,
                       dbo.new_TransNo.Trans_No
                       FROM dbo.new_File_Transaction INNER JOIN
                       dbo.new_TransNo ON dbo.new_File_Transaction.CompId = dbo.new_TransNo.CompId AND
                       dbo.new_File_Transaction.Trans_ID = dbo.new_TransNo.T_ID INNER JOIN
                       dbo.File_Info_Main ON dbo.new_File_Transaction.File_ID = dbo.File_Info_Main.F_ID INNER JOIN
                       dbo.File_Info_Sub ON dbo.File_Info_Main.F_ID = dbo.File_Info_Sub.F_ID where Trans_No = '" + txtTransID.Text
                          + "' AND  dbo.new_File_Transaction.DeleteRow=0 AND dbo.new_File_Transaction.CompId='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";

                DataTable dt = dc.selectquery(query);
                if (dt.Rows.Count > 0)
                {


                    string vid = dt.Rows[0]["Vol_ID"].ToString();
                    string TYPID = dt.Rows[0]["Type_ID"].ToString();
                    string PID = dt.Rows[0]["Pos_ID"].ToString();
                    string Byrid = dt.Rows[0]["Byr_id"].ToString();
                    string carrierid = dt.Rows[0]["Carrier_ID"].ToString();
                    string ReceiverID = dt.Rows[0]["Receiver_ID"].ToString();



                    txtFileName.Text = dt.Rows[0]["FILE_NAME"].ToString();
                    txtFileNo.Text = dt.Rows[0]["File_No"].ToString();
                    txtVolNo.Text = IS.findvol_name(vid);
                    txtFileType.Text = IS.findFile_Type(TYPID);
                    txtShelfPosition.Text = IS.findShelfPostion(PID);
                    txtBuyerName.Text = IS.bUYER_NAME(Byrid);
                    txtSendDate.Text = DateTime.Parse(dt.Rows[0]["Send_Date"].ToString()).ToShortDateString();
                    txtReturnDate.Text = DateTime.Parse(dt.Rows[0]["Return_Date"].ToString()).ToShortDateString();
                    txtSendTime.Text = DateTime.Parse(dt.Rows[0]["Send_Time"].ToString()).ToShortTimeString();
                    txtReturnTime.Text = DateTime.Parse(dt.Rows[0]["Return_Time"].ToString()).ToShortTimeString();
                    txtCarrierId.Text = IS.findCarrierCode(carrierid);
                    txtReceiverId.Text = IS.findReceiverCode(ReceiverID);

                    txtCarrierId_TextChanged(null, null);
                    txtReceiverId_TextChanged(null, null);

                }


            }

            catch
            {
            }
            

        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cheak())
               
                {
                    return;
                }

                foreach(DataGridViewRow row in dgvfileEntry.Rows )
                {
                    if (row.Cells["File_No"].Value.ToString() == txtFileNo.Text)
                    {
                        MessageBox.Show("Already Added this File_No !");
                        return;
                    }



                }

                dgvfileEntry.Rows.Add(txtFileName.Text, txtFileNo.Text, txtFileType.Text, txtVolNo.Text, txtShelfPosition.Text, txtSendDate.Text, txtReturnDate.Text, txtSendTime.Text, txtReturnTime.Text);

            }

            catch
            {
            }
        }


       
        private bool cheak ()
        {
            if (txtFileNo.Text == "")
            {
                MessageBox.Show("Select File No");
                txtFileNo.Focus();
                return false;
            }

            if (txtCarrierId.Text == "")
            {
                MessageBox.Show("Type Carrier Id");
                txtCarrierId.Focus();
                return false;
            }
            if (txtReceiverId.Text == "")
            {
                MessageBox.Show("Type Receiver Id");
                txtReceiverId.Focus();
                return false;
            }

            if (txtReturnDate.Text == "")
            {
                MessageBox.Show("Type Return Date");
                txtReturnDate.Focus();
                return false;
            }

            if (txtReturnTime.Text == "")
            {
                MessageBox.Show("Type Return Time");
                txtReturnTime.Focus();
                return false;
            }
            return true;

        }


       

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!cheak())
            {
                return;
            }

            DialogResult YesNO = MessageBox.Show("Do you want to Delete ?", "confirmation !", MessageBoxButtons.YesNo);
            if (YesNO.ToString() == "Yes")
            {

                query = @"UPDATE new_File_Transaction SET new_File_Transaction.DeleteRow=1 , new_File_Transaction.Trans_Status=0
                        from new_File_Transaction inner join  new_TransNo on new_File_Transaction.Trans_ID=new_TransNo.T_ID and new_File_Transaction.CompId=new_TransNo.CompId
                        where  dbo.new_TransNo.Trans_No='" + cboTransactionID.SelectedValue + "'and new_File_Transaction.DeleteRow=0";
                dc.nonselcetquery(query);
                MessageBox.Show("Transaction  successfully Deleted");

                refresh();

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string sl = "";


            try
            {




                if (dgvfileEntry.RowCount <= 0)
                {
                    MessageBox.Show("Record Not Found");
                    btnadd.Focus();
                    return;
                }

                foreach (DataGridViewRow row in dgvfileEntry.Rows)
                {
                    if (btnsave.Text == "&Save")
                    {
                        DialogResult YesNO = MessageBox.Show("Do you want to save ?", "confirmation !", MessageBoxButtons.YesNo);
                        if (YesNO.ToString() == "Yes")
                        {
                            query = "SELECT DeptShortName FROM Dept_Name Where DeptName = '" + IS.findDept(txtFileNo.Text) + "'";
                            dt = dc.selectquery(query);

                            if (dt.Rows.Count > 0)
                            {
                                Deptshortname = dt.Rows[0]["DeptShortName"].ToString();

                            }
                            else
                            {
                                Deptshortname = "NF";
                            }


                            query = "SELECT Max(T_No) As T_NO FROM new_TransNo Where CompID = '" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' And Dept_Name = '" + txtReceiverSec.Text + "' And T_Year = " + Recordbook.Extra.call.Year + "";
                            dt = dc.selectquery(query);
                            if (dt.Rows.Count > 0 && ((dt.Rows[0]["T_No"].ToString()) != ""))
                            {
                                intTNO = int.Parse(dt.Rows[0]["T_No"].ToString()) + 1;
                            }
                            else
                            {
                                intTNO = 1;
                            }

                            if ((intTNO > 0) && (intTNO < 10))
                            {
                                sl = "0000" + intTNO;
                            }
                            else if ((intTNO > 9) && (intTNO < 100))
                            {
                                sl = "000" + intTNO;

                            }
                            else if ((intTNO > 99) && (intTNO < 1000))
                            {
                                sl = "00" + intTNO;

                            }
                            else if ((intTNO > 999) && (intTNO < 10000))
                            {
                                sl = "0" + intTNO;

                            }
                            else if ((intTNO > 9999) && (intTNO < 100000))
                            {
                                sl = intTNO.ToString();

                            }


                            txttransid = Deptshortname + com.CompanyInfo.Rows[0]["CompID"].ToString() + sl + "-" + Recordbook.Extra.call.Year;


                            query = "insert into new_TransNo (CompId,Trans_No,T_No,Dept_Name,T_Year) values ('" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + txttransid + "','" + sl + "','" + txtReceiverSec.Text + "','" + Recordbook.Extra.call.Year + "')";
                            dc.selectquery(query);


                            itntransid = IS.findtransId(txttransid);



                            query = "update File_Info_Sub set F_Status = 1 where F_ID='" + IS.findFId(row.Cells["File_No"].Value.ToString()) + "' and deleterow=0";
                            dc.selectqueryds(query);


                            query = @"insert into new_File_Transaction (CompId,Trans_ID, File_ID, Sender_ID, Receiver_ID, Carrier_ID, Send_Date, 
                                Send_Time, Return_Date, Return_Time, DeleteRow,Trans_Status,EntryDate, EntryTime, ComName,UserName)
                                VALUES ('" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + itntransid + "','" + IS.findFId(row.Cells["File_No"].Value.ToString())
                                        + "','" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "','" + IS.findReceiverID(txtReceiverId.Text) + "','" + IS.findCarrierid(txtCarrierId.Text)
                                        + "','" + row.Cells["SendDate"].Value.ToString() + "','" + row.Cells["SendTime"].Value.ToString() + "','" + row.Cells["ReturnDate"].Value.ToString()
                                        + "','" + row.Cells["ReturnTime"].Value.ToString() + "',0,1,'" + DateTime.Now.ToString("dd-MMM-yyyy") + "','"
                                        + DateTime.Now.ToString("hh:mm:ss") + "','" + com.SysConfigInfo.Rows[0]["ComName"].ToString()
                                        + "','" + Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString() + "')";
                            dc.nonselcetquery(query);
                            MessageBox.Show("Data Successfually Saved");
                            refresh();
                        }

                    }


                    else
                    {
                        DialogResult YesNO = MessageBox.Show("Do you want to Update ?", "confirmation !", MessageBoxButtons.YesNo);
                        if (YesNO.ToString() == "Yes")
                        {
                            itntransid = IS.findtransId(cboTransactionID.Text);


                            query = "Update new_File_Transaction set DeleteRow=2 where Trans_ID='" + itntransid + "'";
                            dc.selectqueryds(query);


                            query = @"insert into new_File_Transaction (CompId,Trans_ID, File_ID, Sender_ID, Receiver_ID, Carrier_ID, Send_Date, 
                                Send_Time, Return_Date, Return_Time, DeleteRow,Trans_Status,EntryDate, EntryTime, ComName,UserName)
                                VALUES ('" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + itntransid + "','" + IS.findFId(row.Cells["File_No"].Value.ToString())
                                        + "','" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "','" + IS.findReceiverID(txtReceiverId.Text) + "','" + IS.findCarrierid(txtCarrierId.Text)
                                        + "','" + row.Cells["SendDate"].Value.ToString() + "','" + row.Cells["SendTime"].Value.ToString() + "','" + row.Cells["ReturnDate"].Value.ToString()
                                        + "','" + row.Cells["ReturnTime"].Value.ToString() + "',0,1,'" + DateTime.Now.ToString("dd-MMM-yyyy") + "','"
                                        + DateTime.Now.ToString("hh:mm:ss") + "','" + com.SysConfigInfo.Rows[0]["ComName"].ToString()
                                        + "','" + Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString() + "')";
                            dc.nonselcetquery(query);
                            MessageBox.Show("Data Successfually Update");
                            refresh();
                        }

                    }

                }

            }

            catch
            {
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            refresh();

            if (btnnew.Text == "Edit")
            {

                btnnew.Text = "&New";
                btnsave.Text = "&Save";
                cboTransactionID.Visible = false;
                txtTransID.Text = "";



                refresh();

            }
            else
            {
                btndelete.Enabled = true;
                btnsave.Text = "&Update";
                btnnew.Text = "Edit";
                cboTransactionID.Visible = true;

                cbotransload();

                refresh();



            }
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (cboTransactionID.SelectedIndex == -1)
            {
                MessageBox.Show("Select TransactionID No");
                return;
            }

            ReportViwer RP;
            DataTable dt = new DataTable();
            string Reportname = "";

            query = @"Select * from View_File_Transaction_Details Where DELETEROW=0  AND compId = '" + com.CompanyInfo.Rows[0]["CompID"].ToString()
                   + "' and T_ID = '" + IS.findtransId(cboTransactionID.SelectedValue.ToString()) + "' ORDER BY File_No ";
            //dc.selectquery(query);
            dt = dc.selectquery(query);
            RP = new ReportViwer("transaction Details", dt);
            RP.Show();
        }

        private void txtSendDate_Leave(object sender, EventArgs e)
        {
            var myTxt = (TextBox)sender;

            string date = myTxt.Text;
            if (myTxt.Text.Length < 6)
            {
                MessageBox.Show("Invalid Date.Please 6 digit");
                myTxt.Focus();
                return;
            }
            if (date.Length == 6)
            {

                string[] str = new string[3];
                string strDate = "";

                str[0] = date.Substring(0, 2);
                str[1] = date.Substring(2, 2);
                str[2] = "20" + date.Substring(4, 2);  //work from 2000


                strDate = str[0] + "-" + str[1] + "-" + str[2];
                DateTime newdate;
                if (DateTime.TryParse(strDate, new CultureInfo("en-CA"), DateTimeStyles.None, out newdate))
                {
                    myTxt.Text = newdate.ToString("dd-MMM-yyyy");
                }
                else
                    MessageBox.Show("You enter an invalid date.Please enter date as \"DDMMYY\"");
            }
        }

        private void txtReturnDate_Leave(object sender, EventArgs e)
        {
            var myTxt = (TextBox)sender;

            string date = myTxt.Text;
            if (myTxt.Text.Length < 6)
            {
                MessageBox.Show("Invalid Date.Please 6 digit");
                myTxt.Focus();
                return;
            }
            if (date.Length == 6)
            {

                string[] str = new string[3];
                string strDate = "";

                str[0] = date.Substring(0, 2);
                str[1] = date.Substring(2, 2);
                str[2] = "20" + date.Substring(4, 2);  //work from 2000


                strDate = str[0] + "-" + str[1] + "-" + str[2];
                DateTime newdate;
                if (DateTime.TryParse(strDate, new CultureInfo("en-CA"), DateTimeStyles.None, out newdate))
                {
                    myTxt.Text = newdate.ToString("dd-MMM-yyyy");
                }
                else
                    MessageBox.Show("You enter an invalid date.Please enter date as \"DDMMYY\"");
            }
        }

        private void txtSendDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        public void keyDownNext(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtReturnDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);

        }

        private void txtSendTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);

        }

        private void txtReturnTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);

        }

       

        

       

  

       


        
       


    }
}
