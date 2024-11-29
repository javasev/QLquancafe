using QLQuanCaphe.DAO;
using QLQuanCaphe.DTO;
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
    public partial class ucSanPham : UserControl
    {
        BindingSource productList = new BindingSource();
        public ucSanPham()
        {
            InitializeComponent();
            dgvMonAn.DataSource = productList;
            AddProductBinding();
            LoadListProduct();
            LoadCategoryComboBox(cbDMThucAn);
        }

        // Panel Thực đơn món ăn
        void AddProductBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDMonAn.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtMonAn.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numGiaThucAn.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadListProduct() //Lấy danh sách món ăn
        {
            productList.DataSource = ProductDAO.Instance.GetListProduct();
        }
        List<Product> SearchProductByName(string name) // Tìm món ăn gần giống với từ đã nhập
        {
            List<Product> listProduct = ProductDAO.Instance.SearchProductByName(name);

            return listProduct;
        }
        void LoadCategoryComboBox(ComboBox cb) //Lấy danh sách danh mục vào combobox DM ở Thực đơn
        {
            cbDMThucAn.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        private void btTimMonAn_Click(object sender, EventArgs e)
        {
            productList.DataSource = SearchProductByName(txtTimMonAn.Text);
        }

        private void btThemThucDon_Click(object sender, EventArgs e)
        {
            string name = txtMonAn.Text;
            int categoryID = (cbDMThucAn.SelectedItem as Category).ID;
            float price = (float)numGiaThucAn.Value;
            if (name.Equals("") || price.Equals("") || categoryID == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else
            {
                try
                {
                    DialogResult check = MessageBox.Show($"Bạn có muốn thêm món {txtMonAn.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        if (ProductDAO.Instance.InsertProduct(name, categoryID, price))
                        {
                            MessageBox.Show("Thêm món ăn thành công");
                            LoadListProduct();
                            if (insertProduct != null) //Kiểm tra món đó có chưa
                                insertProduct(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm thức ăn");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btXoaThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDMonAn.Text);
                DialogResult check = MessageBox.Show($"Bạn có muốn xóa món {txtMonAn.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (ProductDAO.Instance.DeleteProduct(id))
                    {
                        MessageBox.Show("Xóa món thành công");
                        LoadListProduct();
                        if (deleteProduct != null)
                            deleteProduct(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa thức ăn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtMonAn.Text;
                int categoryID = (cbDMThucAn.SelectedItem as Category).ID;
                float price = (float)numGiaThucAn.Value;
                int id = Convert.ToInt32(txtIDMonAn.Text);

                if (ProductDAO.Instance.UpdateProduct(id, name, categoryID, price))
                {
                    MessageBox.Show("Sửa món thành công");
                    LoadListProduct();
                    if (updateProduct != null)
                        updateProduct(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thức ăn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXemMon_Click(object sender, EventArgs e)
        {
            LoadListProduct();
            txtIDMonAn.Text = "";
            txtMonAn.Text = "";
        }

        private void txtIDMonAn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonAn.SelectedCells.Count > 0)
                {
                    int id = (int)dgvMonAn.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbDMThucAn.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbDMThucAn.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDMThucAn.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDMThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
        }


        private event EventHandler insertProduct;
        public event EventHandler InsertProduct
        {
            add { insertProduct += value; }
            remove { insertProduct -= value; }
        }

        private event EventHandler deleteProduct;
        public event EventHandler DeleteProduct
        {
            add { deleteProduct += value; }
            remove { deleteProduct -= value; }
        }

        private event EventHandler updateProduct;
        public event EventHandler UpdateProduct
        {
            add { updateProduct += value; }
            remove { updateProduct -= value; }
        }
    }
}
