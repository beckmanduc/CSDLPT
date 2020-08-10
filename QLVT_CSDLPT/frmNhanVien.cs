using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVT_CSDLPT
{
    public partial class frmNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";

            macn = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
            cmbChinhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled =btnGhi.Enabled= false;
            }
            else
            {
                panel1.Enabled = false;
            }

            groupBox1.Enabled = txtMACN.Enabled = false;
        }


        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue == null) return;
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();

            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
              

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            groupBox1.Enabled = true;
            nhanVienBindingSource.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            nhanVienGridControl.Enabled = false; //Che bảng 

            
          

           
        }

        private int KiemTraMaNV(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KTMaNVTonTai", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MANV", maNV);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nhanVienBindingSource.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            nhanVienGridControl.Enabled = false; //Che bảng 
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTEN.Text.Trim() == "" || txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (txtMANV.Value < 1)
            {
                MessageBox.Show("Mã NV không hợp lệ!\nVui lòng nhập mã khác", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if (txtLUONG.Value < 4000000)
            {
                MessageBox.Show("Lương không hợp lệ!\nVui lòng nhập số khác (Lương >= 4.000.000)", "", MessageBoxButtons.OK);
                txtLUONG.Focus();
                return;
            }

            if (KiemTraMaNV(Int32.Parse(txtMANV.Value.ToString())) == 1)
            {
                MessageBox.Show("Mã nhân viên bị trùng!\nVui lòng nhập mã khác", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            try
            {              
                    nhanVienBindingSource.EndEdit(); // thông báo k cho chỉnh sửa nữa
                    nhanVienBindingSource.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS); // Đẩy về CSDL
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            nhanVienGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                nhanVienGridControl.Enabled = true;
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maNV = "";
            groupBox1.Enabled = false;

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (KiemTraXoaNhanVien(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString()) == 1)
                    {
                        MessageBox.Show("Nhân viên này có thể đã tạo PN, PX hay DDH.Bạn không thể xóa nhân viên này\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    maNV = ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    nhanVienBindingSource.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", maNV);
                    return;
                }
            }
        }
        private int KiemTraXoaNhanVien(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaNV_XoaNhanVien", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("manv", maNV);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
        }
    }
    
}
