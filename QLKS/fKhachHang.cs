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
    public partial class fKhachHang : Form
    {
        int billID;
        private int haveGuest;
        
        public fKhachHang(int billID)
        {
            InitializeComponent();
            this.billID = billID;
        }

        public void SearchKH_fKH()
        {
            string someInfo = txbSearchKH_fKH.Text;
            KhachHang kh = new KhachHang();
            
            kh= KhachHangDAO.Instance.getInfoKH(someInfo);
            if (kh!=null)
            {
                txbIDKH_fKH.Text = kh.MaKH.ToString();
                txbTenKH_fKH.Text = kh.TenKH;
                txbCMND_fKH.Text = kh.Cmnd;
                txbPhone_fKH.Text = kh.PhoneNumber;
                txbAddress.Text = kh.Address;
                txbTenKH_fKH.Tag = kh.MaKH;
                haveGuest = 1;
            } 
            else
            {
                haveGuest = 0;
                MessageBox.Show("Khách hàng không tồn tại");
            }  

        }

        public bool AddKH_fKH()
        {
            try
            {
                Convert.ToInt32(txbCMND_fKH.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("CMND phải là số");
                return false;
            }
            try
            {
                Convert.ToInt32(txbPhone_fKH.Text);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại phải là số");
                return false;
            }
            try
            {
                int count = (int)numGuestCount.Value;

            }
            catch (Exception)
            {

                MessageBox.Show("Số người phải là số");
                return false;
            }
            
            if (KhachHangDAO.Instance.AddGuest(txbTenKH_fKH.Text, txbCMND_fKH.Text, txbPhone_fKH.Text, txbAddress.Text))
            {
                MessageBox.Show("Thêm thành công");
            }
            return true;

        }
        private void fKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchKH_fKH_Click(object sender, EventArgs e)
        {
            SearchKH_fKH();
        }

        private void btnAddKH_fKH_Click(object sender, EventArgs e)
        {
            if ((int)numGuestCount.Value <= 0)
            {

                MessageBox.Show("Số người phải lớn hơn 0!");
                return;

            }
            if (haveGuest==1)
            {
                int count = (int)numGuestCount.Value;
                KhachHang kh = new KhachHang();
                kh = KhachHangDAO.Instance.getInfoKH(txbTenKH_fKH.Text);
                DatPhongDAO.Instance.AddDatPhong(billID, kh.MaKH, count);
                this.Close();


            }
            else
            {

                if (AddKH_fKH())
                {
                    int count = (int)numGuestCount.Value;
                    KhachHang kh = new KhachHang();
                    kh = KhachHangDAO.Instance.getInfoKH(txbTenKH_fKH.Text);
                    DatPhongDAO.Instance.AddDatPhong(billID, kh.MaKH, count);
                    this.Close();
                    return;
                }
                else return;
                
            }
            

        }
    }
}
