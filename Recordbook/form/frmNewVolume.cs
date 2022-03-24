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
    public partial class frmNewVolume : Form
    {


        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        string value = "";
       
        DataGridViewRow rowuser;

       


        public frmNewVolume()
        {
            InitializeComponent();
        }


        


        private void frmNewVolume_Load(object sender, EventArgs e)
        {
            btnnew.Text = "New";
            btnsave.Text = "Save";
            btndelete.Enabled = false;
           

         

            try
            {
               string squery = "SELECT * FROM  new_Volume_No WHERE sign= 0 ORDER BY VOLUME_NO ";

               dgv_volumeinfo.DataSource= dc.selectquery(squery);
               dgv_volumeinfo.Columns["v_ID"].Visible = false;
               dgv_volumeinfo.Columns["sign"].Visible = false;
               dgv_volumeinfo.Columns[1].Width = 150;

            }

            catch
            {

            }
        }


        // save korer jnno
       

      



        //public string ne { get; set; }


        //Grid Table e Data Add Krer Jnno

        private void dgv_volumeinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsave.Text = "&Update";
            btnnew.Text = "Edit";
            btndelete.Enabled = true;
            
            int rowindex = e.RowIndex;
            rowuser = dgv_volumeinfo.Rows[rowindex];
            txtitemname.Text = rowuser.Cells["VOLUME_NO"].Value.ToString();

        }

      

       

       

      
        //// Form close Krer Jnno
        //private void Close_Click(object sender, EventArgs e)
        //{
           
        //}

    // Delete Krer Jnno

        

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
            try
            {
                string squery = "update   new_Volume_No set sign=1 WHERE VOLUME_NO= '" + txtitemname.Text + "'";

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

                    txtitemname.Text = "";
                    txtitemname.Focus();
                }


            }




            catch
            {

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtitemname.Text == "")
            {
                MessageBox.Show("Type Volume No");
                txtitemname.Focus();
                return;
            }
            if (btnsave.Text == "Save")
            {
                if (txtitemname.TextLength > 0)



                    value = "VOL." + " - " + txtitemname.Text;


                try
                {
                    string squery = "SELECT * FROM  new_Volume_No WHERE VOLUME_NO= '" + value + "' AND sign= 0";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }

                    else
                    {


                        string query = "INSERT INTO new_Volume_No(VOLUME_NO) VALUES ('" + value + "')";

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

                            txtitemname.Text = "";
                            txtitemname.Focus();

                        }

                    }

                }



                catch
                {

                }

            }
            else
            {
                if (txtitemname.Text == "")
                {
                    MessageBox.Show("Type Volume No");
                    txtitemname.Focus();
                    return;
                }

                try
                {
                    string squery = "SELECT * FROM  new_Volume_No WHERE VOLUME_NO= '" + txtitemname.Text + "' AND sign= 0";

                    dc.selectquery(squery);

                    if (dc.selectquery(squery).Rows.Count > 0)
                    {
                        MessageBox.Show("Duplicate File Type");
                        return;
                    }


                    string query = "Update new_Volume_No set VOLUME_NO='" + txtitemname.Text + "' where VOLUME_NO= '" + rowuser.Cells["VOLUME_NO"].Value.ToString() + "'";

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

                        txtitemname.Text = "";
                        txtitemname.Focus();

                    }
                }



                catch
                {

                }
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            txtitemname.Text = "";
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

        }

       
    }


