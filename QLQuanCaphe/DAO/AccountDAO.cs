using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using QLQuanCaphe.DAO;
using QLQuanCaphe.DTO;

namespace QLQuanCaphe.DAO
{
    class AccountDAO
    {

        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool UpdatePassWordAccount(string userName, string fullName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @fullName , @password , @newPassword", new object[] { userName, fullName, pass, newPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, FullName, Type FROM dbo.Account");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                //return new Account(item);
            }

            return null;
        }

        public Account GetTypeByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select type from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                //return new Account(item);
            }

            return null;
        }

        public Account GetNameByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select fullname from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                //return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string name, string fullName, string type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, FullName, Type )VALUES  ( N'{0}', N'{1}', N'{2}')", name, fullName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string fullName, string type)
        {
            string query = string.Format("UPDATE dbo.Account SET Type = '{0}', FullName = N'{1}' WHERE UserName = N'{2}'", type, fullName, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name, string pass)
        {
            string query = string.Format("Update Account set Password = N'{0}' where UserName = N'{1}'", pass, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
