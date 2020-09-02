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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan(String Role)
        {
            InitializeComponent();
            if (String.Compare(Role, "CONGTY") == 0)
            {
                cmbNhom.Items.Add("CONGTY");
            }
            else
            {
                cmbNhom.Items.Add("CHINHANH");
                cmbNhom.Items.Add("USER");
            }

            cmbNhom.SelectedIndex = 0;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Tên ĐN không được thiếu!", "", MessageBoxButtons.OK);
                txtTenDN.Focus();
                return;
            }

            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã NV không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }

            if (KiemTraMaNVTonTai(Int32.Parse(txtMANV.Text)) != 1)
            {
                MessageBox.Show("Mã NV không tồn tại. Vui lòng nhập mã khác!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            int check = 0;

            try
            {
                check = TaoTaiKhoan(cmbNhom.Text, txtMANV.Text, txtTenDN.Text, txtMatKhau.Text);

                if (check == 1)
                {
                    MessageBox.Show("Tên đăng nhập bị trùng!", "", MessageBoxButtons.OK);
                    txtTenDN.Focus();
                    return;
                }
                else if (check == 2)
                {
                    MessageBox.Show("Mã NV bị trùng!", "", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                    txtMANV.Text = "";
                    txtTenDN.Text = "";
                    txtMatKhau.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản : " + ex.Message);
            }
        }

        private static int TaoTaiKhoan(string group, string userName, string loginName, string pass)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("LGNAME", loginName);
                cmd.Parameters.AddWithValue("PASS", pass);
                cmd.Parameters.AddWithValue("USERNAME", userName);
                cmd.Parameters.AddWithValue("ROLE", group);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private static int KiemTraMaNVTonTai(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaNV_TaoTaiKhoan", conn))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
