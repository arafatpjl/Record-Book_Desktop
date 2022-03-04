using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Runtime.InteropServices;

namespace Recordbook
{
    public partial class frmsplash : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        public frmsplash()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmsplash_Load(object sender, EventArgs e)
        {
            try
            {
                string com_name = "";

                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\cimv2",
                        "select * from Win32_ComputerSystem");

                foreach (ManagementObject queryobject in searcher.Get())
                {
                    com_name = queryobject["name"].ToString();
                }


                string drives = @"C:\";
                string VolumeSerialID = com.GetVolumeInformation(drives, sender, e);
                string Enc_VolumeSerialID = com.EncryptIt(VolumeSerialID, 11);

                string SelectConfig = @"SELECT [IDNo]
                                              ,[ComVolumn]
                                              ,[ComName]
                                              ,[ComId]
                                             
           
                                   FROM [Sys_Configure_Status] WHERE ComName='" + com_name + "' and ComVolumn='" + Enc_VolumeSerialID + "'";


                DataTable dtconfig = dc.selectquery(SelectConfig);

                if (dtconfig.Rows.Count > 0)
                {
                    com.SysConfigInfo = dtconfig;

                }

                else
                {
                    MessageBox.Show("Your Connection is not Valid. Plese Contact Software Vendor..");
                    Application.Exit(); 

                }

                string SelectComp = @"  SELECT * FROM [Company_Information] WHERE CompID in (" + dtconfig.Rows[0]["ComId"] + ")";


                DataTable dtCompInfo = dc.selectquery(SelectComp);


                if (dtCompInfo != null)
                {
                    com.CompanyInfo = dtCompInfo;
                }

                else
                {

                    MessageBox.Show("Your have No company permission. Plese Contact Software Vendor..");
                    Application.Exit();
                }

                for (int i = 0; i < dtCompInfo.Rows.Count; i++)
                {

                    if (dtCompInfo.Rows[i]["CompID"].ToString() == "1")
                    {
                        IBLPJL.Enabled = true;
                    }
                    if (dtCompInfo.Rows[i]["CompID"].ToString() == "7")
                    {
                        IBLUJL.Enabled = true;
                    }
                    if (dtCompInfo.Rows[i]["CompID"].ToString() == "5")
                    {
                        IBLJ2L.Enabled = true;
                    }
                    if (dtCompInfo.Rows[i]["CompID"].ToString() == "3")
                    {
                        IBLPAL.Enabled = true;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        
        

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        





        private void IBLUJL_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            Recordbook.Extra.call.Year = (txtyear.Text);



            com.CompanyInfo = com.FilterDatatableEqual(com.CompanyInfo, "CompID", "7");
            //Recordbook.Extra.call.CompidInfo.Columns["UJL"].ColumnName = "ComId";

          
            Recordbook.frmlogin shw = new frmlogin();
            shw.ShowDialog();


            
        }

        private void IBLPJL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recordbook.Extra.call.Year = (txtyear.Text);


            com.CompanyInfo = com.FilterDatatableEqual(com.CompanyInfo, "CompID", "1");

            Recordbook.frmlogin shw = new frmlogin();
             shw.ShowDialog();

        }

       

        private void IBLJ2L_Click(object sender, EventArgs e)
        {

            this.Hide();
            Recordbook.Extra.call.Year = (txtyear.Text);


            com.CompanyInfo = com.FilterDatatableEqual(com.CompanyInfo, "CompID", "5");

            Recordbook.frmlogin shw = new frmlogin();
            shw.ShowDialog();

        }

        private void IBLPAL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recordbook.Extra.call.Year = (txtyear.Text);


            com.CompanyInfo = com.FilterDatatableEqual(com.CompanyInfo, "CompID", "3");

            Recordbook.frmlogin shw = new frmlogin();
            shw.ShowDialog();

        }

        private void IBLPJL_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //    frmlogin frm = new frmlogin();
        //    progressBar1.Visible = true;

        //    this.progressBar1.Value = this.progressBar1.Value + 2;
        //  if (this.progressBar1.Value == 100)
        //    {
        //        //frm.Show();
        //        timer1.Enabled = false;
        //        Application.Exit();

                
        //    }

        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}


       
//    }
//}
