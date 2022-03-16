using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Recordbook.Report;
using System.Globalization;
using CrystalDecisions.CrystalReports.Engine;

namespace Recordbook.form
{
    public partial class frmfileEntry : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        DataTable dt = null;
        string comp = "";
        string intfileid = "";
        string query="";
        string maintId = "";
        string strNFR = "";
        


        public frmfileEntry()
        {
            InitializeComponent();
        }


        private void frmHeadDetails_Load(object sender, EventArgs e)
        {
            txtfileno.Enabled = false;
            optleft.Checked = false;
            btndelete.Enabled = false;
            


            try
            {




                query = "Select  * from Dept_Name order by DeptName";

                cmbdepartment.DataSource = dc.selectquery(query);
                cmbdepartment.ValueMember = "Deptid";
                cmbdepartment.DisplayMember = "DeptName";
               
                cmbdepartment.SelectedIndex = -1;


                query = "select * from new_Volume_No WHERE sign= 0 order by VOLUME_NO";

                cmbvolum.DataSource = dc.selectquery(query);
                cmbvolum.ValueMember = "V_ID";
                cmbvolum.DisplayMember = "VOLUME_NO";
                cmbvolum.SelectedIndex = -1;



                query = "select * from new_File_Type WHERE sign= 0 order by File_Type";
                cmbfiletype.DataSource = dc.selectquery(query);
                cmbfiletype.ValueMember = "FType_ID";
                cmbfiletype.DisplayMember = "File_Type";
                cmbfiletype.SelectedIndex = -1;





                query = "select * from New_Buyer_Name WHERE sign= 0 order by Buyer_Name";

                cmbbuyer.DataSource = dc.selectquery(query);
                cmbbuyer.ValueMember = "Byrid";
                cmbbuyer.DisplayMember = "Buyer_Name";
                cmbbuyer.SelectedIndex = -1;



                query = "SELECT DISTINCT Menu_ShelfNo_Id From viewUserMSP WHERE UserId='" + Recordbook.Extra.call.UserInfo.Rows[0]["UserID"].ToString() + "' ORDER BY Menu_ShelfNo_Id ";

                cmbcabinet.DataSource = dc.selectquery(query);
                cmbcabinet.ValueMember = "Menu_ShelfNo_Id";
                cmbcabinet.DisplayMember = "Menu_ShelfNo_Id";
              
                cmbcabinet.SelectedIndex = -1;

                this.cmbcabinet.SelectedIndexChanged += new System.EventHandler(this.cmbcabinet_SelectedIndexChanged);
         
            }

            catch
            {
            }

        }


        //save korer jnno


