using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Recordbook.conn;

namespace Recordbook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Recordbook.Extra.call.DatabaseName = "Recordbook";
           // Application.Run(new frmsplash());

             Recordbook.conn.Mssqlconnect dc = new conn.Mssqlconnect();

             Application.Run(new frmsplash());
             

           
        }
    }
}
