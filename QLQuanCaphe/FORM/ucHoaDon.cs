using QLQuanCaphe.DAO;
using QLQuanCaphe.DTO;
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
    public partial class ucHoaDon : UserControl
    {
        BindingSource productList = new BindingSource();
        BindingSource tableList = new BindingSource();
        public ucHoaDon()
        {
            InitializeComponent();
            LoadTable();
            LoadListProduct();
            LoadListTable();
            LoadCategory();
            LoadComboboxTable(cbChuyenBan);
        }

        void LoadComboboxTable(ComboBox cb) //Load ra danh sách combobox bàn để có thể chọn chuyển bàn
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void LoadCategory() //Lấy danh sách danh mục vào combobox DM ở Hóa đơn
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbDanhMucMon.DataSource = listCategory; //Combobox Danh Mục ở Hóa đơn
            cbDanhMucMon.DisplayMember = "Name";

        }
        void LoadProductListByCategoryID(int id) //Lấy danh sách món ăn từ id danh mục
        {
            List<Product> listProduct = ProductDAO.Instance.GetProductByCategoryID(id);
            cbMonAn.DataSource = listProduct;
            cbMonAn.DisplayMember = "Name";
        }

        void LoadListProduct() //Lấy danh sách món ăn
        {
            productList.DataSource = ProductDAO.Instance.GetListProduct();
        }

        void LoadListTable() //Lấy danh sách bàn
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }

        public void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.ForeColor = Color.Black; // chỉnh chữ màu đen
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    //Bàn không có khách
                    case "Trống":
                        btn.BackColor = Color.SandyBrown;
                        btn.TextAlign = ContentAlignment.TopLeft; //chỉnh chữ nằm góc trên bên trái
                        break;

                    //Bàn đã có khách
                    default:
                        btn.BackColor = Color.PeachPuff;
                        btn.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                }
                flpTable.Controls.Add(btn);
                LoadListTable(); //Khi bàn bên hóa đơn thay đổi trạng thái thì bảng ở ds bàn cũng cập nhật
            }
        }
        void btn_Click(object sender, EventArgs e) //taọ button bàn cho flowpanel hiện bàn
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvHoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void ShowBill(int id)   //Hiện hóa đơn các món của bàn ăn
        {
            lvHoaDon.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice; //Cộng tiền các món ăn lại
                lvHoaDon.Items.Add(lsvItem); //Món ăn được thêm vào hóa đơn
            }

            CultureInfo culture = new CultureInfo("vi-VN"); // Ở chổ tính tiền sẽ hiện đơn vị tiền VN
            txtTotalPrice.Text = totalPrice.ToString("c", culture); // Hiện tiền kiểu 0.000

            //Thread.CurrentThread.CurrentCulture = culture;
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            try
            {
                Table table = lvHoaDon.Tag as Table;

                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn!!");
                    return;
                }

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int ProductID = (cbMonAn.SelectedItem as Product).ID;
                int count = (int)numDemMon.Value;

                if (idBill == -1)
                {
                    MessageBox.Show("Đã thêm món thành công");
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), ProductID, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, ProductID, count);
                }
                ShowBill(table.ID);
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInHoaDon_Click(object sender, EventArgs e)
        {
            int discount = (int)numGiamGia.Value;
            fInHoaDon rp = new fInHoaDon(discount);
            rp.ShowDialog();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvHoaDon.Tag as Table;

                int discount = (int)numGiamGia.Value;

                double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount; //Tính tổng tiền khi có giảm giá
                if (table == null)
                {
                    MessageBox.Show("Vui lòng chọn bàn cần thanh toán!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                    if (idBill != -1)
                    {
                        if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            fInHoaDon rp = new fInHoaDon(discount);
                            rp.ShowDialog();
                        }
                        if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn cho bàn {0} \nTổng tiền - (Tổng tiền / 100) x Giảm giá \n => {1:#,##0.##0} - ({1:#,##0.##0} / 100) x {2} = {3:#,##0.##0}",
                                                        table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                            ShowBill(table.ID);
                            LoadTable();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChuyenBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = (lvHoaDon.Tag as Table).ID;

                int id2 = (cbChuyenBan.SelectedItem as Table).ID;
                if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lvHoaDon.Tag as Table).Name, (cbChuyenBan.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.SwitchTable(id1, id2);

                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDanhMucMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadProductListByCategoryID(id);
        }
    }
}
