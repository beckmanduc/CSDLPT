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
    public partial class frmVatTu : Form
    {
        int vitri = 0;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);

            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnGhi.Enabled = false;
            }

            groupBox1.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = vattuBindingSource.Position;
            groupBox1.Enabled = true;
            vattuBindingSource.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            vattuGridControl.Enabled = false; //Che bảng 

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = vattuBindingSource.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            vattuGridControl.Enabled = false; //Che bảng 
        }

        private int KiemTraThemVatTu(string maVT, string tenVT)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KTVatTu", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAVT", maVT);
                cmd.Parameters.AddWithValue("TENVT", tenVT);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAVT.Text.Trim() == "" || txtTENVT.Text.Trim() == "" || txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư, Tên vật tư hoặc DVT không được thiếu!", "", MessageBoxButtons.OK);
                return;
            }

            if (KiemTraThemVatTu(txtMAVT.Text, txtTENVT.Text) == 1)
            {
                MessageBox.Show("Mã vật tư hoặc tên vật tư đã tồn tại!\nVui lòng nhập mã khác", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return;
            }

            try
            {

                vattuBindingSource.EndEdit(); // thông báo k cho chỉnh sửa nữa
                vattuBindingSource.ResetCurrentItem();
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.dS); // Đẩy về CSDL

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            groupBox1.Enabled = false;
            vattuGridControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maVT = "";
            groupBox1.Enabled = false;

            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (KiemTraXoaVatTu(((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString()) == 1)
                    {
                        MessageBox.Show("Vật tư đã đã được sử dụng.Bạn không thể xóa vật tư này\n", "",
                        MessageBoxButtons.OK);
                        return;
                    }

                    maVT = ((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    vattuBindingSource.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.dS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    vattuBindingSource.Position = vattuBindingSource.Find("MAVT", maVT);
                    return;
                }
            }
        }

        private int KiemTraXoaVatTu(string maVT)
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_KiemTraMaVT_XoaVT", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MAVT", maVT);

                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.dS.Vattu);
                vattuGridControl.Enabled = true;
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
            vattuBindingSource.CancelEdit();
            if (btnThem.Enabled == false || btnSua.Enabled == false) vattuBindingSource.Position = vitri;
            vattuGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }
    }
}
