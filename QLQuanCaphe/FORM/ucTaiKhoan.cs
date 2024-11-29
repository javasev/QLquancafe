using QLQuanCaphe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLQuanCaphe.FORM
{
    public partial class ucTaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();
        public ucTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = accountList;
            LoadListAccount();
        }

        //Panel Tài khoản 

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string userName, string fullName, string type) //Thêm tài khoản
        {
            if (AccountDAO.Instance.InsertAccount(userName, fullName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadListAccount();
        }

        void EditAccount(string userName, string fullName, string type) //Sửa tài khoản
        {
            if (AccountDAO.Instance.UpdateAccount(userName, fullName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadListAccount();
        }

        void DeleteAccount(string userName) //Xóa tài khoản
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadListAccount();
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTenTaiKhoan.Text;
                string fullName = txtTenNV.Text;
                string type = txtLoaiTK.Text;

                if (userName.Equals(""))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!!!");
                }
                else
                {
                    AddAccount(userName, fullName, type);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên dăng nhập đã tồn tại hoặc có vấn đề gì đó đang xảy ra cần kiểm tra lại!!!");
            }
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTenTaiKhoan.Text;

                if (userName.Equals(""))
                {
                        MessageBox.Show("Bạn chưa chọn tài khoản cần xóa???");
                }
                else if(userName.Equals("admin"))
                {
                    MessageBox.Show("Không thể xóa tài khoản admin!!!");
                }
                else
                {
                    DialogResult check = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản này???","",MessageBoxButtons.YesNo);
                    if (check == DialogResult.Yes)
                    {
                        DeleteAccount(userName);
                    }
                }
            }
            catch
            {
            }
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTaiKhoan.Text.Equals(""))
                {
                    MessageBox.Show("Bạn đã chọn tài khoản cần sửa chưa mà đòi sửa???");
                }
                string userName = txtTenTaiKhoan.Text;
                string fullName = txtTenNV.Text;
                string type = txtLoaiTK.Text;

                EditAccount(userName, fullName, type);
            }
            catch
            {
            }
        }

        private void btXemTK_Click(object sender, EventArgs e)
        {
            LoadListAccount();
            txtTenTaiKhoan.Text = "";
            txtLoaiTK.Text = "Staff";
        }

        private void btCaiDatMK_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenTaiKhoan.Text.Equals("") && txtTenNV.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần thay đổi mật khẩu!!!");
                }
                else
                {
                    fDoiMK f = new fDoiMK(txtTenTaiKhoan.Text, txtTenNV.Text); //Mở form cài đặt lại mật khẩu (khai báo biến liên kết form DoiMK)
                    f.Show();
                }
            }
            catch { }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenTaiKhoan.Text = data.Cells[0].Value.ToString();
                txtTenNV.Text = data.Cells[1].Value.ToString();
                txtLoaiTK.Text = data.Cells[2].Value.ToString();
            }
            catch { }
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
