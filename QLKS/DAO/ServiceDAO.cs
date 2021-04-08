using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ServiceDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private ServiceDAO() { }
        public List<Service> GetServiceByCataID(int id)
        {
            List<Service> lService = new List<Service>();
            //DataProvider provider = new DataProvider();
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DichVu WHERE maCategory=" + id);
            foreach (DataRow item in dtTable.Rows)
            {
                Service service = new Service(item);
                lService.Add(service);
            }
            return lService;
        }

        public bool AddService(int id, string name, string price)
        {
            string query = "INSERT dbo.DichVu(maCategory, tenDV, giaDV )VALUES  ( " + id + ",N'" + name + "'," + price + ")";
            // DataProvider provider = new DataProvider();
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public DataTable ServiceList()
        {
            string query = "SELECT maDV AS N'Mã dịch vụ',f.tenDV AS N'Tên dịch vụ',c.tenCategory AS N'Tên danh mục', f.giaDV AS N'Giá'  FROM dbo.DichVu AS f,dbo.ServiceCategory AS c WHERE f.maCategory=c.maCategory";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public DataTable SearchService(string keyWord)
        {
            string query = "SELECT maDV AS N'Mã dịch vụ',f.tenDV AS N'Tên dịch vụ',c.tenCategory AS N'Tên danh mục', f.giaDV AS N'Giá' FROM dbo.DichVu AS f ,dbo.ServiceCategory AS c WHERE (f.tenDV LIKE N'%" + keyWord + "%') AND f.maCategory=c.maCategory ";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public bool EditService(int cataID, string name, string price, string maDV)
        {
            string query = "UPDATE dbo.DichVu SET maCategory=" + cataID + " , tenDV=N'" + name + "' , giaDV=" + price + " WHERE maDV=" + maDV;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool DelService(string id)
        {

            string query = " DELETE dbo.DichVu WHERE maDV = " + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }
        public bool DelServiceByCataID(string cataID)
        {
            string query = " DELETE dbo.DichVu WHERE maCategory= " + cataID;
            ServiceList();
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

    }

}
