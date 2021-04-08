using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool AddGuest(string tenKH, string cmnd, string phoneNumber, string address)
        {
            string query = "INSERT dbo.KhachHang( tenKH ,CMND  ,guestPhoneNumber,guestAddress)VALUES  ( N'" + tenKH + "' , '" + cmnd + "' , '" + phoneNumber + "' ,N'"+address+"')";
            int successRows= DataProvider.Instance.ExecuteNonQuery(query);
            //int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public bool EditGuest(int id,string ten,string cmnd,string phone,string address)
        {
            string query = "UPDATE dbo.KhachHang SET tenKH=N'"+ten+"',CMND='"+cmnd+"',guestPhoneNumber='"+phone+"',guestAddress='"+address+"' WHERE maKH="+id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public bool DelGuest(int id)
        {
            string query = "Delete KhachHang where maKH=" + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            //int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public DataTable GuestList()
        {
            string query = "SELECT maKH AS N'Mã khách hàng', tenKH AS N'Tên khách hàng', CMND ,guestPhoneNumber AS N'Số điện thoại', guestAddress N'Địa chỉ' FROM dbo.KhachHang";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }
        public DataTable SearchGuest(string someInfo)
        {
            string query = "SELECT maKH AS N'Mã khách hàng', tenKH AS N'Tên khách hàng', CMND ,guestPhoneNumber AS N'Số điện thoại', guestAddress N'Địa chỉ' FROM dbo.KhachHang KhachHang where CMND='" + someInfo + "' or guestPhoneNumber='" + someInfo + "'";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }
        public KhachHang getInfoKH(string someInfo)
        {
            string query = "Select * from KhachHang where tenKH=N'"+someInfo+ "' or CMND='" + someInfo + "' or guestPhoneNumber='" + someInfo + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KhachHang kh = new KhachHang(item);
                return kh;
            }
            return null;

        }
        public ThongTinDatPhong GetKHByMaBill(int id)
        {
            string query = "SELECT kh.tenKH,p.tenPhong,dp.soNguoi,kh.CMND,kh.guestPhoneNumber FROM dbo.Bill AS b,dbo.DatPhong AS dp, dbo.KhachHang AS kh ,dbo.Phong AS p WHERE b.maPhong=p.maPhong AND  b.maBill=dp.maBill AND dp.maKH=kh.maKH AND b.maBill=" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ThongTinDatPhong dp = new ThongTinDatPhong(item);
                return dp;
            }
            return null;

        }

    }
}
