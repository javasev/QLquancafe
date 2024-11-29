using QLQuanCaphe.DAO;
using QUANLYNHANSU;
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

namespace QLQuanCaphe.FORM
{
    public partial class fDangNhap : Form
    {
        DataTable dt = new DataTable();
        SqlDataReader dr;
        SDataReader cl = new SDataReader();
        public fDangNhap()
        {
            InitializeComponent();
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private string GetNameAccount(string tk, string mk)
        {
            string ten = null;
            dr = cl.GetNameAccount(tk,mk);
            while (dr.Read())
            {
                ten = dr.GetString(0);
            }
            return ten;
        }

        private string GetTypeAccount(string tk, string mk)
        {
            string qh = null;
            dr = cl.GetTypeAccount(tk, mk);
            while (dr.Read())
            {
                qh = dr.GetString(0);
            }
            return qh;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTaiKhoan.Text;
                string passWord = txtMatKhau.Text;
                if (Login(userName, passWord))
                { 
                    fTrangChu quanLy = new fTrangChu();
                    fTrangChu.ten = GetNameAccount(userName, passWord);
                    fTrangChu.quyenhan = GetTypeAccount(userName, passWord);
                    this.Hide();
                    quanLy.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btHide.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btShow.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btTat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
