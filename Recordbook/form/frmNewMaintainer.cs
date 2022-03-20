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
    public partial class frmNewMaintainer : Form
    {


        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        DataTable dt = null;
        string query = "";


        public frmNewMaintainer()
        {
            InitializeComponent();
        }


        private void frmNewMaintainer_Load(object sender, EventArgs e)
        {

        }

        private void txtitemname_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string squery = "SELECT * FROM  new_Maintainer_Name WHERE Mcode= '" + txtempcode.Text + "' ";

                dc.selectquery(squery);

                if (dc.selectquery(squery).Rows.Count > 0)
                {
                    MessageBox.Show("Data Already saved");
                    return;
                }
                else
                {
                    string query = "SELECT * FROM  InfoEmp WHERE Empcode= '" + txtempcode.Text + "' and Compid='" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "'  ";

                    if (dc.selectquery(query).Rows.Count > 0)
                    {
                        dt = dc.selectquery(query);
                        txtempname.Text = dt.Rows[0]["Empname"].ToString();
                        txtdesignation.Text = dt.Rows[0]["Designation"].ToString();
                        txtdept.Text = dt.Rows[0]["Department"].ToString();
                        txtsection.Text = dt.Rows[0]["section"].ToString();
                    }

                }
             

            }

            catch
            {

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtempcode.TextLength == 0)
                {
                    MessageBox.Show("Type EmployeeCode");
                }


                query = "INSERT INTO new_Maintainer_Name (CompId, Mcode, MName, Designation, Deparment,section) VALUES('" + com.CompanyInfo.Rows[0]["CompID"].ToString() + "','" + txtempcode.Text + "','" + txtempname.Text + "','" + txtdesignation.Text + "','" + txtdept.Text + "','" + txtsection.Text + "')";
               
                
                DialogResult YesNO = MessageBox.Show("Do you want to save ?", "confirmation !", MessageBoxButtons.YesNo);
                if (YesNO.ToString() == "Yes")
                {

                    if (dc.nonselcetquery(query))
                    {
                        MessageBox.Show("DataSaved Successfully", "confirmation !");
                    }
                    else
                    {
                        MessageBox.Show("Operation failed", "confirmation !");
                    }

                    //txtfile.Text = "";
                    //txtfile.Focus();

                    txtempname.Text = "";
                    txtdesignation.Text = "";
                    txtdept.Text = "";
                    txtsection.Text = "";
                    txtempcode.Text = "";

                }
            }
            catch
            {
            }
        }

       

    }
}
