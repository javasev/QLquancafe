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

namespace QLQuanCaphe.FORM
{
    public partial class fDoiMK : Form
    {
        public fDoiMK(string tenDangnhap, string hoTen)
        {
            InitializeComponent();
            txtTenDangNhap.Text = tenDangnhap;
            txtTen.Text = hoTen;
        }

        void ResetPass(string userName, string passWord)
        {
            if (AccountDAO.Instance.ResetPassword(userName, passWord))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công.");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại.");
            }
        }

        private void btCapNhatMK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTenDangNhap.Text;
                string fullName = txtTen.Text;
                string password = txtMKCu.Text;
                string newPassWord = txtMKMoi.Text;
                string reenterPass = txtNhaplaiMK.Text;

                if (!newPassWord.Equals(reenterPass))
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
                }
                else
                {
                    if (AccountDAO.Instance.UpdatePassWordAccount(userName, fullName, password, newPassWord))
                    {
                        ResetPass(userName, newPassWord);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đúng mật khấu");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btThoatCN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
