using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class BillShowDAO
    {
        private static BillShowDAO instance;
        public static BillShowDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillShowDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BillShowDAO() { }
        public List<BillShow> GetBillShowByRoom(int id)
        {
            List<BillShow> billShow = new List<BillShow>();
            string query = "SELECT dv.tenDV,bi.soLuong,dv.giaDV,bi.soLuong*dv.giaDV AS thanhTien  FROM dbo.Bill AS b,dbo.BillInfo AS bi,dbo.DichVu AS dv WHERE b.maBill=bi.maBill AND bi.maDV=dv.maDV AND b.status=0 and b.maPhong=" + id;
            //string query = "SELECT f.foodName,hd.soLuong,f.price,f.price*hd.soLuong AS N'thanhTien' FROM dbo.Bill AS b,dbo.ChitietHD AS hd,dbo.Food AS f WHERE hd.billID = b.billID AND hd.foodID = f.foodID AND b.stat=0 AND b.IDtable = " + id;
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dtTable.Rows)
            {
                BillShow bShow = new BillShow(item);
                billShow.Add(bShow);
            }
            return billShow;

        }
    }
}
