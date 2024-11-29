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
    public partial class ucDanhMuc : UserControl
    {
        BindingSource productList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        public ucDanhMuc()
        {
            InitializeComponent();
            LoadListCategory();
            dgvDanhMuc.DataSource = categoryList;
            AddCategoryBinding();
        }

        //Panel Danh mục
        void AddCategoryBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDDanhmuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "ID"));
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "Name"));
        }
        void LoadCategory() //Lấy danh sách danh mục vào combobox DM ở Hóa đơn
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
        }
        void LoadListProduct() //Lấy danh sách món ăn
        {
            productList.DataSource = ProductDAO.Instance.GetListProduct();
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        private void btThemDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenDanhMuc.Text;

                if (CategoryDAO.Instance.InsertCategory(name))
                {
                    MessageBox.Show("Thêm danh mục " + txtTenDanhMuc.Text.Trim() +"thành công");
                    LoadListCategory();
                    if (insertCategory != null) //Kiểm tra danh mục đó có chưa
                        insertCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm danh mục");
                }
                LoadCategory(); //Câp nhật lại combobox danh mục
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoaDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                //category.Name = txtTenDanhMuc.Text;
                int id = Convert.ToInt32(txtIDDanhmuc.Text);
                DialogResult check = MessageBox.Show($"Bạn có muốn xóa danh mục {txtTenDanhMuc.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (CategoryDAO.Instance.DeleteCategory(id))
                    {
                        LoadListCategory();
                        if (deleteCategory != null)
                            deleteCategory(this, new EventArgs());
                        MessageBox.Show("Xóa danh mục thành công");
                    }
                    else
                    {
                        //MessageBox.Show("Có lỗi khi xóa danh mục");
                        MessageBox.Show("Xóa danh mục thành công");
                    }
                }
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                //category.Name = txtTenDanhMuc.Text;
                int id = Convert.ToInt32(txtIDDanhmuc.Text);
                DialogResult check = MessageBox.Show($"Bạn có muốn sửa danh mục {txtTenDanhMuc.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (CategoryDAO.Instance.UpdateCategory(txtTenDanhMuc.Text,id))
                    {
                        LoadListCategory();
                        if (updateCategory != null)
                            updateCategory(this, new EventArgs());
                        MessageBox.Show("Sửa danh mục thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa danh mục thành công");
                    }
                }
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXemDanhMuc_Click(object sender, EventArgs e)
        { 
            LoadListCategory();
            txtIDDanhmuc.Text = "";
            txtTenDanhMuc.Text = "";
        }

        //Danh mục
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

    }
}
