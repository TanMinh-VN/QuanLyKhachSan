using QLKS.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            string username = txbAccount.Text;
            string password = txbPass.Text;
            if (AccountDAO.Instance.Login(username, password))
            {
                fOrderRoom f = new fOrderRoom(username);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txbAccount.Clear();
                txbPass.Clear();
                txbAccount.Focus();
            }
            else MessageBox.Show("Nhập sai mật khẩu. Vui lòng nhập lại!!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
