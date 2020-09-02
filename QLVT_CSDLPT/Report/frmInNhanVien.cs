using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_CSDLPT.Report
{
    public partial class frmInNhanVien : Form
    {
        public frmInNhanVien()
        {
            InitializeComponent();
        }

        private void frmInNhanVien_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.Enabled = false;

            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {


            string maCN = "";

            string tenCN = cmbChiNhanh.Text;

            maCN = GetFirstLetterOfString(tenCN);
            XtraReportDanhSachNhanVien rp = new XtraReportDanhSachNhanVien(maCN, tenCN);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private string GetFirstLetterOfString(string str)
        {
            string ShortName = "";

            str.Split(' ').ToList().ForEach(i => ShortName += i[0].ToString());
            return ShortName;
        }
    }
}
