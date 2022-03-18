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
    public partial class frmNewFileType : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        string value = "";

        DataGridViewRow rowuser;

        public frmNewFileType()
        {
            InitializeComponent();
        }

        private void frmNewFileType_Load(object sender, EventArgs e)
        {
            btnnew.Text = "New";
            btnsave.Text = "Save";
            btndelete.Enabled = false;


            try
            {
                string squery = "SELECT * FROM  new_File_Type WHERE sign= 0";

                dgv_fileinfo.DataSource = dc.selectquery(squery);
                dgv_fileinfo.Columns["FType_ID"].Visible = false;
                dgv_fileinfo.Columns["sign"].Visible = false;
                dgv_fileinfo.Columns[1].Width = 150;

            }

            catch
            {

            }


        }

        //private void Close_Click(object sender, EventArgs e)
        //{
          
        //    }
        

        //private void btnnew_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{
           
        //}

        private void dgv_fileinfo_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            btnsave.Text = "&Update";
            btnnew.Text = "Edit";
            btndelete.Enabled = true;

            int rowindex = e.RowIndex;
            rowuser = dgv_fileinfo.Rows[rowindex];
            txtfile.Text = rowuser.Cells["File_Type"].Value.ToString();

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            txtfile.Text = "";
            if (btnnew.Text == "Edit")
            {
                btnnew.Text = "&New";
                btnsave.Text = "&Save";

            }
            else
            {
                btnsave.Text = "&Update";
                btnnew.Text = "Edit";


            }
        }

        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfile.Text == "")
            {
                MessageBox.Show("Type File_Type");
                txtfile.Focus();
                return;

            }

            if (btnsave.Text == "Save")
            {



                try
                {
                    string squery = "SELECT * FROM  new_File_Type WHERE File_Type= '" + txtfile.Text + "' AND sign= 0 ";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }

                    else
                    {


                        string query = "INSERT INTO new_File_Type(File_Type) VALUES ('" + txtfile.Text + "')";

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

                            txtfile.Text = "";
                            txtfile.Focus();

                        }

                    }

                }




                catch
                {

                }



            }
            else
            {
                if (txtfile.Text == "")
                {
                    MessageBox.Show("Type File_Type ");
                    txtfile.Focus();
                    return;
                }

                try
                {
                    string squery = "SELECT * FROM  new_File_Type WHERE File_Type= '" + txtfile.Text + "' AND sign= 0";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }


                    string query = "Update new_File_Type set File_Type='" + txtfile.Text + "' where File_Type= '" + rowuser.Cells["File_Type"].Value.ToString() + "'";

                    DialogResult YesNO = MessageBox.Show("Do you want to Update ?", "confirmation !", MessageBoxButtons.YesNo);
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

                        txtfile.Text = "";
                        txtfile.Focus();

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
                string squery = "update   new_File_Type set sign=1 WHERE File_Type= '" + txtfile.Text + "'";

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

                    txtfile.Text = "";
                    txtfile.Focus();
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

}  
    
}
