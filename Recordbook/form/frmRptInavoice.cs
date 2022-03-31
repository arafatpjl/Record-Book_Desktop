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
    public partial class frmRptInavoice : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        string query = "";
        DataTable dt;

     


        public frmRptInavoice()
        {
            InitializeComponent();
        }

      
       

        private DataTable previewdata()
        {
            
                query = "Select * from View_File_Details Where (EntryDate Between '"
                    + txtfromDate.Text + "' and '" + txtToDate.Text + "') and compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "' ORDER BY File_No";
                dt = dc.selectquery(query);

            
            return dt;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (txtfromDate.Text.Length == 0)
            {
                MessageBox.Show("Type From Date");
                txtfromDate.Focus();
                return;
            }
            if (txtToDate.Text.Length == 0)
            {
                MessageBox.Show("Type To Date");
                txtToDate.Focus();
                return;
            }

            ReportViwer RP;
            DataTable dt = new DataTable();
            dt = previewdata();
            RP = new ReportViwer("File Details", dt);
            RP.Show();
        }

        private void txtfromDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtToDate_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtfromDate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtToDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            this.keyDownNext(sender, e);

        }

        private void txtfromDate_Leave(object sender, EventArgs e)
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

        private void txtToDate_Leave(object sender, EventArgs e)
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

        private void frmRptInavoice_Load(object sender, EventArgs e)
        {

        }
           

    }


 }
    

