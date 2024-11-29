using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCaphe.DTO
{
    class BillInfo
    {
        int id;
        int idBill;
        int idProduct;
        int count;
        public BillInfo(int id, int idBill, int idProduct, int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdProduct = idProduct;
            this.Count = count;
        }
        public BillInfo(DataRow data)
        {
            this.Id = (int)data["id"];
            this.IdBill = (int)data["idBill"];
            this.IdProduct = (int)data["idProduct"];
            this.Count = (int)data["count"];
        }
        public int Id { get => id; set => id = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public int Count { get => count; set => count = value; }
    }
}
