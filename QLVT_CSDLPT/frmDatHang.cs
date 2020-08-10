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
        private static bool kt_btnThemDH = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaDH = false;


        int vitriCTDH = 0;
        private static bool kt_btnThemCTDH = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaCTDH = false;

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
            kt_btnSuaDH = true;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt_btnThemDH = true;
            vitriDH = datHangBindingSource.Position;
            //bindingNavigatorCTDH.Enabled = false;
            groupBox3.Enabled = txtMASODDH.Enabled = btnLuu.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            datHangGridControl.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;

            txtMASODDHDH.Text = txtNHACC.Text = "";
            txtMANV.Text = Program.username;
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = null;
            if (txtMASODDHDH.Text.Trim() == "" || txtNHACC.Text.Trim() == "")
            {
                MessageBox.Show("Mã số DDH hoặc nhà CC không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (kt_btnThemDH == true && KiemTraMaDDH(txtMASODDHDH.Text.ToString()) == 1)
            {
                MessageBox.Show("Mã DDH bị trùng\nVui lòng nhập mã khác!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                sqlConnection.Open();

                if (kt_btnThemDH == true)
                    sql = "exec sp_ThemDatHang'" + txtMASODDHDH.Text + "','" + dtpNGAY.Value + "','" + txtNHACC.Text + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";

                if (kt_btnSuaDH == true)
                    sql = "exec sp_SuaDatHang'" + ((DataRowView)datHangBindingSource[vitriDH])["MasoDDH"] + "','" + dtpNGAY.Value + "','" + txtNHACC.Text + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";

                int check = Program.ExecSqlNonQuery(sql);

                if (check != 0)
                    return;

                sqlConnection.Close();
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi DDH.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            this.datHangTableAdapter.Fill(this.dS.DatHang);
            datHangGridControl.Enabled = btnLuu.Enabled = true;
            kt_btnSuaDH = kt_btnThemDH = groupBox3.Enabled = false;
            vitriDH = 0;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
        }

        private int KiemTraMaDDH(string maDDH)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMSDDH_ThemDDH", conn))
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

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKHO.ValueMember != "" && cmbKHO.SelectedValue != null)
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            datHangBindingSource.CancelEdit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            datHangGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            btnLuu.Enabled = groupBox3.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDDH = "";
            int vitri = 0;
            vitri = datHangBindingSource.Position;

            groupBox3.Enabled = false;

            if (MessageBox.Show("Bạn có thật sự muốn xóa DDH này? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (KiemTra_XoaPN(((DataRowView)datHangBindingSource[vitri])["MasoDDH"].ToString()) == 1)
                    {
                        MessageBox.Show("Bạn không thể xóa Đặt hàng này được!\nĐặt hàng đã tồn tại CTDDH hoặc tồn tại Phiếu nhập\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    maDDH = ((DataRowView)datHangBindingSource[datHangBindingSource.Position])["MAKHO"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    datHangBindingSource.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.dS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa DDH. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.dS.DatHang);
                    datHangBindingSource.Position = datHangBindingSource.Find("MasoDDH", maDDH);
                    return;
                }
            }

        }

        private int KiemTra_XoaPN(string maDDH)
        {
            // kiểm tra đk để xóa phiếu nhập
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaDDH_XoaDatHang", conn))
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


        // CTDH
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            btnXoaCT.Enabled = btnSuaCT.Enabled = false;

            int count = 0;
            count = gridView1.RowCount;

            if (count == 0)
            {
                MessageBox.Show("Không thể tạo CTPDDH!\nVui lòng tạo DDH trước", "", MessageBoxButtons.OK);
                return;
            }

            vitriCTDH = cTDDHBindingSource.Position;
            kt_btnThemCTDH = groupBox4.Enabled = btnLuuCT.Enabled = cmbVATTU.Enabled = true;
            cTDDHGridControl.Enabled = txtMASODDH.Enabled = false;

            txtMASODDH.Text = txtMASODDHDH.Text;
            txtMAVT.Text = cmbVATTU.SelectedValue.ToString();
            seSOLUONG.Text = seDONGIA.Text = "0";
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            vitri = datHangBindingSource.Position;
            if (KiemTra_MaSoDDH_TrongPN(((DataRowView)datHangBindingSource[vitri])["MasoDDH"].ToString()) == 1)
            {
                MessageBox.Show("Bạn không thể sửa CTDDH này được!\nĐặt hàng đã tồn tại trong Phiếu nhập\n", "",
                MessageBoxButtons.OK);
                return;
            }

            vitriCTDH = cTDDHBindingSource.Position;
            txtMASODDH.Text = txtMASODDHDH.Text;
            cmbVATTU.Enabled = cTDDHGridControl.Enabled = btnThemCT.Enabled = btnXoaCT.Enabled = false;
            kt_btnSuaCTDH = groupBox4.Enabled = btnLuuCT.Enabled = true;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            string sql = null;

            if (Int32.Parse(seDONGIA.Value.ToString()) < 1 || Int32.Parse(seSOLUONG.Value.ToString()) < 1)
            {
                MessageBox.Show("Đơn giá hoặc số lượng không phù hợp\nVui lòng nhập lại!", "", MessageBoxButtons.OK);
                return;
            }

            if (kt_btnThemCTDH == true && KiemTraThemCTDDH(txtMASODDHDH.Text, cmbVATTU.SelectedValue.ToString()) == 1)
            {
                MessageBox.Show("CTDDH này đã tồn tại\nVui lòng nhập lại mã VT!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                sqlConnection.Open();

                if (kt_btnThemCTDH == true)
                    sql = "exec sp_ThemCTDDH'" + txtMASODDH.Text + "','" + cmbVATTU.SelectedValue.ToString() + "'," + seSOLUONG.Value + "," + seDONGIA.Value;

                if (kt_btnSuaCTDH == true)
                    sql = "exec sp_SuaCTDDH'" + ((DataRowView)cTDDHBindingSource[vitriCTDH])["MasoDDH"].ToString() + "','" + ((DataRowView)cTDDHBindingSource[vitriCTDH])["MAVT"].ToString() + "'," + seSOLUONG.Value + "," + seDONGIA.Value;

                int check = Program.ExecSqlNonQuery(sql);
                if (check != 0)
                    return;

                sqlConnection.Close();
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi CTDDH.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            cTDDHGridControl.Enabled = true;
            kt_btnSuaCTDH = kt_btnThemCTDH = false;
            vitriCTDH = 0;
            btnThemCT.Enabled = btnXoaCT.Enabled = btnSuaCT.Enabled = true;
            btnLuuCT.Enabled = false;
            groupBox3.Enabled = groupBox4.Enabled = false;
        }

        private int KiemTraThemCTDDH(string maDDH, string maVT)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraKhoaCTDDH_ThemCTDDH", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MasoDDH", maDDH);
                cmd.Parameters.AddWithValue("MAVT", maVT);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }
    }
}
