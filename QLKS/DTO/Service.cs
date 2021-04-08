using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Service
    {
        private int maDV;
        private string tenDV;
        private int giaDV;

        public Service() { }

        public Service (int maDV,string tenDV,int giaDV)

        {
            this.MaDV = maDV;
            this.TenDV = tenDV;
            this.GiaDV = giaDV;
        }
        public Service(DataRow dtRow)
        {
            this.MaDV = (int)dtRow["maDV"]; 
            this.TenDV = dtRow["tenDV"].ToString();
            this.GiaDV = (int)dtRow["giaDV"];
        }
        public int MaDV
        {
            get
            {
                return maDV;
            }

            set
            {
                maDV = value;
            }
        }

        public string TenDV
        {
            get
            {
                return tenDV;
            }

            set
            {
                tenDV = value;
            }
        }

        public int GiaDV
        {
            get
            {
                return giaDV;
            }

            set
            {
                giaDV = value;
            }
        }
    }
}
