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
    public partial class frmPhieuXuat : Form
    {

        int vitriPX = 0;
        private static bool kt_btnThemPX = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaPX = false;

        int vitriCTPX = 0;
        private static bool kt_btnThemCTPX = false; //kiểm tra có đang bấm nút Thêm hay k
        private static bool kt_btnSuaCTPX = false;


        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);

            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            txtMAVT.Text = cmbVATTU.SelectedValue.ToString();

            if (Program.mGroup == "CONGTY")
            {
                toolStripPX.Enabled = toolStripCTPX.Enabled = false;
            }
            else
            {
                panel1.Enabled = false;
            }

            groupBox5.Enabled = groupBox4.Enabled = btnLuu.Enabled = btnLuuCT.Enabled = false;

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

                this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPXTableAdapter.Fill(this.dS.CTPX);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            }
        }

        private void cmbKHO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKHO.ValueMember != "" && cmbKHO.SelectedValue != null)
            {
                txtMAKHO.Text = cmbKHO.SelectedValue.ToString();
            }
        }

        private void cmbVATTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVATTU.ValueMember != "" && cmbVATTU.SelectedValue != null)
            {
                txtMAVT.Text = cmbVATTU.SelectedValue.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            vitriPX = phieuXuatBindingSource.Position;
            kt_btnThemPX = groupBox4.Enabled = txtMAPXPX.Enabled = btnLuu.Enabled = true;
            phieuXuatGridControl.Enabled = false;

            txtMANV.Text = Program.username;
            txtHOTENKH.Text = txtMAPXPX.Text = "";
            txtMAKHO.Text = cmbKHO.SelectedValue.ToString();

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = null;

            if (txtMAPXPX.Text.Trim() == "" || txtHOTENKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã PN hoắc họ tên KH không được trống\nVui lòng nhập lại!", "", MessageBoxButtons.OK);
                return;
            }

            if (kt_btnThemPX == true && KiemTraThemMaPX(txtMAPXPX.Text.ToString()) == 1)
            {
                MessageBox.Show("Mã PX này đã tồn tại\nVui lòng nhập mã khác!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                sqlConnection.Open();

                if (kt_btnThemPX == true)
                    sql = "exec sp_ThemPhieuXuat'" + txtMAPXPX.Text + "','" + dtpNGAY.Value + "', N'" + txtHOTENKH.Text + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";
                if (kt_btnSuaPX == true)
                    sql = "exec sp_SuaPhieuXuat '" + ((DataRowView)phieuXuatBindingSource[vitriPX])["MAPX"] + "','" + dtpNGAY.Value + "',N'" + txtHOTENKH.Text + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";

                int check = Program.ExecSqlNonQuery(sql);

                if (check != 0)
                    return;

                sqlConnection.Close();
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Phiếu xuất.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            phieuXuatGridControl.Enabled = true;
            kt_btnSuaPX = kt_btnThemPX = groupBox4.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            vitriPX = 0;
        }

        private int KiemTraThemMaPX(string maPX)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaPhieuXuat", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAPX", maPX);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            vitriPX = phieuXuatBindingSource.Position;

            //Kiem tra ngày
            DateTime ngayHeThong = DateTime.Now;
            DateTime ngayHienTai = Convert.ToDateTime(ngayHeThong);

            SqlConnection sqlConnection = new SqlConnection(Program.connstr);
            sqlConnection.Open();

            SqlDataReader dr;
            string ngay = "select NGAY from dbo.PhieuXuat where MAPX = '" + ((DataRowView)phieuXuatBindingSource[vitriPX])["MAPX"] + "'";
            dr = Program.ExecSqlDataReader(ngay);
            DateTime ngayGiao = Convert.ToDateTime(ngayHeThong);

            while (dr.Read())
            {
                ngayGiao = dr.GetDateTime(0);
            }
            Program.conn.Close();


            if (ngayGiao <= ngayHienTai)
            {
                MessageBox.Show("Bạn không thể sửa phiếu xuất này được!\nPhiếu xuất đã được xuất hàng\n", "",
                MessageBoxButtons.OK);
                return;
            }

            kt_btnSuaPX = btnLuu.Enabled = true;
            txtMAPXPX.Enabled = phieuXuatGridControl.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPX = "";
            groupBox4.Enabled = false;

            int vitri = 0;
            vitri = phieuXuatBindingSource.Position;

            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu xuất này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (KiemTraXoaPhieuXuat((((DataRowView)phieuXuatBindingSource[vitri])["MAPX"]).ToString()) == 1)
                    {
                        MessageBox.Show("Vui lòng xóa CTPX của PX này trước\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    maPX = ((DataRowView)phieuXuatBindingSource[vitri])["MAPX"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    phieuXuatBindingSource.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                    phieuXuatBindingSource.Position = phieuXuatBindingSource.Find("MAPX", maPX);
                    return;
                }
            }

        }

        private int KiemTraXoaPhieuXuat(string maPX)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemtraMaPXTrongCTPX", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAPX", maPX);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            phieuXuatBindingSource.CancelEdit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            phieuXuatGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            btnLuu.Enabled = groupBox4.Enabled = false;
        }

        //CTPX
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = gridView2.RowCount;

            if (count == 0)
            {
                MessageBox.Show("Không thể tạo CTPX!\nVui lòng tạo PX trước", "", MessageBoxButtons.OK);
                return;
            }

            vitriCTPX = cTPXBindingSource.Position;

            txtMAPX.Text = txtMAPXPX.Text;
            txtMAVT.Text = cmbVATTU.SelectedValue.ToString();
            seDONGIA.Text = seSOLUONG.Text = "0";


            cTPXGridControl.Enabled = false;
            btnThemCT.Enabled = btnSuaCT.Enabled = btnXoaCT.Enabled = false;
            btnLuuCT.Enabled = btnUndoCTPX.Enabled = btnRefreshCTPX.Enabled = true;
            kt_btnThemCTPX = groupBox5.Enabled = true;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (seDONGIA.Text.Trim() == "" || seSOLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số lượng và đơn giá!", "", MessageBoxButtons.OK);
                return;
            }

            if (Int32.Parse(seSOLUONG.Value.ToString()) < 1 || Int32.Parse(seDONGIA.Value.ToString()) < 1)
            {
                MessageBox.Show("Số lượng hoặc đơn giá không được < 1\nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }

            string maPX = txtMAPX.Text.ToString();
            string maVT = cmbVATTU.SelectedValue.ToString();
            int soLuong = Int32.Parse(seSOLUONG.Value.ToString());
            float donGia = float.Parse(seDONGIA.Value.ToString());

            if (kt_btnThemCTPX == true)
            {

                if (KiemTraDuLieuCTPX(maPX, maVT, soLuong, donGia) == 1)
                {
                    MessageBox.Show("Mã PX đã tồn tại\nVui lòng nhập lại mã", "", MessageBoxButtons.OK);
                    return;
                }
                else if (KiemTraDuLieuCTPX(maPX, maVT, soLuong, donGia) == 2)
                {
                    MessageBox.Show("Vật tư này đã hết số lượng!\nVui lòng chọn vật tư khác.", "", MessageBoxButtons.OK);
                    return;
                }
                else if (KiemTraDuLieuCTPX(maPX, maVT, soLuong, donGia) == 3)
                {
                    MessageBox.Show("SL xuất lớn hơn sl vật tư trong kho\nVui lòng xuất sl ít hơn sl vừa nhập.", "", MessageBoxButtons.OK);
                    return;
                }

                string sql = "exec sp_ThemCTPX '" + txtMAPX.Text + "','" + cmbVATTU.SelectedValue + "'," + seSOLUONG.Value + "," + seDONGIA.Value;
                int them = Program.ExecSqlNonQuery(sql);

                if (them != 0)
                {
                    return;
                }

                MessageBox.Show("Thêm CTPX thành công", "", MessageBoxButtons.OK);
                this.vattuTableAdapter.Fill(this.dS.Vattu);
                this.cTPXTableAdapter.Fill(this.dS.CTPX);
            }
            else if (kt_btnSuaCTPX == true)
            {
                if (KiemTraDuLieuCTPX(maPX, maVT, soLuong, donGia) == 3)
                {
                    MessageBox.Show("SL xuất lớn hơn sl vật tư trong kho\nVui lòng xuất sl ít hơn sl vừa nhập.", "", MessageBoxButtons.OK);
                    return;
                }

                string sql = "exec sp_SuaCTPX '" + txtMAPX.Text + "','" + txtMAVT.Text + "'," + seSOLUONG.Value + "," + seDONGIA.Value;
                int update = Program.ExecSqlNonQuery(sql);

                if (update != 0)
                {
                    return;
                }

                MessageBox.Show("Update thành công", "", MessageBoxButtons.OK);
                this.vattuTableAdapter.Fill(this.dS.Vattu);
                this.cTPXTableAdapter.Fill(this.dS.CTPX);
            }

            cTPXGridControl.Enabled = true;
            groupBox5.Enabled = btnLuuCT.Enabled = false;
            kt_btnSuaCTPX = kt_btnThemCTPX = false;
            btnThemCT.Enabled = btnSuaCT.Enabled = btnXoaCT.Enabled = btnUndoCTPX.Enabled = btnRefreshCTPX.Enabled = true;
        }

        private int KiemTraDuLieuCTPX(string maPX, string maVT, int soLuong, float donGia)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraDuLieuCTPX", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAPX", maPX);
                cmd.Parameters.AddWithValue("MAVT", maVT);
                cmd.Parameters.AddWithValue("SOLUONG", soLuong);
                cmd.Parameters.AddWithValue("DONGIA", donGia);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            vitri = cTPXBindingSource.Position;

            //Kiem tra ngày, nếu ngày >= ngày ht thì k cho sửa
            DateTime ngayHeThong = DateTime.Now;
            DateTime ngayHienTai = Convert.ToDateTime(ngayHeThong);

            SqlConnection sqlConnection = new SqlConnection(Program.connstr);
            sqlConnection.Open();

            SqlDataReader dr;
            string ngay = "select NGAY from dbo.PhieuXuat where MAPX = '" + ((DataRowView)cTPXBindingSource[vitri])["MAPX"] + "'";
            dr = Program.ExecSqlDataReader(ngay);
            DateTime ngayXuat = Convert.ToDateTime(ngayHeThong);

            while (dr.Read())
            {
                ngayXuat = dr.GetDateTime(0);
            }
            Program.conn.Close();

            if (ngayXuat <= ngayHienTai)
            {
                MessageBox.Show("Bạn không thể sửa CTPX này được!\nPhiếu xuất này đã được xuất hàng\n", "",
                MessageBoxButtons.OK);
                return;
            }

            cmbVATTU.Enabled = cTPXGridControl.Enabled = false;
            kt_btnSuaCTPX = groupBox5.Enabled = btnLuuCT.Enabled = true;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            vitri = cTPXBindingSource.Position;

            if (MessageBox.Show("Bạn có thật sự muốn xóa CTPX này? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    //Kiem tra ngày, nếu ngày >= ngày ht thì k cho xóa, ngc lại phải update lại soluongton bên table vật tư
                    DateTime ngayHeThong = DateTime.Now;
                    DateTime ngayHienTai = Convert.ToDateTime(ngayHeThong);

                    SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                    sqlConnection.Open();

                    SqlDataReader dr;
                    string ngay = "select NGAY from dbo.PhieuXuat where MAPX = '" + ((DataRowView)cTPXBindingSource[vitri])["MAPX"] + "'";
                    dr = Program.ExecSqlDataReader(ngay);
                    DateTime ngayXuat = Convert.ToDateTime(ngayHeThong);

                    while (dr.Read())
                    {
                        ngayXuat = dr.GetDateTime(0);
                    }
                    Program.conn.Close();


                    if (ngayXuat <= ngayHienTai)
                    {
                        MessageBox.Show("Bạn không thể xóa CTPX này được!\nPhiếu xuất này đã được xuất hàng\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    string sql = "exec sp_XoaCTPX '" + ((DataRowView)cTPXBindingSource[vitri])["MAPX"] + "','" + ((DataRowView)cTPXBindingSource[vitri])["MAVT"] + "'";
                    int xoa = Program.ExecSqlNonQuery(sql);

                    if (xoa != 0)
                    {
                        return;
                    }

                    MessageBox.Show("Xóa CTPX thành công", "", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    this.cTPXTableAdapter.Fill(this.dS.CTPX);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa CTPX\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnUndoCTPX_Click(object sender, EventArgs e)
        {
            cTPXBindingSource.CancelEdit();
        }

        private void btnRefreshCTPX_Click(object sender, EventArgs e)
        {
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            cTPXGridControl.Enabled = true;
            btnThemCT.Enabled = btnXoaCT.Enabled = btnSuaCT.Enabled = btnUndoCTPX.Enabled = btnRefreshCTPX.Enabled = true;
            btnLuuCT.Enabled = groupBox4.Enabled = false;
        }
    }
}
