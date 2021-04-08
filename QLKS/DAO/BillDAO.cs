using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;


        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private BillDAO() { }

        public int isUncheckBill(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE status=0 AND maPhong=" + id);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaBill;
            }
            return -1;
        }

        public void InsertBill(int maNV,int maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("INSERT dbo.Bill ( maNV  ,maPhong )VALUES  ( "+maNV+", "+maPhong+" )");
        }

        public int getLastBillID()
        {
            //DataProvider provider = new DataProvider();
            object lastBillID = DataProvider.Instance.ExecuteScalar("SELECT MAX(maBill) FROM dbo.Bill");
            return (int)lastBillID;
        }

        public DataTable DoanhThuList(string beginDay, string endDay)
        {

            string query = "SELECT kh.tenKH AS N'Tên khách hàng',p.tenPhong AS N'Tên phòng',b.status AS N'Trạng thái',b.discount AS N'Giảm giá',b.tongTien AS N'Tổng tiền',nv.tenNV AS N'Tên nhân viên' FROM dbo.Bill AS b,dbo.DatPhong AS dp,dbo.KhachHang AS kh,dbo.Phong AS p,dbo.NhanVien AS nv WHERE b.maNV=nv.maNV and b.maPhong=p.maPhong AND kh.maKH=dp.maKH AND b.maBill=dp.maBill AND b.ngayRa BETWEEN '"+beginDay+"' AND '"+endDay+"'";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public bool DelBillByTable(string id)
        {
            string query = " DELETE dbo.Bill WHERE maPhong = " + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool DelBillByUserName(string maNV)
        {

            string query = " DELETE dbo.Bill WHERE maNV = N'" + maNV + "'";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public void ThanhToan(int discount, string tongTien, int billID)
        {
            string query = "UPDATE dbo.Bill SET ngayRa=GETDATE(), status=1 , discount =" + discount + ",tongTien=" + tongTien + " WHERE maBill=" + billID;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public Bill GetBillByRoom(int maPhong)
        {
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill where status=0 and maPhong="+maPhong);
            foreach (DataRow item in dtTable.Rows)
            {
                Bill b = new Bill(item);
                return b;
            }
            return null;
        }
    }
}
