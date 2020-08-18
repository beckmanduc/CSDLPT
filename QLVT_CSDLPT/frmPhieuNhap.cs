using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_CSDLPT
{
    public partial class frmPhieuNhap : Form
    {

        int vitriPN = 0;
        private static bool kt_btnThemPN = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaPN = false;

        int vitriCTPN = 0;
        private static bool kt_btnThemCTPN = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaCTPN = false;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                toolStripPN.Enabled = toolStripCTPN.Enabled = false;
            }
            else
            {
                panel1.Enabled = false;
            }

            groupBox3.Enabled = groupBox4.Enabled = btnLuu.Enabled = btnLuuCT.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue == null) return;
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            else
            {
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dS.Kho);

                this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPNTableAdapter.Fill(this.dS.CTPN);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dS.DatHang);
            }
        }

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKHO.ValueMember != "" && cmbKHO.SelectedValue != null)
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
        }

        //PHIEUNHAP
        private void btnThem_Click(object sender, EventArgs e)
        {
            int countPN = 0;
            countPN = phieuNhapBindingSource.Count;
            if (countPN != 0)
            {
                MessageBox.Show("PN đã được tạo cho DDH này!\n Bạn không thể tạo PN này", "", MessageBoxButtons.OK);
                return;
            }

            int count = 0;
            count = gridView2.RowCount;

            if (count == 0)
            {
                MessageBox.Show("Không thể tạo PN!\nVui lòng tạo đơn DH và CTDDH trước", "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;

            vitriPN = phieuNhapBindingSource.Position;

            txtMAPNPN.Text = "";
            txtMASODDH.Text = ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["MasoDDH"].ToString();
            txtMANV.Text = Program.username;
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();

            phieuNhapGridControl.Enabled = false;
            kt_btnThemPN = groupBox3.Enabled = btnLuu.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            phieuNhapGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            btnLuu.Enabled = groupBox3.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            phieuNhapBindingSource.CancelEdit();
        }

        private void phieuNhapGridControl_Click(object sender, EventArgs e)
        {
            Point clickPoint = phieuNhapGridControl.PointToClient(Control.MousePosition);
            var hitInfo = gridView3.CalcHitInfo(clickPoint);
            if (hitInfo.InRowCell)
            {
                int rowHandle = hitInfo.RowHandle;
                GridColumn column = hitInfo.Column;
                txtMASODDH.Text = ((DataRowView)phieuNhapBindingSource[rowHandle])["MasoDDH"].ToString();

                String sql = "exec sp_LocMaVatTu '" + ((DataRowView)phieuNhapBindingSource[0])["MAPN"] + "'";
                DataTable tableVatTu = Program.ExecSqlDataTable(sql);

                cmbVatTu.DataSource = tableVatTu;
                cmbVatTu.DisplayMember = "TENVT";
                cmbVatTu.ValueMember = "MAVT";

                txtMAVT.Text = cmbVatTu.SelectedValue.ToString();
                txtMAPN.Text = txtMAPNPN.Text;
            }
        }

    }
}
