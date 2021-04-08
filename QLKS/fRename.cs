using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fRename : Form
    {
        private Account acc;
        public Account Acc
        {
            get
            {
                return acc;
            }

            set
            {
                acc = value;
            }
        }
        public fRename(Account acc)
        {
            InitializeComponent();
            this.Acc = acc;
        }
        bool isCorrectPassword()
        {
            if (txbRePass.Text == Acc.Password)
            {
                return true;
            }
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbPass.Text == txbRePass.Text)
            {
                if (isCorrectPassword())
                {
                    string displayName = txbDislayName.Text;
                    string userName = Acc.UserName;
                    if (AccountDAO.Instance.ChangeName(displayName, userName))
                    {
                        MessageBox.Show("Thay đổi tên thành công!");
                        //txbDislayName.Clear();
                        txbPass.Clear();
                        txbRePass.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu sai!");
            }
        }

        private void fRename_Load(object sender, EventArgs e)
        {
            txbUserName.Text = Acc.UserName;
            txbDislayName.Text = Acc.DisplayName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