        private void btnsave_Click(object sender, EventArgs e)
        {

            string strDeptShort = "";
            int intTNO;
            string sl = "";




            string psid = "";

            if (dgvItemEntry.RowCount <= 0)
            {
                MessageBox.Show("Record Not Found");
                btnadd.Focus();
            }






            foreach (DataGridViewRow row in dgvItemEntry.Rows)
            {




                try
                {

                   
                    if (btnsave.Text == "&Save")
                    {

                        DialogResult YesNO = MessageBox.Show("Do you want to save ?", "confirmation !", MessageBoxButtons.YesNo);
                        if (YesNO.ToString() == "Yes")
                        {




                            compid();


                            query = "SELECT DeptShortName FROM Dept_Name Where DeptName = '" + cmbdepartment.Text + "' ";

                            dt = dc.selectquery(query);

                            if (dt.Rows.Count > 0)
                            {
                                strDeptShort = dt.Rows[0]["DeptShortName"].ToString();
                            }
                            else
                            {
                                strDeptShort = "NF";
                            }

                            string squery = "SELECT Max(F_No) As F_NO FROM New_NFR Where CompId  = '" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' And Dept_Name = '" + cmbdepartment.Text + "' And F_Year = '" + Recordbook.Extra.call.Year + "' ";

                            dt = dc.selectquery(squery);


                            if ((dt.Rows.Count > 0) && ((dt.Rows[0]["F_NO"].ToString()) != ""))
                            {

                                {

                                    intTNO = int.Parse(dt.Rows[0]["F_NO"].ToString()) + 1;
                                }


                            }
                            else
                            {
                                intTNO = 1;
                            }




                            if ((intTNO > 0) && (intTNO < 10))
                            {
                                sl = "00000" + intTNO;
                            }
                            else if ((intTNO > 9) && (intTNO < 100))
                            {
                                sl = "0000" + intTNO;

                            }
                            else if ((intTNO > 99) && (intTNO < 1000))
                            {
                                sl = "000" + intTNO;

                            }
                            else if ((intTNO > 999) && (intTNO < 10000))
                            {
                                sl = "00" + intTNO;

                            }
                            else if ((intTNO > 9999) && (intTNO < 100000))
                            {
                                sl = "0" + intTNO;

                            }
                            else if ((intTNO > 99999) && (intTNO < 1000000))
                            {
                                sl = intTNO.ToString();
                            }


                            strNFR = comp + strDeptShort + sl + "-" + Recordbook.Extra.call.Year;


                            //-------------------------------------------------------------------




                            query = "SELECT PS_ID FROM new_Self_Position WHERE SELF_POSITION='" + row.Cells["File_Location"].Value.ToString() + "'";
                            dt = dc.selectquery(query);
                            if (dt.Rows.Count > 0)
                            {
                                psid = dt.Rows[0]["PS_ID"].ToString();
                            }



                            //------------------------------------------------------------------



                            string queryserch = "select * from New_NFR where File_Name='" + txtFileName.Text + "' and Vol_No='" + cmbvolum.Text + "'";
                            if (dc.selectquery(queryserch).Rows.Count > 0)
                            {
                                MessageBox.Show("This file already Exist");
                                return;
                            }



                            findMId(txtmid.Text);


                            string query1 = "INSERT INTO New_NFR (CompId, F_No, File_No, File_Name, Vol_No, Dept_Name, F_Year) values ('" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + sl + "','" + strNFR + "','" + row.Cells["File_Name"].Value.ToString() + "','" + row.Cells["VolumeNo"].Value.ToString() + "','" + row.Cells["Department"].Value.ToString() + "','" + Recordbook.Extra.call.Year + "')";

                            dc.nonselcetquery(query1);

                            FindFid(strNFR);

                            string query2 = "INSERT INTO File_Info_Main(CompId,F_ID,Pos_ID, Dept_ID, Type_ID, M_ID, Vol_ID, DeleteRow, EntryDate, EntryTime) VALUES ( '" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + intfileid + "','" + psid + "','" + row.Cells["Deptid"].Value.ToString() + "','" + row.Cells["FTypeid"].Value.ToString() + "','" + maintId + "','" + row.Cells["Volid"].Value.ToString() + "',0,'" + DateTime.Now.ToString("dd-MMM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "');";

                            dc.nonselcetquery(query2);


                            string query3 = "INSERT INTO File_Info_Sub(F_ID,File_Name,File_No,Byr_id,Start_Date,End_Date,F_Status,DeleteRow,User_Name,Com_Name) VALUES ('" + intfileid + "','" + row.Cells["File_Name"].Value.ToString() + "','" + strNFR + "','" + row.Cells["Byrid"].Value.ToString() + "','" + row.Cells["StartDate"].Value.ToString() + "','" + row.Cells["EndDate"].Value.ToString() + "',0,0,'" + Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString() + "','" + com.SysConfigInfo.Rows[0]["Comname"].ToString() + "')";
                            dc.nonselcetquery(query3);

                            MessageBox.Show("Data Successfually Save");
                            txtfileno.Text = strNFR;


                            refresh();
                        }
                    }
                    else
                    {
                        DialogResult YesN = MessageBox.Show("Do you want to Update ?", "confirmation !", MessageBoxButtons.YesNo);
                        if (YesN.ToString() == "Yes")
                        {

                            strNFR = txtfileno.Text;


                            query = "SELECT PS_ID FROM new_Self_Position WHERE SELF_POSITION='" + row.Cells["File_Location"].Value.ToString() + "'";
                            dt = dc.selectquery(query);
                            if (dt.Rows.Count > 0)
                            {
                                psid = dt.Rows[0]["PS_ID"].ToString();
                            }

                            FindFid(strNFR);
                            findMId(txtmid.Text);


                            query = "update File_Info_Main set deleterow=2 where F_ID='" + intfileid + "' and deleterow=0";
                            dc.selectquery(query);

                            query = "update File_Info_Sub set deleterow=2 where F_ID='" + intfileid + "' and deleterow=0";
                            dc.selectquery(query);

                            string query4 = "INSERT INTO File_Info_Main(CompId,F_ID,Pos_ID, Dept_ID, Type_ID, M_ID, Vol_ID, DeleteRow, EntryDate, EntryTime) VALUES ( '" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + intfileid + "','" + psid + "','" + row.Cells["Deptid"].Value.ToString() + "','" + row.Cells["FTypeid"].Value.ToString() + "','" + maintId + "','" + row.Cells["Volid"].Value.ToString() + "',0,'" + DateTime.Now.ToString("dd-MMM-yyyy") + "','" + DateTime.Now.ToString("hh:mm:ss") + "');";

                            dc.nonselcetquery(query4);


                            string query5 = "INSERT INTO File_Info_Sub(F_ID,File_Name,File_No,Byr_id,Start_Date,End_Date,F_Status,DeleteRow,User_Name,Com_Name) VALUES ('" + intfileid + "','" + row.Cells["File_Name"].Value.ToString() + "','" + strNFR + "','" + row.Cells["Byrid"].Value.ToString() + "','" + row.Cells["StartDate"].Value.ToString() + "','" + row.Cells["EndDate"].Value.ToString() + "',0,0,'" + Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString() + "','" + com.SysConfigInfo.Rows[0]["Comname"].ToString() + "')";
                            dc.nonselcetquery(query5);



                            MessageBox.Show("Data Successfully Update");

                            refresh();



                        }
                    }


                }


                catch
                {
                }
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                if (!chektext())
                {
                    return;
                }

             


                foreach (DataGridViewRow row in dgvItemEntry.Rows)
                {
                    if (row.Cells["File_Name"].Value.ToString() == txtFileName.Text)
                    {
                        MessageBox.Show("Already Added this File_Name !");
                        return;
                    }
                    if (row.Cells["File_No"].Value.ToString() == txtfileno.Text)
                    {
                        MessageBox.Show("Already Added this File_No !");
                        return;
                    }
                    if (row.Cells["VolumeNo"].Value.ToString() == cmbvolum.Text)
                    {
                        MessageBox.Show("Already Added this VolumeNo !");
                        return;
                    }


                }

                dgvItemEntry.Rows.Add(txtFileName.Text, txtfileno.Text, cmbfiletype.SelectedValue.ToString(), cmbfiletype.Text, cmbvolum.SelectedValue.ToString(), cmbvolum.Text, cmbdepartment.SelectedValue.ToString(), cmbdepartment.Text, cmbflocation.Text, txtsdat.Text, txtedat.Text, cmbbuyer.SelectedValue.ToString(), cmbbuyer.Text);
            }

            catch
            {

            }

        }

   
     

        private void txtmid_TextChanged(object sender, EventArgs e)
        {
           
            string abc;
           
                abc = txtmid.Text;
                Maintainercode(abc);
             

            
        }



        private void GETlocation()
        {

            
            string val = "";


            if (optleft.Checked == true)
            {
                val = "/L/";
                query = "select distinct Menu_ShelfPosition_Caption from viewUserMSP  where  Menu_ShelfNo_Id='" + cmbcabinet.Text + "' AND Menu_ShelfPosition_Caption LIKE '%" + val + "%' ";
               
            }
            else
            {
                val = "/R/";
                query = "select distinct Menu_ShelfPosition_Caption from viewUserMSP  where  Menu_ShelfNo_Id='" + cmbcabinet.Text + "' AND Menu_ShelfPosition_Caption LIKE '%" + val + "%' ";
             
               
            }
            cmbflocation.DataSource = dc.selectquery(query);
            cmbflocation.ValueMember = "Menu_ShelfPosition_Caption";
            cmbflocation.DisplayMember = "Menu_ShelfPosition_Caption";
            cmbflocation.Text = "";
            cmbflocation.SelectedIndex = -1;


        }

        private void cmbcabinet_SelectedIndexChanged(object sender, EventArgs e)
        {
            GETlocation();
        }

        private void optleft_CheckedChanged(object sender, EventArgs e)
        {
            GETlocation();
        }

        private void optright_CheckedChanged(object sender, EventArgs e)
        {
            GETlocation();
        }

    

        private void refresh()
        {

            txtFileName.Text = "";
            cmbdepartment.Text = "";
            cmbbuyer.Text = "";
            cmbcabinet.Text = "";
            cmbfiletype.Text = "";
            cmbvolum.Text = "";
            cmbflocation.Text = "";
            txtedat.Text = "";
            txtsdat.Text = "";
            txtname.Text = "";
            txtdesignation.Text = "";
            txtdepartment.Text = "";
            txtsection.Text = "";
            dgvItemEntry.Rows.Clear();
        }

        void FindFid(string fid)
        {

           query = "SELECT F_ID FROM new_NFR WHERE File_No='" + fid + "'";

            dt = dc.selectquery(query);

            if (dt.Rows.Count > 0)
            {
                intfileid = dt.Rows[0]["F_ID"].ToString();

            }

        }


        void findMId(string mid)
        {

            query = "SELECT MId FROM new_Maintainer_Name WHERE Mcode='" + mid + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                maintId = dt.Rows[0]["MId"].ToString();
            }


        }


       



