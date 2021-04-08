using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class BillShow
    {
        private string serviceName;
        private int count;
        private double price;
        private double thanhTien;

        public string ServiceName
        {
            get
            {
                return serviceName;
            }

            set
            {
                serviceName = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public double ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public BillShow(string serviceName, int count, double price, double thanhTien = 0)
        {
            this.ServiceName = serviceName;
            this.Count = count;
            this.Price = price;
            this.ThanhTien = thanhTien;
        }
        public BillShow(DataRow dtRow)
        {
            this.ServiceName = dtRow["tenDV"].ToString();
            this.Count = (int)dtRow["soLuong"];
            this.Price = Convert.ToDouble(dtRow["giaDV"].ToString());
            this.ThanhTien = Convert.ToDouble(dtRow["thanhTien"].ToString());
        }
    }
}
