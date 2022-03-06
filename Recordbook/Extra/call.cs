using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;

namespace Recordbook.Extra
{
    public class call
    {
        public string[] CompanyInformation()
        {
            string[] CompanyInformation = new string[] {"Pacific Jeans Limited ",
                                                        "CEPZ,Chittagong",
                                                        "Contact Number:" };
            return CompanyInformation;
        }

        public static string DatabaseName { get; set; }

        //public string[] databaseServer()
        //{
        //    string[] ServerInformation = new string[] {"soft07",
        //                                                "Recordbook",
        //                                                "sa",
        //                                                "SOFT2ooo" };
        //    return ServerInformation;
        //}

        public DataTable FilterDatatableEqual(DataTable dtMain, string ColName, string ColValue)
        {

            DataRow[] drFilter;

            DataTable dtFilter = new DataTable();

            dtFilter = dtMain.Clone();

            drFilter = dtMain.Select(@"" + ColName + "='" + ColValue + "'");

            foreach (DataRow dr in drFilter)
            {

                dtFilter.ImportRow(dr);

            }

            return dtFilter;


        }

        public DataTable FilterDatatableIN(DataTable dtMain, string ColName, string ColValue)
        {

            DataRow[] drFilter;

            DataTable dtFilter = new DataTable();

            dtFilter = dtMain.Clone();

            drFilter = dtMain.Select(@"" + ColName + "in (" + ColValue + ")");

            foreach (DataRow dr in drFilter)
            {

                dtFilter.ImportRow(dr);

            }

            return dtFilter;

        }


        static DataTable _SysConfigInfo;

        public  DataTable SysConfigInfo
        {
            get
            {
                return _SysConfigInfo;
            }
            set
            {
                _SysConfigInfo = value;
            }
        }




        /// Global User Control Info
        /// 


        static DataTable _CompanyInfo;

        public  DataTable CompanyInfo
        {
            get
            {
                return _CompanyInfo;
            }
            set
            {
                _CompanyInfo = value;
            }
        }




        /// Global User CompidInfo
        /// 


        static DataTable _CompidInfo;

        public static DataTable CompidInfo
        {
            get
            {
                return _CompidInfo;
            }
            set
            {
                _CompidInfo = value;
            }
        }

        /// Global bforeUserInfo
        /// 

        static DataTable _bforeUserInfo;

        public static DataTable bforeUserInfo
        {
            get
            {
                return _bforeUserInfo;
            }
            set
            {
                _bforeUserInfo = value;
            }
        }

        /// Global UserInfo
        /// 

        static DataTable _UserInfo;

        public static DataTable UserInfo
        {
            get
            {
                return _UserInfo;
            }
            set
            {
                _UserInfo = value;
            }
        }


        /// Global UserInfo
        /// 

        static string _User;

        public static string User
        {
            get
            {
                return _User;
            }
            set
            {
                _User = value;
            }
        }



        /// Global Menu Info
        /// 

        static DataTable _MenuInfo;

        public static DataTable MenuInfo
        {
            get
            {
                return _MenuInfo;
            }
            set
            {
                _MenuInfo = value;
            }
        }


        /// Global User Control Info
        /// 

        static DataTable _UserControlInfo;

        public static DataTable UserControlInfo
        {
            get
            {
                return _UserControlInfo;
            }
            set
            {
                _UserControlInfo = value;
            }
        }


        /// Global Year
        /// 

        static string _Year;

        public static string Year
        {
            get
            {
                return _Year;
            }
            set
            {
                _Year = value;
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName, uint VolumeNameSize, out int SerialNumber, out int SerialNumberLength, out int flags, StringBuilder fs, uint fs_size);

        public string GetVolumeInformation(string drives, object sender, EventArgs e)
        {


            string VolumeSerialID = "";

            int serialNum, serialNumLength, flags;
            StringBuilder volumename = new StringBuilder(256);
            StringBuilder fstype = new StringBuilder(256);

            bool ok = GetVolumeInformation(drives, volumename, (uint)volumename.Capacity - 1, out serialNum, out serialNumLength, out flags, fstype, (uint)fstype.Capacity - 1);
            if (ok)
            {
                VolumeSerialID = serialNum.ToString();
            }

            return VolumeSerialID;

        }

        public string EncryptIt(string s, int Crack)
        {


            string Z = "";
            char[] c = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                int asci = (int)c[i];

                Z = Z + (char)(asci + Crack);

            }
            return Z;

        }

        public string DecryptIt(string s, int Crack)
        {
            string Z = "";
            char[] c = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                int asci = (int)c[i];

                Z = Z + (char)(asci - Crack);

            }
            return Z;
        }

        public void abc(string sdate)
        {
            //DateTime now = DateTime.Parse(sdate);
            //String abc = now.ToString("dd-MMM-yyyy");
            //Parse(txtVADate.Text.Trim()).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

        }
    }
}
