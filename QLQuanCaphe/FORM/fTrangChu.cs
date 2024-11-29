using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCaphe.FORM
{
    public partial class fTrangChu : Form
    {
        public static string ten = null;
        public static string quyenhan = null;
        public fTrangChu()
        {
            InitializeComponent();
            load(); 

        }

        private void load()
        {
            lbTenNV.Text = "Chào: " + ten;
            lbquyen.Text = quyenhan;

            if (quyenhan == "Staff")
            {
                btDanhMuc.Enabled = false;
                btTaikhoan.Enabled = false;
                btMonAn.Enabled = false;
                btDoanhThu.Enabled = false;
                btDSBan.Enabled = false;
            }
            else
            {
                btDanhMuc.Enabled = true;
                btTaikhoan.Enabled = true;
                btMonAn.Enabled = true;
                btDoanhThu.Enabled = true;
                btDSBan.Enabled = true;
            }

        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            load();
            ucTrangChu rp = new ucTrangChu();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btDSBan_Click(object sender, EventArgs e)
        {
            ucBanAn rp = new ucBanAn();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btMonAn_Click(object sender, EventArgs e)
        {
            ucSanPham rp = new ucSanPham();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btDanhMuc_Click(object sender, EventArgs e)
        {
            ucDanhMuc rp = new ucDanhMuc();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btHoadon_Click(object sender, EventArgs e)
        {
            ucHoaDon rp = new ucHoaDon();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            ucDoanhThu rp = new ucDoanhThu();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btTaikhoan_Click(object sender, EventArgs e)
        {
            ucTaiKhoan rp = new ucTaiKhoan();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ucTrangChu rp = new ucTrangChu();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(rp);
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap fDangNhap = new fDangNhap();
            fDangNhap.Show();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Tạo nút ẩn phần mềm xuống taskbar
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
