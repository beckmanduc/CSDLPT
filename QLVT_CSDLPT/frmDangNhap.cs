using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLVT_CSDLPT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tENCNComboBox.SelectedValue != null)
            Program.servername = tENCNComboBox.SelectedValue.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập ko được rỗng.", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            //MessageBox.Show("Đăng nhập thành công.", " ", MessageBoxButtons.OK);
            SqlDataReader myReader;
            Program.mChinhanh = tENCNComboBox.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.bds_dspm = bdsDSPM;
            string strLenh = "EXEC sp_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã nhân viên :" + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            myReader.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
