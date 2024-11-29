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
    public partial class fInHoaDon : Form
    {
        public fInHoaDon(int khuyenMai)
        {
            InitializeComponent();

            numKhuyenMai.Value = khuyenMai;

            DateTime now = DateTime.Now;
            now = dateNow.Value;
            dateNow.Value = new DateTime(now.Year, now.Month, now.Day);
        }

        private void fInHoaDon_Load(object sender, EventArgs e)
        { 
            this.hoaDonTTTableAdapter.Fill(this.dataSet1.HoaDonTT, txtRP.Text);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btRP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã số bàn cần in hóa đơn!!");
                }
                else
                {
                    
                    this.hoaDonTTTableAdapter.Fill(this.dataSet1.HoaDonTT, txtRP.Text);
                    Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("tenBan",txtRP.Text),
                        new Microsoft.Reporting.WinForms.ReportParameter("Ngay",dateNow.Text),
                        new Microsoft.Reporting.WinForms.ReportParameter("khuyenMai",numKhuyenMai.Value.ToString())
                    };
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
