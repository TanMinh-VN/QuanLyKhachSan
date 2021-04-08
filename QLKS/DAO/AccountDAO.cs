using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private AccountDAO() { }

        public Account GetAccByUsername(string userName)
        {
            //DataProvider provider = new DataProvider();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE userName=N'" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                Account acc = new Account(item);
                return acc;
            }
            return null;
        }

        public bool AddAcc(string userName, string displayName, int type,int maNV)
        {
            string query = "INSERT dbo.Account( userName ,displayName  ,type,maNV)VALUES  ( '" + userName + "' ,N'" + displayName + "'," + type + ","+maNV+")";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public DataTable AccList()
        {
            string query = "SELECT userName AS N'Tên đăng nhập',displayName AS N'Tên hiển thị',type AS N'Loại tài khoản',n.tenNV AS N'Tên nhân viên'  FROM dbo.Account a INNER JOIN dbo.NhanVien n ON n.maNV = a.maNV";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }


        public bool EditAcc(string displayName, int type, string userName, int maNV)
        {
            string query = "UPDATE dbo.Account SET displayName=N'" + displayName + "',type=" + type + ",maNV="+maNV+" WHERE userName= N'" + userName + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool DelAcc(string userName)
        {
            string query = " DELETE dbo.Account WHERE userName = N'" + userName + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            AccList();
            return successRows > 0;
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE userName = N'" + username + "' AND pass = N'" + password + "'";
            DataTable dtTable = new DataTable();
            dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable.Rows.Count > 0;
        }

        public bool ChangeName(string displayName, string userName)
        {
            string query = "UPDATE dbo.Account SET displayName=N'" + displayName + "' WHERE userName=N'" + userName + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool ChangePass(string repass, string userName)
        {
            string query = "UPDATE dbo.Account SET pass=N'" + repass + "' WHERE userName=N'" + userName + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool ResetPass(string userName)
        {
            string query = "UPDATE dbo.Account SET pass=9999 WHERE userName = N'" + userName + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

    }
}
