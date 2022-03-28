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
    public partial class frmRptDateInvoice : Form
    {


        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        string value = "";
       
        DataGridViewRow rowuser;
        DataTable dt = null;
        string Query;
       


        public frmRptDateInvoice()
        {
            InitializeComponent();
        }


        


        private void RptDateInvoice_Load(object sender, EventArgs e)
        {
         

        }



        private void dgv_volumeinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_volumeinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
         
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilename.Text == "")
                {
                    MessageBox.Show("Fillup File No");
                    txtFilename.Focus();
                    return ;
                }

                foreach (DataGridViewRow row in dgv_invoiceinfo.Rows)
                {
                    if (row.Cells["File_No"].Value.ToString() == txtFilename.Text)
                    {
                        MessageBox.Show("Already Added this File_No !");
                        return;
                    }
                }
               

                dgv_invoiceinfo.Rows.Add(txtFilename.Text);
                txtFilename.Text = "";
                txtFilename.Focus();
            }
            catch
            {
            }


          
        }

        private DataTable previewdata()
        {
            try
            {
                string query;
                query = "Select * from View_File_Details";
                query = query + " Where File_No IN (";

                foreach (DataGridViewRow row in dgv_invoiceinfo.Rows)
                {
                    query = query + " '" + row.Cells["File_No"].Value.ToString() + "',";

                }


                query = query.Substring(0, query.Length - 1);
                query = query + " )" + " ORDER BY File_No";


                //'" + row1.Cells["File_No"].Value.ToString() + "' ORDER BY File_No";
                dt = dc.selectquery(query);
   
            }

            catch
            {
            }
            return dt;
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (dgv_invoiceinfo.RowCount == 0)
            {
                MessageBox.Show("Data Not Found");
                
                return;

            }

            ReportViwer RP;
            DataTable dt = new DataTable();
            dt = previewdata();
            RP = new ReportViwer("File Details", dt);
            RP.Show();
        }

      

        public void keyDownNext(object sender, KeyEventArgs e)
        {
          
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
           
        }

     
        private void txtFilename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.keyDownNext(sender, e);
            }
        }

        }

       
    }


