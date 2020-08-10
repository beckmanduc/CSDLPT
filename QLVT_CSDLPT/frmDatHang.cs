using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_CSDLPT
{
    public partial class frmDatHang : Form
    {
        int vitriDH = 0;
        int vitriCTDH = 0;
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
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
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            txtMAVT.Text = cmbVATTU.SelectedValue.ToString();

            if (Program.mGroup == "CONGTY")
            {
                toolStripDH.Enabled = toolStripCTDH.Enabled = false;
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

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dS.DatHang);
            }
        }

        // DAT HANG
        private void btnSua_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            vitri = datHangBindingSource.Position;
            if (KiemTra_MaSoDDH_TrongPN(((DataRowView)datHangBindingSource[vitri])["MasoDDH"].ToString()) == 1)
            {
                MessageBox.Show("Bạn không thể sửa DDH này được!\nĐặt hàng đã tồn tại trong Phiếu nhập\n", "",
                MessageBoxButtons.OK);
                return;
            }

            btnLuu.Enabled = true;
            vitriDH = datHangBindingSource.Position;
            txtMASODDHDH.Enabled = datHangGridControl.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            groupBox3.Enabled = true;
        }


        private int KiemTra_MaSoDDH_TrongPN(string maDDH)
        {
            // kiểm tra đk để xóa phiếu nhập
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaSoDDH_TrongPN", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MasoDDH", maDDH);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }


    }
}
