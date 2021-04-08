using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class DatPhong
    {
        private int maBill;
        private int maKH;
        private int maPhong;
        public DatPhong(int maBill,int maKH,int maPhong)
        {
            this.MaBill = maBill;
            this.MaKH = maKH;
            this.MaPhong = maPhong;
        }
        public DatPhong(DataRow dtRow)
        {
            this.MaBill = (int)dtRow["maBill"];
            this.MaKH = (int)dtRow["maKH"];
            this.MaPhong = (int)dtRow["maPhong"];
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

        public int MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
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
    }
}
