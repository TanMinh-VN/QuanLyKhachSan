using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Bill
    {
        private int maBill;
        private int maNV;
        private int maPhong;
        private DateTime? ngayVao;
        private DateTime? ngayRa;
        private int tongTien;
        private int stat;

        public Bill(int maBill, int maNV, int maPhong, DateTime ngayVao, DateTime ngayRa)
        {
            this.MaBill = maBill;
            this.MaNV = maNV;
            this.MaPhong = maPhong;
            this.NgayVao = ngayVao;
            this.NgayRa = ngayRa;
        }
        public Bill(DataRow dtRow)
        {
            this.MaBill = (int)dtRow["maBill"];
            this.MaNV = (int)dtRow["maNV"];
            this.MaPhong = (int)dtRow["maPhong"];
            this.NgayVao = (DateTime?)dtRow["ngayVao"];
            this.NgayRa = (DateTime?)ngayRa;
            this.Stat = (int)dtRow["status"];
        }


        public int MaBill
        {
            get
            {
                return maBill;
            }

            set
            {
                maBill = value;
            }
        }

        public int MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
            }
        }
        

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

        public DateTime? NgayVao
        {
            get
            {
                return ngayVao;
            }

            set
            {
                ngayVao = value;
            }
        }

        public DateTime? NgayRa
        {
            get
            {
                return ngayRa;
            }

            set
            {
                ngayRa = value;
            }
        }

        public int TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public int Stat
        {
            get
            {
                return stat;
            }

            set
            {
                stat = value;
            }
        }
    }
}
