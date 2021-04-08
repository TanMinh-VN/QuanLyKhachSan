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
    public partial class fChangePass : Form
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
        public fChangePass(Account acc)
        {
            InitializeComponent();
            this.Acc = acc;
        }
        bool isCorrectPassword()
        {
            if (txbPass.Text == Acc.Password)
            {
                return true;
            }
            return false;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbNewPass.Text == txbRePass.Text)
            {
                if (isCorrectPassword())
                {
                    string repass = txbRePass.Text;
                    string userName = Acc.UserName;
                    if(AccountDAO.Instance.ChangePass(repass,userName))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công!");
                        txbNewPass.Clear();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fChangePass_Load(object sender, EventArgs e)
        {
            txbUserName.Text = Acc.UserName;
        }
    }
}
