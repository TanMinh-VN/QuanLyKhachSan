using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class KhachHang
    {
        private int maKH;
        private string tenKH;
        private string cmnd;
        private string phoneNumber;
        private string address;

        public KhachHang (int maKH, string tenKH, string cmnd, string phoneNumber,string address)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.Cmnd = cmnd;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
        public KhachHang ()
        { }
        public KhachHang(DataRow dtRow)
        {
            this.maKH = (int)dtRow["maKH"]; ;
            this.TenKH = dtRow["tenKH"].ToString();
            this.Cmnd = dtRow["CMND"].ToString();
            this.PhoneNumber = dtRow["guestPhoneNumber"].ToString();
            this.Address = dtRow["guestAddress"].ToString();
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

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
    }
}
