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
    public partial class frmmenu : Form
    {
        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        MenuStrip menu = new MenuStrip();
        ToolStripMenuItem item = new ToolStripMenuItem();

        public frmmenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
            Companyname.Text = com.CompanyInfo.Rows[0]["CompName"].ToString();
            lblcompaddress.Text = com.CompanyInfo.Rows[0]["CompAdd"].ToString();
            lbluser.Text = Recordbook.Extra.call.UserInfo.Rows[0]["UserName"].ToString();

            //Menu Disiable

            MNUHouseKeeping.Visible = false;
            mnudataentry.Visible = false;
            nuReports.Visible = false;
            mnuothers.Visible = false;
            exitToolStripMenuItem.Visible = false;


            // Sub Menu Disiable

            newVolumeNoToolStripMenuItem.Visible = false;
            newMaintainerToolStripMenuItem.Visible = false;
            newFileTypeToolStripMenuItem.Visible = false;
            newBuyerNameToolStripMenuItem.Visible = false;
            fileSearchToolStripMenuItem.Visible = false;
            newPositionToolStripMenuItem.Visible = false;
            newFileEntryToolStripMenuItem.Visible = false;
            newFileTransactionToolStripMenuItem.Visible = false;
            fileReturnTransactionToolStripMenuItem.Visible = false;
            searchingToolStripMenuItem.Visible = false;
            recordDeatilsToolStripMenuItem.Visible = false;
            transactionToolStripMenuItem.Visible = false;
            userControlToolStripMenuItem.Visible = false;
            fileInvoiceToolStripMenuItem.Visible = false;
            extraFileInvoiceToolStripMenuItem.Visible = false;


            //Menu Active

            DataTable dtuser = Recordbook.Extra.call.UserInfo;
            try
            {
                string userQuery = @"SELECT *
                              FROM [tblMenuWin] where [Id] in (" + dtuser.Rows[0]["Menu_id"] + ") and YsnActive='1'";

                DataTable dtMain = dc.selectquery(userQuery);



                foreach (DataRow dr in dtMain.Rows)
                {
                   

                    item.Name = dr["FrmForm_Name"].ToString();
                    menuStrip2.Items[item.Name].Visible = true;
                    InitSubMenuItem(menuStrip2.Items[item.Name]);
                    
                }

                
            }
            catch
            {
            }

        }


        //Sub Menu Active

        private void InitSubMenuItem(ToolStripItem item)
        {
            string mname = item.Name;

            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            DataTable dtuser = Recordbook.Extra.call.UserInfo;

            string sql = "select * from tblMenuWin where FrmForm_Name = '" + mname + "' and [Id] in (" + dtuser.Rows[0]["Menu_id"] + ") and YsnActive='1' and FrmMenu_Name is not null   ";

            DataTable dt = dc.selectquery(sql);

            if (dt.Rows.Count != 0)
            {

                foreach (DataRow dr in dt.Rows)
                {
                    ToolStripMenuItem subItem = new ToolStripMenuItem();

                    subItem.Name = dr["FrmMenu_Name"].ToString();
                    try
                    {
                        pItem.DropDownItems[subItem.Name].Visible = true;
                        

                    }
                    catch 
                    {
                   
                    }
                }
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newVolumeNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Recordbook.form.frmNewVolume shw = new form.frmNewVolume ();
            shw.ShowDialog();
        }

        private void newMaintainerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Recordbook.form.frmNewMaintainer shw = new form.frmNewMaintainer();
            shw.ShowDialog();  

        }

       

        private void newFileTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Recordbook.form.frmNewFileType shw = new form.frmNewFileType();
            shw.ShowDialog();
        }

        private void newBuyerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmBuyerName shw = new form.frmBuyerName();
            shw.ShowDialog();

        }

        private void fileSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmSearching shw = new form.frmSearching();
            shw.ShowDialog();

        }

        private void newPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           Recordbook.form.frmNewPosition shw = new form.frmNewPosition();
            shw.ShowDialog();
        }

        private void newFileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmfileEntry shw = new form.frmfileEntry();
            shw.ShowDialog();
        }

        private void frmmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void newFileTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmtransaction shw = new form.frmtransaction();
            shw.ShowDialog();
        }

        private void fileReturnTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmTransactionReturn shw = new form.frmTransactionReturn();
            shw.ShowDialog();
        }

        private void searchingToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Recordbook.form.frmrptWholeSearching shw = new form.frmrptWholeSearching();
            shw.ShowDialog();
            
        }

        private void recordDeatilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmRptRecordDetails shw = new form.frmRptRecordDetails();
            shw.ShowDialog();
            
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Recordbook.form.frmRptTransaction shw = new form.frmRptTransaction();
            shw.ShowDialog();
        }

        private void userControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frm_user_information shw = new form.frm_user_information();
            shw.ShowDialog();

        }

        private void fileInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmRptInavoice shw = new form.frmRptInavoice();
            shw.ShowDialog();
        }

       

        private void extraFileInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recordbook.form.frmRptDateInvoice shw = new form.frmRptDateInvoice();
            shw.ShowDialog();

        }
        private void lbllog_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Recordbook.frmsplash shw = new frmsplash();
            shw.ShowDialog();
            //new frmlogin().Show();
        }
        


      
    }
}
