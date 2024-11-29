using QLQuanCaphe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCaphe.FORM
{
    public partial class ucDoanhThu : UserControl
    {
        public ucDoanhThu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
        }

        void LoadDateTimePickerBill() //Lấy thời gian từ datetimepicker
        {
            //Thống kê
            DateTime today = DateTime.Now;
            dateTuNgay.Value = dateTuNgay.Value.AddYears(1).AddMonths(0).AddDays(0);
            dateDenNgay.Value = new DateTime(today.Year, today.Month, today.Day);
            //Report
            DateTime todayrp = DateTime.Now;
            dateTuNgay.Value = new DateTime(today.Year, today.Month, today.Day);
            dateDenNgay.Value = dateTuNgay.Value.AddMonths(1).AddDays(-1);
        }


        public void tinhTongDoanhThu() //Tính tổng doanh thu
        {
            try
            {
                int tien = dgvDoanhThu.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhtien += float.Parse(dgvDoanhThu.Rows[i].Cells["Tongtien"].Value.ToString());
                }
                txtTongDoanhThu.Text = thanhtien.ToString();
                CultureInfo culture = new CultureInfo("vi-VN"); // Ở chổ tính tiền sẽ hiện đơn vị tiền VN
                txtTongDoanhThu.Text = thanhtien.ToString("C2", culture); // Hiện tiền kiểu 0.00
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)//Xuất danh sách hóa đơn theo thời gian chọn
        {
            dgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTuNgay.Value, dateDenNgay.Value);
            tinhTongDoanhThu();
        }
    }
}