        void Maintainercode( string mcode)
        {

            query = "select * from new_Maintainer_Name where Mcode='" + mcode + "'";

          if (dc.selectquery(query).Rows.Count > 0)
          {
              dt = dc.selectquery(query);
              txtname.Text = dt.Rows[0]["MName"].ToString();
              txtdesignation.Text = dt.Rows[0]["Designation"].ToString();
              txtdepartment.Text = dt.Rows[0]["Deparment"].ToString();
              txtsection.Text = dt.Rows[0]["Section"].ToString();
          }
        }

        void Maintainername(string mname)
        {

            string query1 = "select * from new_Maintainer_Name where MName='" + mname + "'";

            if (dc.selectquery(query1).Rows.Count > 0)
            {
                dt = dc.selectquery(query1);
                txtmid.Text = dt.Rows[0]["Mcode"].ToString();
                txtname.Text = dt.Rows[0]["MName"].ToString();
                txtdesignation.Text = dt.Rows[0]["Designation"].ToString();
                txtdepartment.Text = dt.Rows[0]["Deparment"].ToString();
                txtsection.Text = dt.Rows[0]["Section"].ToString();
            }
        }


        private void compid()
        {
            if (com.CompanyInfo.Rows[0]["CompID"].ToString() == "1")
            {
                comp = "PJL";

            }
            if (com.CompanyInfo.Rows[0]["CompID"].ToString() == "7")
            {
                comp = "UJL";

            }
            if (com.CompanyInfo.Rows[0]["CompID"].ToString() == "5")
            {
                comp = "J2L";

            }
            if (com.CompanyInfo.Rows[0]["CompID"].ToString() == "3")
            {
                comp = "PAL";

            }
        }

