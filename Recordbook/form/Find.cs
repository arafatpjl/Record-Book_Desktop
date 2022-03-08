using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Recordbook.form
{
     

       
       
    class Find
    {
        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        DataTable dt = null;
   
        string query = "";
        string carriercode = "";
        string carrierid = "";
        string ReceiverCODE = "";
        string Receiverid = "";
        string VOLUMENO = "";
        string FTypeID = "";
        string SELFPOSITION = "";
        string Byrname = "";
        string deptname = "";
        string Trnsid = "";
        string fileid = "";
        string FTrnsid = "";

    

        public string  findvol_name(string  VID)
        {

            query = "SELECT VOLUME_NO FROM new_Volume_No WHERE V_ID='" + VID + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                VOLUMENO = dt.Rows[0]["VOLUME_NO"].ToString();
               
            }
            return VOLUMENO;
        }


        public string findShelfPostion(string PID)
        {

            query = "SELECT SELF_POSITION FROM new_Self_Position WHERE PS_ID='" + PID + "'";
             dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                SELFPOSITION = dt.Rows[0]["SELF_POSITION"].ToString();

            }
            return SELFPOSITION;
        }


        public string findFile_Type(string FTID)
        {

            query = "SELECT File_Type FROM new_File_Type WHERE FType_ID='" + FTID + "'";
             dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                FTypeID = dt.Rows[0]["File_Type"].ToString();

            }
            return FTypeID;
        }


        public string bUYER_NAME(string BYRID)
        {

            query = "SELECT Buyer_Name from New_Buyer_Name WHERE byrid='" + BYRID + "'";
             dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                Byrname = dt.Rows[0]["Buyer_Name"].ToString();

            }
            return Byrname;
        }

        public string findCarrierCode(string carriercode)
        {

            query = "SELECT Empcode FROM InfoEmp WHERE EMPID='" + carriercode + "' and compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                carriercode = dt.Rows[0]["Empcode"].ToString();

            }
            return carriercode;
        }

        public string findCarrierid(string carrierID)
        {

            query = "SELECT EMPID FROM InfoEmp WHERE Empcode='" + carrierID + "' and compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                carrierid = dt.Rows[0]["EMPID"].ToString();

            }
            return carrierid;
        }


        public string findReceiverCode(string ReciverCODE)
        {

            query = "SELECT Empcode FROM InfoEmp WHERE EMPID='" + ReciverCODE + "' and compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
             dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                ReceiverCODE = dt.Rows[0]["Empcode"].ToString();

            }
            return ReceiverCODE;
        }

        public string findReceiverID(string ReciverID)
        {

            query = "SELECT EMPID FROM InfoEmp WHERE Empcode='" + ReciverID + "' and compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                Receiverid = dt.Rows[0]["EMPID"].ToString();

            }
            return Receiverid;
        }


        public string findDept(string fdepid)
        {

            query = "SELECT Dept_Name from New_NFR WHERE File_No='" + fdepid + "'";
            dt = dc.selectquery(query);
            if (dt.Rows.Count > 0)
            {
                deptname = dt.Rows[0]["Dept_Name"].ToString();

            }
            return deptname;
        }

        public string findtransId(string tid)
        {

            query = "SELECT T_ID FROM new_TransNo WHERE Trans_No='" + tid + "'";

            dt = dc.selectquery(query);

            if (dt.Rows.Count > 0)
            {
                Trnsid = dt.Rows[0]["T_ID"].ToString();

            }
            return Trnsid;
        }


        public string findFId(string fid)
        {

            query = "SELECT F_ID FROM New_NFR WHERE File_No='" + fid + "'";

            dt = dc.selectquery(query);

            if (dt.Rows.Count > 0)
            {
                fileid = dt.Rows[0]["F_ID"].ToString();

            }
            return fileid;
        }



        public string findftransId(string Ftid)
        {
            
            query = "SELECT File_ID FROM new_File_Transaction WHERE Trans_ID='" + Ftid + "'";

            dt = dc.selectquery(query);

            if (dt.Rows.Count > 0)
            {
                FTrnsid = dt.Rows[0]["File_ID"].ToString();

            }
            return FTrnsid;
        }

        private void txtDate(object sender, EventArgs e)
        {
            var myTxt = (TextBox)sender;

            string date = myTxt.Text;
            if (date.Length < 6)
                MessageBox.Show("Invalid Date.Please 6 digit");
            else if (date.Length == 6)
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


        //void Maintainercode(string mcode)
        //{

        //    query = "select * from new_Maintainer_Name where Mcode='" + mcode + "'";

        //    if (dc.selectquery(query).Rows.Count > 0)
        //    {
        //        dt = dc.selectquery(query);
            
        //    }
        //}

        //void Maintainername(string mname)
        //{

        //    string query1 = "select * from new_Maintainer_Name where MName='" + mname + "'";

        //    if (dc.selectquery(query1).Rows.Count > 0)
        //    {
        //        dt = dc.selectquery(query1);
               
        //    }
        //}

       
    }
}
