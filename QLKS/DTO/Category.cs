using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        public int CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }
        public Category(int catagoryID, string catagoryName)
        {
            this.CategoryID = catagoryID;
            this.CategoryName = catagoryName;
        }
        public Category(DataRow dtRow)
        {
            this.CategoryID = (int)dtRow["maCategory"];
            this.CategoryName = dtRow["tenCategory"].ToString();
        }

    }
}
