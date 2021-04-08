using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        private CategoryDAO() { }

        public List<Category> GetCategoryName()
        {
            List<Category> cateList = new List<Category>();
            //DataProvider provider = new DataProvider();
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ServiceCategory");
            foreach (DataRow item in dtTable.Rows)
            {
                Category cata = new Category(item);
                cateList.Add(cata);
            }
            return cateList;
        }

        public bool AddCategory(string name)
        {

            string query = "INSERT dbo.ServiceCategory( tenCategory )VALUES  (N'" + name + "')";
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public DataTable getCategoryToDtTable()
        {
            string query = "SELECT maCategory AS N'Mã danh mục', tenCategory AS N'Tên danh mục' FROM dbo.ServiceCategory";
            DataTable dtTable = DataProvider.Instance.ExecuteQuery(query);
            return dtTable;
        }

        public bool EditCategory(string name, string id)
        {
            string query = "UPDATE dbo.ServiceCategory SET tenCategory=N'" + name + "' WHERE maCategory=" + id;

            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            return successRows > 0;
        }

        public bool DelCategory(string id)
        {
            string query = " DELETE dbo.ServiceCategory WHERE maCategory = " + id;
            int successRows = DataProvider.Instance.ExecuteNonQuery(query);
            getCategoryToDtTable();
            return successRows > 0;
        }
    }
}
