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
    public partial class frmNewPosition : Form
    {

        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();

        string strp;
        string strposition;
        string Optside;


        public frmNewPosition()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnsave_Click(object sender, EventArgs e)
        // {

        //    

           
        //}

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtSELFNOFROM.Text == "")
            {
                MessageBox.Show("Type Cabinet No");
            }
            if (btnsave.Text == "&Save")
            {
                int intsf = int.Parse(txtSELFNOFROM.Text);
                int intst = int.Parse(txtShelfNoTo.Text);


                string query = "";
                if (OptL.Visible == true)
                {
                    Optside = "L";
                }
                else
                {
                    Optside = "R";
                }
                DialogResult YesNO = MessageBox.Show("Do you want to save ?", "confirmation !", MessageBoxButtons.YesNo);
                //if (YesNO.ToString() == "Yes")
                for (int i = intsf; i <= intst; i++)
                {
                    if ((i > 0) && (i < 10))
                    {
                        strp = "CBT" + "00" + i;
                    }
                    else
                    {
                        strp = "CBT" + "0" + i;
                    }

                    for (int j = 1; j <= 3; j++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            strposition = strp + "/" + Optside + "/" + "C" + j + "/" + "R" + k;

                            try
                            {
                                query = query + "INSERT INTO new_Self_Position (SELF_NO,SELF_SIDE,SELF_ROW_NO,SELF_COLUMN_NO,SELF_POSITION,DeleteRow,UserName,ComName,EntryDate,EntryTime) VALUES('" + i + "','" + Optside + "','" + j + "','" + k + "','" + strposition + "',0, ' " + Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString() + "','" + com.SysConfigInfo.Rows[0]["ComName"].ToString() + "','" + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss") + "','" + DateTime.Now.ToString("hh:mm:ss") + "')";
                                dc.selectquery(query);

                            }

                            catch
                            {

                            }
                        }
                    }
                }

                dc.nonselcetquery(query);
                MessageBox.Show("Data Insert Successfually");

            }
                 
            

        }

        

       
    }
}
