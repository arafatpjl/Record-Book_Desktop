using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Recordbook.conn
{
    class Mssqlconnect
    {
        public SqlDataAdapter adp;
        public string Connectionstring;
        public SqlConnection conn;

        public  Mssqlconnect()
    
        {
            string serverName = Recordbook.Properties.Settings.Default.ServerName;
            string DBName = Recordbook.Extra.call.DatabaseName;
            try
            {

                // Connectionstring = "Data Source=soft07;Initial Catalog=Recordbook;User ID=sa;Password=SOFT2ooo;connection timeout=120";
                Connectionstring = "Data Source=" + serverName + "\\;Initial Catalog=" + DBName + ";User ID=SVR2010;Password=soft2o11;connection timeout=60";
                conn = new SqlConnection(Connectionstring);
                conn.Open();
            }
            catch

            {

            }

            //catch (SqlException ex)
            //{
            //    MessageBox.Show(GetErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }

        //public  ConnectDB()
        //{
        //    string serverName = Recordbook.Properties.Settings.Default.ServerName;
        //    string DBName = Recordbook.Extra.call.DatabaseName;

        //    // Connectionstring = "Data Source=soft07;Initial Catalog=Recordbook;User ID=sa;Password=SOFT2ooo;connection timeout=120";
        //    Connectionstring = "Data Source=" + serverName + "\\;Initial Catalog=" + DBName + ";User ID=sa;Password=SOFT2ooo;connection timeout=60";
        //    conn = new SqlConnection(Connectionstring);
        //    conn.Open();

        //    //catch (SqlException ex)
        //    //{
        //    //    MessageBox.Show(GetErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return false;
        //    //}
        //}
        public DataTable selectquery(string sql)
        {
            DataTable dt = new DataTable();


            try
            {
                adp = new SqlDataAdapter(sql, conn);
                adp.Fill(dt);

            }

            catch (Exception ex)
            {

                MessageBox.Show("SQL : " + sql + "Database Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Database Error : " + "Operation Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }


        public DataSet selectqueryds(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL : " + sql + "Database Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return ds;
        }

        public bool nonselcetquery(string sql)
        {

            SqlCommand cmd = null;
            try
            {

                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL : " + sql + "Database Error : " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //return cmd.ExecuteNonQuery();
        }

    }

}
