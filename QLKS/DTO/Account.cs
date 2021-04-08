using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private int type;
        private int maNV;

        public Account(string userName, string displayName, string password, int type,int maNV)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
            this.MaNV = maNV;
        }
        public Account(DataRow dtRow)
        {
            this.UserName = dtRow["userName"].ToString();
            this.DisplayName = dtRow["displayName"].ToString();
            this.Password = dtRow["pass"].ToString();
            this.Type = (int)dtRow["type"];
            this.MaNV = (int)dtRow["maNV"];
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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
    }
}
