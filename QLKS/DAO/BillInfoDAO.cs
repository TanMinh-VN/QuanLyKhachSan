using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;


        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInfoDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BillInfoDAO() { }

        public void InsertChiTietHD(int billID, int foodID, int soLuong)
        {
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo " + billID + ", " + foodID + ", " + soLuong);
        }

        //public void DelAllChitietHD()
        //{
        //    string query = " DELETE dbo.ChitietHD";
        //    int successRows = DataProvider.Instance.ExecuteNonQuery(query);
        //}

        public bool DelBillInfoByServiceID(string maDV)
        {
            string query = " DELETE dbo.BillInfo WHERE MaDV= " + maDV;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
    }
}
