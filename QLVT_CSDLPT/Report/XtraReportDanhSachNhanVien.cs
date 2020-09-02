using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraExport.Helpers;

namespace QLVT_CSDLPT.Report
{
    public partial class XtraReportDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportDanhSachNhanVien(string maCN, string tenCN)
        {
            InitializeComponent();
            qlvtDataSet11.EnforceConstraints = false;
            String dbname = Program.servername;
            dbname = dbname.Remove(dbname.Length - 1);
            if (maCN == "CN1")
            {

                dbname = dbname + "2";

            }
            else 
            {
                dbname = dbname + "3";
            }
           
      
            labelTieuDe.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH " + tenCN;
            String connstr = "Data Source=" + dbname + ";Initial Catalog=" +
                     Program.database + ";User ID=" +
                     Program.remotelogin + ";password=" + Program.remotepassword;

            try
            {
                this.sp_INNHANVIENTableAdapter.Connection.ConnectionString = connstr;
                this.sp_INNHANVIENTableAdapter.Fill(qlvtDataSet11.sp_INNHANVIEN, maCN);
               
            }
            catch (Exception ex)
            {

            }
        }

    }
}
