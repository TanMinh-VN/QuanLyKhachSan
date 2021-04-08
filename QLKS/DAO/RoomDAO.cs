using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;


        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RoomDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private RoomDAO() { }
        public List<Room> LoadRoom_fOrder()
        {
            List<Room> roomList = new List<Room>();

            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong");
            foreach (DataRow item in dtTable.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }
            return roomList;
        }
        //public bool AddRoom(int type, int status, string name,int price)
        //{
        //    string query = "INSERT dbo.Phong( loaiPhong, tinhTrang, tenPhong,giaPhong )VALUES  ( "+type+", "+status+",  N'"+name+"',"+price+" )";
        //    int successRows = DataProvider.Instance.ExecuteNonQuery(query);
        //    return successRows > 0;
        //}

        public DataTable RoomList()
        {
            string query = "SELECT maPhong AS N'Mã phòng',tenPhong AS N'Tên phòng',loaiPhong AS N'Loại phòng'  ,giaPhong AS N'Giá phòng',tinhTrang AS N'Trạng thái' FROM dbo.Phong  ";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public DataTable SearchRoom(string keyWord)
        {
            string query = "SELECT maPhong AS N'Mã phòng',tenPhong AS N'Tên phòng',loaiPhong AS N'Loại phòng'  ,giaPhong AS N'Giá phòng',tinhTrang AS N'Trạng thái' FROM dbo.Phong WHERE (tenPhong LIKE N'%" + keyWord + "%') ";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public bool EditRoom(int type, int status, string name, int price,int id)
        {
            string query = "UPDATE dbo.Phong SET tenPhong=N'" + name + "' , loaiPhong= " + type + " ,tinhTrang=" + status + ", giaPhong="+price+" WHERE maPhong= " + id;

            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool DelRoom(int id)
        {
            string query = " DELETE dbo.Phong WHERE maPhong = " + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

    }
}
