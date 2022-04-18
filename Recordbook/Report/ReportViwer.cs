using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;

namespace Recordbook.Report
{
    public partial class ReportViwer : Form
    {
        Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();
        Recordbook.Extra.call com = new Extra.call();
        ReportDocument rpt = new ReportDocument();



        DataTable dt = null;
        string ReportName = "";
        string Param;
        
            //.CompanyInfo.Rows[0]["ReportPath"].ToString();
        


        public ReportViwer()
        {
            InitializeComponent();
        }


        public ReportViwer(string ReportName_,DataTable dt_)
        {
            ReportName = ReportName_;
            dt = dt_;
            

            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                string Reportpath = Recordbook.Properties.Settings.Default.ReportPath ;
               // rpt.Load(ReportName);

                string serverName = @Recordbook.Properties.Settings.Default.ServerName;
               // rpt.SetDatabaseLogon("SVR2010", "soft2o11", serverName, Recordbook.Extra.call.DatabaseName);

                switch (ReportName)
                {
                   
                case "File Details":


                ReportName = Reportpath + "rptfiledetails.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break ;


                case "transaction Details":


                ReportName = Reportpath + "rptTransSlip.rpt";

                
                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break ;

                case "Return transaction Details":


                ReportName = Reportpath + "rptReturnSlip.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record room details":


                ReportName = Reportpath + "rptrecordroomdetails.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record details Dept":


                ReportName = Reportpath + "rptrecorddetailsDept.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record details FileName":


                ReportName = Reportpath + "rptrecorddetailsFileName.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "Transaction File":


                ReportName = Reportpath + "Transaction File2.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record details Buyer":


                ReportName = Reportpath + "rptrecorddetailsBuyer.rpt";

                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record details Mcode":


                ReportName = Reportpath + "rptrecorddetailsMcode.rpt";

                
                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record Transaction details":


                ReportName = Reportpath + "Transaction File.rpt";

                //rpt.DataDefinition.FormulaFields[Param].Text = "Param='" + txtfromDate.text + "' '" + To + "' '" + txtToDate.text + "'";
                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

                case "record Transaction details2":


                ReportName = Reportpath + "Transaction File2.rpt";

                //rpt.DataDefinition.FormulaFields[Param].Text = "Param='" + txtfromDate.text + "' '" + To + "' '" + txtToDate.text + "'";
                rpt.Load(ReportName);
                rpt.Refresh();
                rpt.SetDataSource(dt);
                break;

              

                
                }

                rpt.SetDatabaseLogon("SVR2010", "soft2o11");

                ReportViewer1.ReportSource = rpt;
               
            }

            catch
            {
            }
            
        }
    }
}
