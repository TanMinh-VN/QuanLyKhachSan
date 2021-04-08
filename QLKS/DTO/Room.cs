using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Room
    {
        private int maPhong;
        private string tenPhong;
        private int loaiPhong;
        private int giaPhong;
        private int tinhTrang;

        public int MaPhong
        {
            get
            {
                return maPhong;
            }

            set
            {
                maPhong = value;
            }
        }

        public int LoaiPhong
        {
            get
            {
                return loaiPhong;
            }

            set
            {
                loaiPhong = value;
            }
        }

        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }

            set
            {
                tinhTrang = value;
            }
        }

        public string TenPhong
        {
            get
            {
                return tenPhong;
            }

            set
            {
                tenPhong = value;
            }
        }

        public int GiaPhong
        {
            get
            {
                return giaPhong;
            }

            set
            {
                giaPhong = value;
            }
        }

        public Room(int maPhong,string tenPhong, int loaiPhong,int giaPhong, int tinhTrang)
        {
            this.MaPhong = maPhong;
            this.TenPhong = tenPhong;
            this.LoaiPhong = loaiPhong;
            this.GiaPhong = giaPhong;
            this.TinhTrang = tinhTrang;
        }
        public Room(DataRow dtRow)
        {
            this.MaPhong = (int)dtRow["maPhong"];
            this.LoaiPhong = (int)dtRow["loaiPhong"];
            this.TinhTrang = (int)dtRow["tinhTrang"];
            this.TenPhong = dtRow["tenPhong"].ToString();
            this.GiaPhong = (int)dtRow["giaPhong"];
        }
    }
}
