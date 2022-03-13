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
    public partial class frmBuyerName : Form
    {


        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();



        string value = "";

        DataGridViewRow rowuser;

        public frmBuyerName()
        {
            InitializeComponent();
        }

        private void frmBuyerName_Load(object sender, EventArgs e)
        {


            btnnew.Text = "New";
            btnsave.Text = "Save";
            btndelete.Enabled = false;




            try
            {
                string squery = "SELECT * FROM  New_Buyer_Name WHERE sign= 0 ";

                dgv_Buyerinfo.DataSource = dc.selectquery(squery);
                dgv_Buyerinfo.Columns["Byrid"].Visible = false;
                dgv_Buyerinfo.Columns["sign"].Visible = false;
                dgv_Buyerinfo.Columns[1].Width = 150;

            }

            catch
            {

            }

        }


       

        //private void btnnew_Click(object sender, EventArgs e)
        //{
       
        //}

        private void dgv_Buyerinfo_cell(object sender, DataGridViewCellEventArgs e)
        {
            btnsave.Text = "&Update";
            btnnew.Text = "Edit";
            btndelete.Enabled = true;

            int rowindex = e.RowIndex;
            rowuser = dgv_Buyerinfo.Rows[rowindex];
            txtbuyer.Text = rowuser.Cells["Buyer_Name"].Value.ToString();
        }



        //private void btndelete_Click(object sender, EventArgs e)
        //{


        
        //}

        private void dgv_Buyerinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtbuyer.Text == "")
            {
                MessageBox.Show("Type Volume No");
                txtbuyer.Focus();
                return;
            }
            if (btnsave.Text == "Save")
            {



                try
                {
                    string squery = "SELECT * FROM  New_Buyer_Name WHERE Buyer_Name= '" + txtbuyer.Text + "' and sign= 0 ";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }

                    else
                    {


                        string query = "INSERT INTO New_Buyer_Name(Buyer_Name) VALUES ('" + txtbuyer.Text + "')";

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

                            txtbuyer.Text = "";
                            txtbuyer.Focus();

                        }

                    }

                }



                catch
                {

                }
            }


            else
            {
                if (txtbuyer.Text == "")
                {
                    MessageBox.Show("Type Volume No");
                    txtbuyer.Focus();
                    return;
                }

                try
                {
                    string squery = "SELECT * FROM  New_Buyer_Name WHERE Buyer_Name= '" + txtbuyer.Text + "' and sign= 0 ";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }


                    string query = "Update New_Buyer_Name set Buyer_Name='" + txtbuyer.Text + "' where Buyer_Name= '" + rowuser.Cells["Buyer_Name"].Value.ToString() + "'";

                    DialogResult YesNO = MessageBox.Show("Do you want to Upadte ?", "confirmation !", MessageBoxButtons.YesNo);
                    if (YesNO.ToString() == "Yes")
                    {

                        if (dc.nonselcetquery(query))
                        {
                            MessageBox.Show("DataUpdate Successfully", "confirmation !");
                        }
                        else
                        {
                            MessageBox.Show("Operation failed", "confirmation !");
                        }

                        txtbuyer.Text = "";
                        txtbuyer.Focus();

                    }
                }



                catch
                {

                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                string squery = "update   New_Buyer_Name set sign=1 WHERE Buyer_Name= '" + txtbuyer.Text + "'";

                DialogResult YesNO = MessageBox.Show("Do you want to Delete ?", "confirmation !", MessageBoxButtons.YesNo);
                if (YesNO.ToString() == "Yes")
                {
                    if (dc.nonselcetquery(squery))
                    {
                        MessageBox.Show("DataDelete Successfully", "confirmation !");
                    }
                    else
                    {
                        MessageBox.Show("Operation failed", "confirmation !");
                    }

                    txtbuyer.Text = "";
                    txtbuyer.Focus();
                }


            }




            catch
            {

            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            txtbuyer.Text = "";
            if (btnnew.Text == "Edit")
            {
                btnnew.Text = "New";
                btnsave.Text = "Save";

            }
            else
            {
                btnsave.Text = "&Update";
                btnnew.Text = "Edit";


            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
