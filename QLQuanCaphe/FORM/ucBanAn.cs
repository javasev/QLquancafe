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
    public partial class ucBanAn : UserControl
    {
        BindingSource tableList = new BindingSource();
        public ucBanAn()
        {
            InitializeComponent();
            dgvBanAn.DataSource = tableList;
            AddTableBinding();
            LoadListTable();
        }

        //Panel DS bàn

        void AddTableBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "ID"));
            txtTenBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
            txtTrangThaiBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Status"));
        }

        void LoadListTable() //Lấy danh sách bàn
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }

        private void btThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenBan.Text;
                string status = txtTrangThaiBan.Text;
                DialogResult check = MessageBox.Show($"Bạn có muốn thêm bàn {txtTenBan.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (TableDAO.Instance.InsertTable(name, status))
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        LoadListTable();
                        if (insertTable != null) //Kiểm tra bàn đó có chưa
                            insertTable(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm bàn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDBan.Text);

                DialogResult check = MessageBox.Show($"Bạn có muốn xóa bàn {txtTenBan.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (TableDAO.Instance.DeleteTable(id))
                    {
                        MessageBox.Show("Xóa bàn thành công.");
                        LoadListTable();
                        if (deleteTable != null)
                            deleteTable(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa bàn");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaBan_Click(object sender, EventArgs e)
        {
            string status = txtTrangThaiBan.Text;
            string name = txtTenBan.Text;
            int id = Convert.ToInt32(txtIDBan.Text);

            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadListTable();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
        }

        private void btXemBan_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        //DS Bàn
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

    }
}
