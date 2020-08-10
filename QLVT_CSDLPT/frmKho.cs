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
    public partial class frmKho : Form
    {
        int vitri = 0;
        string macn = "";
        public frmKho()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            macn = ((DataRowView)khoBindingSource[0])["MACN"].ToString();
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                panel1.Enabled = false;
            }

            txtMACN.Enabled = groupBox1.Enabled = false;

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
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khoBindingSource.Position;
            groupBox1.Enabled = true;
            khoBindingSource.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            khoGridControl.Enabled = false; //Che bảng 

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = khoBindingSource.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            khoGridControl.Enabled = false; //Che bảng 

        }

        private int KiemTraMaKho(string maKho)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KTMaKho", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAKHO", maKho);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private int KiemTraTenKho(string tenKho)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KTTenKho", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TENKHO", tenKho);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKHO.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được thiếu!", "", MessageBoxButtons.OK);
                txtMAKHO.Focus();
                return;
            }

            if (txtTENKHO.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được thiếu!", "", MessageBoxButtons.OK);
                txtTENKHO.Focus();
                return;
            }

            if (KiemTraMaKho(txtMAKHO.Text) == 1)
            {
                MessageBox.Show("Mã kho bị trùng!\nVui lòng nhập mã khác", "", MessageBoxButtons.OK);
                txtMAKHO.Focus();
                return;
            }

            if (KiemTraTenKho(txtTENKHO.Text) == 1)
            {
                MessageBox.Show("Tên kho bị trùng!\nVui lòng nhập tên khác", "", MessageBoxButtons.OK);
                txtTENKHO.Focus();
                return;
            }

            try
            {
                    khoBindingSource.EndEdit(); // thông báo k cho chỉnh sửa nữa
                    khoBindingSource.ResetCurrentItem();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dS); // Đẩy về CSDL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            khoGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKho = "";
            groupBox1.Enabled = false;

            if (MessageBox.Show("Bạn có thật sự muốn xóa kho này? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (KiemTraXoaKho(((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString()) == 1)
                    {
                        MessageBox.Show("Kho này có thể đã có trong PN, PX hay DDH.Bạn không thể xóa kho này\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    maKho = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    khoBindingSource.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.dS.Kho);
                    khoBindingSource.Position = khoBindingSource.Find("MAKHO", maKho);
                    return;
                }
            }
        }

        private int KiemTraXoaKho(string maKho)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaKho_XoaKho", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAKHO", maKho);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);
                khoGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
            }
            else
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = btnThoat.Enabled = true;

            groupBox1.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoBindingSource.CancelEdit();
            if (btnThem.Enabled == false || btnSua.Enabled == false) khoBindingSource.Position = vitri;
            khoGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }
    }
}
