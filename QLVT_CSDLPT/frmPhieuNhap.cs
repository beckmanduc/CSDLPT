using DevExpress.XtraGrid.Columns;
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
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);

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

        private void cmbVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVatTu.ValueMember != "" && cmbVatTu.SelectedValue != null)
            {
                txtMAVT.Text = cmbVatTu.SelectedValue.ToString();
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
            this.phieuNhapBindingSource.RemoveFilter();
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Point clickPoint = datHangGridControl.PointToClient(Control.MousePosition);
            var hitInfo = gridView1.CalcHitInfo(clickPoint);
            if (hitInfo.InRowCell)
            {
                int rowHandle = hitInfo.RowHandle;
                GridColumn column = hitInfo.Column;
                String maDDH = ((DataRowView)datHangBindingSource[rowHandle])["MasoDDH"].ToString();
                //txtMASODDH.Text = maDDH;
                phieuNhapBindingSource.Filter = "MasoDDH = '" + maDDH + "'";
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                cTDDHBindingSource.Filter = "MasoDDH = '" + maDDH + "'";
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
                txtMASODDH.Text = maDDH;
                txtMANV.Enabled = false;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = null;

            if (txtMAPNPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã số phiếu nhập không được thiếu!", "", MessageBoxButtons.OK);
                txtMAPNPN.Focus();
                return;
            }

            if (kt_btnThemPN == true && KiemTraMaPN(txtMAPNPN.Text) == 1)
            {
                MessageBox.Show("Mã PN đã tồn tại\nVui lòng nhập mã khác!", "", MessageBoxButtons.OK);
                txtMAPNPN.Focus();
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Program.connstr);
                sqlConnection.Open();

                if (kt_btnThemPN == true)
                   
                sql = "exec sp_ThemPhieuNhap '" + txtMAPNPN.Text + "','" + dtpNGAY.Value + "','" + ((DataRowView)cTDDHBindingSource[0])["MasoDDH"] + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";
                MessageBox.Show(((DataRowView)cTDDHBindingSource[0])["MasoDDH"].ToString());
                if (kt_btnSuaPN == true)
                    sql = "exec sp_SuaPhieuNhap '" + ((DataRowView)datHangBindingSource[vitriPN])["MAPN"] + "','" + dtpNGAY.Value + "','" + ((DataRowView)cTDDHBindingSource[0])["MasoDDH"] + "'," + Program.username + ",'" + cmbKHO.SelectedValue + "'";

                int check = Program.ExecSqlNonQuery(sql);

                if (check != 0)
                    return;

                sqlConnection.Close();
                MessageBox.Show("Lưu thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Phiếu nhập.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            kt_btnSuaPN = kt_btnThemPN = groupBox3.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            groupBox3.Enabled = groupBox4.Enabled = btnLuu.Enabled = false;
            vitriCTPN = vitriPN = 0;
        }

        private int KiemTraMaPN(string maPN)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaPhieuNhap", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAPN", maPN);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            vitriPN = phieuNhapBindingSource.Position;
            txtMASODDH.Text = ((DataRowView)cTDDHBindingSource[0])["MasoDDH"].ToString();
            //Kiem tra ngày
            DateTime ngayHeThong = DateTime.Now;
            DateTime ngayHienTai = Convert.ToDateTime(ngayHeThong);

            SqlConnection sqlConnection = new SqlConnection(Program.connstr);
            sqlConnection.Open();

            SqlDataReader dr;
            string ngay = "select NGAY from dbo.PhieuNhap where MAPN = '" + ((DataRowView)phieuNhapBindingSource[vitriPN])["MAPN"] + "'";
            dr = Program.ExecSqlDataReader(ngay);
            DateTime ngayNhap = Convert.ToDateTime(ngayHeThong);

            while (dr.Read())
            {
                ngayNhap = dr.GetDateTime(0);
            }
            Program.conn.Close();


            if (ngayNhap <= ngayHienTai)
            {
                MessageBox.Show("Bạn không thể sửa phiếu nhập này được!\nPhiếu nhập đã được nhập hàng\n", "",
                MessageBoxButtons.OK);
                return;
            }

            kt_btnSuaPN = btnLuu.Enabled = groupBox3.Enabled = false;
            kt_btnSuaPN = btnLuu.Enabled = groupBox3.Enabled = true;
            txtMAPNPN.Enabled = phieuNhapGridControl.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPN = "";
            groupBox4.Enabled = false;

            int vitri = 0;
            vitri = phieuNhapBindingSource.Position;

            if (MessageBox.Show("Bạn có thật sự muốn xóa phiếu nhập này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int countPN = 0;
                countPN = cTPNBindingSource.Count;
                if (countPN != 0)
                {
                    MessageBox.Show("Vui lòng xóa CTPN trước", "", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    maPN = ((DataRowView)phieuNhapBindingSource[vitri])["MAPN"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    phieuNhapBindingSource.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                    phieuNhapBindingSource.Position = phieuNhapBindingSource.Find("MAPN", maPN);
                    return;
                }
            }
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            Point clickPoint = phieuNhapGridControl.PointToClient(Control.MousePosition);
            var hitInfo = gridView3.CalcHitInfo(clickPoint);
            if (hitInfo.InRowCell)
            {
                int rowHandle = hitInfo.RowHandle;
                GridColumn column = hitInfo.Column;
                String maPN = ((DataRowView)phieuNhapBindingSource[rowHandle])["MAPN"].ToString();
                txtMAPN.Text = maPN;
                cTPNBindingSource.Filter = "MAPN = '" + maPN + "'";
                this.cTPNTableAdapter.Fill(this.dS.CTPN);
                txtMAPN.Text = maPN;

            }
        }

        //CTPHIEUNHAP
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = gridView3.RowCount;

            if (count == 0)
            {
                MessageBox.Show("Không thể tạo CTPN!\nVui lòng tạo PN trước", "", MessageBoxButtons.OK);
                return;
            }

            vitriCTPN = cTPNBindingSource.Position;

            txtMAPN.Text = txtMAPNPN.Text;
            seSOLUONG.Text = seDONGIA.Text = "0";

            btnXoaCT.Enabled = btnSuaCT.Enabled = btnThemCT.Enabled = false;
            kt_btnThemCTPN = groupBox4.Enabled = btnLuuCT.Enabled = true;
        }

        private void btnUndoCTPN_Click(object sender, EventArgs e)
        {
            cTPNBindingSource.CancelEdit();
        }

        private void btnRefreshCTPN_Click(object sender, EventArgs e)
        {
            this.cTPNBindingSource.RemoveFilter();
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            cTPNGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnRefresh.Enabled = true;
            btnLuu.Enabled = groupBox3.Enabled = false;
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
                MessageBox.Show("Số lượng hoặc đơn giá được < 1\nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }

            string maPN = txtMAPNPN.Text.ToString();
            string maVT = cmbVatTu.SelectedValue.ToString();
            int soLuong = Int32.Parse(seSOLUONG.Value.ToString());
            float donGia = float.Parse(seDONGIA.Value.ToString());

            if (kt_btnThemCTPN == true)
            {
                if (KiemTraDuLieuCTPN(maPN, maVT, soLuong, donGia) == 1)
                {
                    MessageBox.Show("Mã VT trong CTPN đã tồn tại\nVui lòng nhập lại mã", "", MessageBoxButtons.OK);
                    return;
                }
                else if (KiemTraDuLieuCTPN(maPN, maVT, soLuong, donGia) == 2)
                {
                    MessageBox.Show("Số lượng hoặc đơn giá lớn hơn so với đơn DH\nVui lòng sửa lại thông tin", "", MessageBoxButtons.OK);
                    return;
                }

                string sql = "exec sp_ThemCTPN'" + txtMAPNPN.Text + "','" + cmbVatTu.SelectedValue + "'," + seSOLUONG.Value + "," + seDONGIA.Value;
                int them = Program.ExecSqlNonQuery(sql);

                if (them != 0)
                {
                    return;
                }

                MessageBox.Show("Thêm CTPN thành công", "", MessageBoxButtons.OK);
                this.cTPNTableAdapter.Fill(this.dS.CTPN);
            }
            else if (kt_btnSuaCTPN == true)
            {
                if (KiemTraDuLieuCTPN(maPN, maVT, soLuong, donGia) == 2)
                {
                    MessageBox.Show("Số lượng hoặc đơn giá lớn hơn so với đơn DH\nVui lòng sửa lại thông tin", "", MessageBoxButtons.OK);
                    return;
                }

                string sql = "exec sp_Sua_CTPN '" + txtMAPNPN.Text + "','" + txtMAVT.Text + "'," + seSOLUONG.Value + "," + seDONGIA.Value;
                int update = Program.ExecSqlNonQuery(sql);

                if (update != 0)
                {
                    return;
                }

                MessageBox.Show("Update thành công", "", MessageBoxButtons.OK);
                this.cTPNTableAdapter.Fill(this.dS.CTPN);
            }

            cTPNGridControl.Enabled = true;
            groupBox4.Enabled = btnLuuCT.Enabled = false;
            kt_btnSuaCTPN = kt_btnThemCTPN = false;
            btnThemCT.Enabled = btnSuaCT.Enabled = btnXoaCT.Enabled = btnUndoCTPN.Enabled = btnRefreshCTPN.Enabled = true;
        }

        private int KiemTraDuLieuCTPN(string maPN, string maVT, int soLuong, float donGia)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraDuLieu_CTPN", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAPN", maPN);
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

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int vitri = 0;
            vitri = cTPNBindingSource.Position;

            if (MessageBox.Show("Bạn có thật sự muốn xóa CTPN này? ", "Xác nhận",
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
                    string ngay = "select NGAY from dbo.PhieuNhap where MAPN = '" + ((DataRowView)cTPNBindingSource[vitri])["MAPN"] + "'";
                    dr = Program.ExecSqlDataReader(ngay);
                    DateTime ngayNhap = Convert.ToDateTime(ngayHeThong);

                    while (dr.Read())
                    {
                        ngayNhap = dr.GetDateTime(0);
                    }
                    Program.conn.Close();


                    if (ngayNhap <= ngayHienTai)
                    {
                        MessageBox.Show("Bạn không thể xóa CTPN này được!\nPhiếu nhập này đã được nhập hàng\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    string sql = "exec sp_XOA_CTPN '" + ((DataRowView)cTPNBindingSource[vitri])["MAPN"] + "','" + ((DataRowView)cTPNBindingSource[vitri])["MAVT"] + "'";
                    int xoa = Program.ExecSqlNonQuery(sql);

                    if (xoa != 0)
                    {
                        return;
                    }

                    MessageBox.Show("Xóa CTPN thành công", "", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    this.cTPNTableAdapter.Fill(this.dS.CTPN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa CTPN\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                }
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            cmbVatTu.Enabled = false;

            int vitri = 0;
            vitri = cTPNBindingSource.Position;

            txtMAVT.Text = ((DataRowView)cTPNBindingSource[vitri])["MAVT"].ToString();

            //Kiem tra ngày, nếu ngày >= ngày ht thì k cho sửa
            DateTime ngayHeThong = DateTime.Now;
            DateTime ngayHienTai = Convert.ToDateTime(ngayHeThong);

            SqlConnection sqlConnection = new SqlConnection(Program.connstr);
            sqlConnection.Open();

            SqlDataReader dr;
            string ngay = "select NGAY from dbo.PhieuNhap where MAPN = '" + ((DataRowView)cTPNBindingSource[vitri])["MAPN"] + "'";
            dr = Program.ExecSqlDataReader(ngay);
            DateTime ngayNhap = Convert.ToDateTime(ngayHeThong);

            while (dr.Read())
            {
                ngayNhap = dr.GetDateTime(0);
            }
            Program.conn.Close();

            if (ngayNhap <= ngayHienTai)
            {
                MessageBox.Show("Bạn không thể sửa CTPN này được!\nPhiếu nhập này đã được nhập hàng\n", "",
                MessageBoxButtons.OK);
                return;
            }

            btnThemCT.Enabled = btnXoaCT.Enabled = btnSuaCT.Enabled = cTPNGridControl.Enabled = false;
            kt_btnSuaCTPN = btnLuuCT.Enabled = groupBox4.Enabled = true;
        }
    }
}
