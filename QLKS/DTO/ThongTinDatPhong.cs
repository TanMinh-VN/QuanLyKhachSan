using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class ThongTinDatPhong
    {
        private string tenKH;
        private string tenPhong;
        private int soNguoi;
        private string cmnd;
        private string phone;
        public ThongTinDatPhong(string tenKH, string tenPhong, int soNguoi, string cmnd, string phone)
        {
            this.TenKH = tenKH;
            this.TenPhong = tenPhong;
            this.SoNguoi = soNguoi;
            this.Cmnd = cmnd;
            this.Phone = phone;
        }
        public ThongTinDatPhong(DataRow dtRow)
        {
            this.TenKH = dtRow["tenKH"].ToString();
            this.TenPhong = dtRow["tenPhong"].ToString();
            this.SoNguoi = (int)dtRow["soNguoi"];
            this.Cmnd = dtRow["CMND"].ToString();
            this.Phone = dtRow["guestPhoneNumber"].ToString();
        }

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
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

        public int SoNguoi
        {
            get
            {
                return soNguoi;
            }

            set
            {
                soNguoi = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
    }
}
