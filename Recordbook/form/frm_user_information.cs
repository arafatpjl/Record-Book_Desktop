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
    public partial class frm_user_information : Form
    {
        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();    


       
        string user="";
        string user_name="";
        string Menu_ID = "";

        string dgvdata = @"SELECT [CompId]
                                  ,[UserID]
                                  ,[UserName]
                                  ,[Empcode]
                                  ,[UserPWord]
                                  ,[UserStatus]
                                  
                                  ,[Menu_id]
                                  ,[YsnActive]
                                  ,[last_login_date]
                                  ,[last_login_Mac]
                                  ,[Created_date]
                                  ,[Created_By]
                                  ,[Updated_date]
                                  ,[Updated_by]
                              FROM [Sys_User_Name] where YsnActive= '1' and CompId= '"
                            + Recordbook.Extra.call.UserInfo.Rows[0]["CompId"].ToString() + "'";

        DataGridViewRow rowUser;

        DataTable dtMain = new DataTable();

        public frm_user_information()
        {
          
            InitializeComponent();
        }

  

        private void frm_user_information_Load(object sender, EventArgs e)
        {
            try
            {


                dgv_userinfo.DataSource = dc.selectquery(dgvdata);
                dgv_userinfo.Columns["UserID"].Visible = false;
    

                dgv_userinfo.Columns[3].Width = 150;
                dgv_userinfo.Columns[5].Width = 200;

                Create_Menu_tree();
            }
            catch
            { 
            
            }
            
        }

       
        
        private void Btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_userinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int rowindex = e.RowIndex;
                rowUser = dgv_userinfo.Rows[rowindex];

                txt_name.Text = rowUser.Cells["UserName"].Value.ToString();
                txt_password.Text = com.DecryptIt(rowUser.Cells["UserPWord"].Value.ToString(), 11);
                txt_re_password.Text = txt_password.Text;
                txtEmpCode.Text = rowUser.Cells["Empcode"].Value.ToString();
                Select_menu_Id(rowUser.Cells["Menu_id"].Value.ToString());
              
            }
            catch
            { 
            
            }
          
        }

      

       

 

       




        private void Create_Menu_tree()
        {
            try
             {
              
                string userQuery = @"SELECT *
                              FROM [tblMenuWin]";

                DataTable dt = dc.selectquery(userQuery);


                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();


                PopulateTreeView(treeView1.Nodes, 0, dt);


         //     treeView1.Nodes[0].Expand();
                treeView1.Select();

                treeView1.EndUpdate();

                treeView1.ExpandAll();
            }

            catch
            {
                //MessageBox.Show(me.ToString());
            
            }
        }
        protected void PopulateTreeView(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {
            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["Menu ID"]) == parentID)
                {
                    String key = folder["ID"].ToString();
                    String text = folder["Menu_Name"].ToString();
                    TreeNodeCollection newParentNode = parentNode.Add(key, text).Nodes;
                      
                    PopulateTreeView(newParentNode, Convert.ToInt32(folder["ID"]), folders);
                }
            }
        }
        protected string Get_menu_Id()
        {
            try
            {
                              
                string id = "";

                foreach (TreeNode t in treeView1.Nodes)
                {

                    if (t.Checked == true)
                    {

                        string id_ = "";

                        id_ = search_child(t, t.Name);

                        if (id != "")
                        {
                            id = id + "," + id_;
                        }
                        else

                        {
                            id = id_;
                        }
                    }



                }
                //   treeView1.CollapseAll();
              //  MessageBox.Show(id);
                return id;
            }

            catch
            {

            }
            return "";
        }



        protected string search_child(TreeNode t, string id)
        {
            try
            {
                if (t != null)
                {

                    foreach (TreeNode temp in t.Nodes)
                    {
                        if (temp.Checked == true)
                        {
                            id = id + "," + temp.Name;
                            id =  search_child(temp, id);
                        }

                       
                    }
                }


            }
            catch
            {

            }

            return id;
        }



        protected void Select_menu_Id(string ids)
        {
            try
            {

                UncheckAllNodes(treeView1.Nodes);

                string[] id = ids.Split(',');
            


                foreach (TreeNode t in treeView1.Nodes)
                {

                 int ysn= Array.IndexOf(id, t.Name.ToString());
                 if (ysn > -1)
                    {

                        t.Checked = true;
                        Select_child(t, id);
                    }



                }
              
            }

            catch
            {

            }
         
        }



        protected void Select_child(TreeNode t, string[] id)
        {
            try
            {
                if (t != null)
                {

                    foreach (TreeNode temp in t.Nodes)
                    {
                        int ysn = Array.IndexOf(id, temp.Name.ToString());
                        if (ysn > -1)
                        {

                            temp.Checked = true;
                           
                        }

                        
                    }
                }


            }
            catch
            {

            }

           
        }


        public void CheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        public void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_userinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
               try
               {


                   if (txt_name.Text != "" && txt_password.Text != "" && txt_password.Text == txt_re_password.Text)
                   {


                       Menu_ID = Get_menu_Id();

                       string query_user_info = @"Insert INTO tblUserInfo([User_Name]
                                              ,[password]
                                              ,[ContactNumber]
                                              ,[Address]
                                              ,[Designation]
                                              , Menu_id
                                              ,[created_by]
                                              ,[created_date]
                                              ,YsnActive
                                              ) VALUES ('" + txt_name.Text + "','" + com.EncryptIt(txt_password.Text, 11) + "','" + txt_ContactNumber.Text + "','" + txt_address.Text + "','" + txtEmpCode.Text + "','" + Menu_ID + "','" + user + "','" + DateTime.Now + "','true')";




                       string[] ColumnsName = new string[10];
                       ColumnsName[0] = "User_Name";
                       ColumnsName[0] = "password";

                       string[] ColumnsValue = new string[10];
                       ColumnsValue[0] = txt_name.Text;
                       ColumnsValue[0] = com.EncryptIt(txt_password.Text, 11);




                       DialogResult YesNO = MessageBox.Show("Do you want to Save ?", "confirmation !", MessageBoxButtons.YesNoCancel);


                       if (YesNO.ToString() == "Yes")
                       {


                           if (dc.nonselcetquery(query_user_info))
                           {

                               MessageBox.Show(" Data Saved Successfully", "confirmation !");

                               frm_user_information_Load(sender, e);

                           }
                           else
                           {
                               MessageBox.Show("Operation Failed !", "confirmation !");

                           }
                       }
                   }

                   else
                   {
                       lb_password_error.Text = "Password Not Match";

                   }

               }

               catch
               {


               }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Delate " + rowUser.Cells["UserID"].Value.ToString() + " ID", "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string delete = @"UPDATE tblUserInfo SET YsnActive='false' where ID='" + rowUser.Cells[0].Value + "'";
                    dc.selectquery(delete);
                    dgv_userinfo.DataSource = dc.selectquery(dgvdata);
                    if (user ==user_name)
                    {
                        Application.Exit();
                    }

                }
                else if (dialogResult == DialogResult.No)
                {

                }
        }



        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

              try
              {


                  if (txt_name.Text != "" && txt_password.Text != "" && txt_password.Text == txt_re_password.Text)
                  {

                      string query_user_info = @"UPDATE Sys_User_Name SET UserName='" + txt_name.Text + "',[UserPWord]='" + com.EncryptIt(txt_password.Text, 11)
                                                                     + "',[Menu_id]='" + Get_menu_Id()
                                                                      + "',Empcode='" + txtEmpCode.Text + "' where UserID='" + rowUser.Cells["UserID"].Value.ToString() + "'";




                      DialogResult YesNO = MessageBox.Show("Do you want to Update ?", "confirmation !", MessageBoxButtons.YesNoCancel);
                      if (YesNO.ToString() == "Yes")
                      {


                          if (dc.nonselcetquery(query_user_info))
                          {

                              MessageBox.Show(" Data Updated Successfully", "confirmation !");

                              frm_user_information_Load(sender, e);

                          }
                          else
                          {
                              MessageBox.Show("Operation Failed !", "confirmation !");


                          }
                      }


                  }
              }
              catch
              {

              }

        }
       
    }
}