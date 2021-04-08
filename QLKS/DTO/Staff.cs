using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Staff
    {
        private int maNV;
        private string tenNV;
        private string staffAddress;
        private string staffPhoneNumber;

        public Staff() { }
        public Staff(int maNV,string tenNV, string staffAddress,string staffPhoneNumber)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.StaffAddress = staffAddress;
            this.StaffPhoneNumber = staffPhoneNumber;
        }
        public Staff(DataRow dtRow)
        {
            this.MaNV = (int)dtRow["maNV"];
            this.TenNV = dtRow["tenNV"].ToString();
            this.StaffAddress = dtRow["staffAddress"].ToString();
            this.StaffPhoneNumber = dtRow["staffPhoneNumber"].ToString();
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

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string StaffAddress
        {
            get
            {
                return staffAddress;
            }

            set
            {
                staffAddress = value;
            }
        }

        public string StaffPhoneNumber
        {
            get
            {
                return staffPhoneNumber;
            }

            set
            {
                staffPhoneNumber = value;
            }
        }
    }
}
