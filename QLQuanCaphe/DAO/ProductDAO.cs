using QLQuanCaphe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLQuanCaphe.DAO
{
    class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        public List<Product> GetProductByCategoryID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }

        public List<Product> SearchProductByName(string name)
        {
            List<Product> list = new List<Product>();

            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }
            return list;
        }

        //Xóa món ăn thuộc mã loại = ??
        public void DeleteProductByCategoryID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.Product WHERE idCategory = " + id);
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }
            return list;
        }

        public bool InsertProduct(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Product ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(int idProduct, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Product SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idProduct);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteProduct(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByProductID(id);
            string query = string.Format("Delete Product where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
