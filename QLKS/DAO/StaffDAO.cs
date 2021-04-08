using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private StaffDAO() { }


        public bool AddStaff(string ten,string address,string phone)
        {
            string query = "INSERT dbo.NhanVien ( tenNV ,staffAddress ,staffPhoneNumber)VALUES  ( N'"+ten+"' , N'"+address+"' ,'"+phone+"' )";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            //int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public bool EditStaff(int id, string ten,  string address, string phone)
        {
            string query = "UPDATE dbo.NhanVien SET tenNV=N'" + ten + "' ,staffAddress= N'" + address + "' ,staffPhoneNumber='" + phone + "' WHERE maNV=" + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public bool DelStaff(int id)
        {
            string query = "Delete NhanVien where maNV=" + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            //int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public DataTable StaffList()
        {
            string query = "SELECT maNV AS N'Mã nhân viên',tenNV AS N'Tên nhân viên',staffAddress AS N'Địa chỉ',staffPhoneNumber AS N'Số điện thoại' FROM dbo.NhanVien";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }
        public DataTable SearchStaff(string keyWord)
        {
            string query = "SELECT maNV AS N'Mã nhân viên',tenNV AS N'Tên nhân viên',staffAddress AS N'Địa chỉ',staffPhoneNumber AS N'Số điện thoại' FROM dbo.NhanVien  WHERE (tenNV LIKE N'%" + keyWord + "%')";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }
        public List<Staff> GetListStaff()
        {
            List<Staff> lStaff = new List<Staff>();
            //DataProvider provider = new DataProvider();
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien");
            foreach (DataRow item in dtTable.Rows)
            {
                Staff staff = new Staff(item);
                lStaff.Add(staff);
            }
            return lStaff;
        }

        public Staff GetStaffByUserName(string userName)
        {

            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT nv.maNV,nv.tenNV,nv.staffAddress,nv.staffPhoneNumber FROM dbo.NhanVien nv INNER JOIN dbo.Account a ON a.maNV = nv.maNV WHERE a.userName='"+userName+"'");
            foreach (DataRow item in dtTable.Rows)
            {
                Staff staff = new Staff(item);
                return staff;
            }
            return null;
        }
        public Staff GetStaffByBillID(int id)
        {

            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT nv.maNV,nv.tenNV,nv.staffAddress,nv.staffPhoneNumber FROM dbo.NhanVien nv INNER JOIN dbo.Bill b ON b.maNV = nv.maNV AND b.maBill=" + id );
            foreach (DataRow item in dtTable.Rows)
            {
                Staff staff = new Staff(item);
                return staff;
            }
            return null;
        }
    }
}