        private bool chektext()
         {
          
            if (txtmid.Text == "")
            {
                MessageBox.Show("Type Maintainer code");
                
                return false;

            }
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Type File Name");

                return false;
            }

            if (cmbvolum.SelectedIndex == -1)
            {
                MessageBox.Show("Select  File Volume No");

                return false;
            }

            if (cmbfiletype.Text == "")
            {
                MessageBox.Show("Select File Type");

                return false;
            }

            if (cmbbuyer.SelectedIndex == -1)
            {
                MessageBox.Show("Select Buyer Name ");

                return false;
            }

            if (cmbdepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Select Department");

                return false;
            }

            if (cmbflocation.Text == "") 
            {
                MessageBox.Show("Select file Location");

                return false;
            }

            if (txtsdat.Text == "")
            {
                MessageBox.Show("Type Start Date");

                return false;
            }
            if (txtedat.Text == "")
            {
                MessageBox.Show("Type End Date");

                return false;
            }

            return true;

        }

       

        private void txtfileno_TextChanged(object sender, EventArgs e)
        {
           


              query = "SELECT F_ID FROM new_NFR WHERE File_No='" + txtfileno.Text + "'";
            dt = dc.selectquery(query);

            if (dt.Rows.Count > 0)
            {
                intfileid = dt.Rows[0]["F_ID"].ToString();

            }




            string q = "select * from View_File_Details where F_ID ='" + intfileid + "' AND COMPID='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' AND F_ID<>0";
            if(dc.selectquery(q).Rows.Count>0)
            {
                dt = dc.selectquery(q);
                txtFileName.Text = dt.Rows[0]["File_Name"].ToString();
                cmbvolum.Text = dt.Rows[0]["VOLUME_NO"].ToString();
                cmbfiletype.Text = dt.Rows[0]["File_Type"].ToString();
                cmbbuyer.Text = dt.Rows[0]["Buyer_Name"].ToString();
                cmbdepartment.Text = dt.Rows[0]["DeptName"].ToString();
                cmbflocation.Text = dt.Rows[0]["SELF_POSITION"].ToString();
                txtsdat.Text = dt.Rows[0]["Start_Date"].ToString();
                txtedat.Text = dt.Rows[0]["End_Date"].ToString();
                string sss = dt.Rows[0]["MName"].ToString();
                Maintainername(sss);
                
            }
        }

     

      

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!chektext())
            {
                return;
            }
            DialogResult YesNO = MessageBox.Show("Do you want to Delete ?", "confirmation !", MessageBoxButtons.YesNo);
            if (YesNO.ToString() == "Yes")
            {
                strNFR = txtfileno.Text;

                FindFid(strNFR);
                query = "update File_Info_Main set deleterow=1 where F_ID='" + intfileid + "' and deleterow=0";
                dc.nonselcetquery(query);
                query = "update File_Info_sub set deleterow=1 where F_ID='" + intfileid + "' and deleterow=0";
                dc.nonselcetquery(query);
                MessageBox.Show("Transaction  successfully Deleted");

                refresh();
                txtfileno.Text = "";
                txtmid.Text = "";
            }
        }

      

        private void btnnew_Click(object sender, EventArgs e)
        {

            btndelete.Enabled = false;
            refresh();

            if (btnnew.Text == "Edit")
            {
               
                optleft.Checked = false;
                optright.Checked = false;
                btnnew.Text = "&New";
                btnsave.Text = "&Save";
                txtfileno.Enabled = false;
                txtfileno.Text = "";
                txtmid.Text = "";
                refresh();
                txtmid.Focus();


            }
            else
            {

                optleft.Checked = false;
                optright.Checked = false;
                btndelete.Enabled = true;
                btnsave.Text = "&Update";
                btnnew.Text = "Edit";
                txtfileno.Enabled = true;
                txtfileno.Focus();

            }

        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (txtfileno.Text == "")
            {
                MessageBox.Show("Type File No");
                return;
            }
            ReportViwer RP;
            DataTable dt = new DataTable();
            string Reportname = "";

            query = "Select * from View_File_Details Where compId = '" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' and File_No='" + txtfileno.Text + "'";
            //dc.selectquery(query);
            dt = dc.selectquery(query);
            RP = new ReportViwer("File Details", dt);
            RP.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsdat_Leave(object sender, EventArgs e)
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

        private void txtedat_Leave(object sender, EventArgs e)
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

        public void keyDownNext(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbvolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbfiletype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbbuyer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbdepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbcabinet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void cmbflocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void txtsdat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }

        private void txtedat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);
        }


        
    }
}
