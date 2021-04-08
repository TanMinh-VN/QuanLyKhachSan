using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class DatPhongDAO
    {
        private static DatPhongDAO instance;
        public static DatPhongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatPhongDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private DatPhongDAO() { }
        public bool AddDatPhong(int billID,int maKH,int soNguoi)
        {
            string query = "INSERT dbo.DatPhong( maBill, maKH,soNguoi )VALUES  ( "+billID+","+maKH+","+soNguoi+" )";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
    }
}
