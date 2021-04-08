using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fOrderRoom : Form
    {
        public int tableWidth = 80;
        public int tableHeight = 80;
        ImageList iconTable = new ImageList();
        private string userName;
        
        //private KhachHang kh;

        public fOrderRoom(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        
        #region hàm

        void LoadIconRoom()
        {
            iconTable.Images.Add(new Bitmap(Application.StartupPath + "\\IconResources\\icon\\normal_open.jpg"));
            iconTable.Images.Add(new Bitmap(Application.StartupPath + "\\IconResources\\icon\\normal_close.jpg"));
            iconTable.Images.Add(new Bitmap(Application.StartupPath + "\\IconResources\\icon\\vip_open.jpg"));
            iconTable.Images.Add(new Bitmap(Application.StartupPath + "\\IconResources\\icon\\vip_close.jpg"));
            iconTable.Images.Add(new Bitmap(Application.StartupPath + "\\IconResources\\icon\\room_fix.jpg"));
            iconTable.ImageSize = new Size(80, 80);
        }
        void LoadRoom(List<Room> room)
        {
            flpnlRoom.Controls.Clear();
            foreach (Room item in room)
            {
                Button btn = new Button();
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.ImageList = iconTable;
                btn.Width = tableWidth;
                btn.Height = tableHeight;
                btn.TextAlign = ContentAlignment.TopCenter;
                btn.ForeColor = Color.Red;
                btn.Text = item.TenPhong;
                if (item.TinhTrang == 0 && item.LoaiPhong==0)
                {
                    btn.ImageIndex = 0;
                }
                else if (item.TinhTrang == 1 && item.LoaiPhong == 0)
                {
                    btn.ImageIndex = 1;
                }
                else if (item.TinhTrang == 0 && item.LoaiPhong == 1)
                {
                    btn.ImageIndex = 2;
                }
                else if (item.TinhTrang == 1 && item.LoaiPhong == 1)
                {
                    btn.ImageIndex = 3;
                }
                else btn.ImageIndex = 4;
                flpnlRoom.Controls.Add(btn);
            }
        }
        void LoadCategory(List<Category> cate)
        {
            cbCatagory.DataSource = cate;
            cbCatagory.DisplayMember = "categoryName";
        }

        void LoadService(List<Service> room)
        {
            cbListService.DataSource = room;
            cbListService.DisplayMember = "tenDV";
        }
        void ShowBill(int id,int price,int soNgay)
        {
            lsvBill.Items.Clear();
            Room room = lsvBill.Tag as Room;
            double tongTien = price;
            ListViewItem lsvItemRoom = new ListViewItem("Phòng"+room.TenPhong);
            lsvItemRoom.SubItems.Add(soNgay.ToString()+"(Ngày)");
            lsvItemRoom.SubItems.Add(room.GiaPhong.ToString());            
            lsvItemRoom.SubItems.Add(price.ToString());
            lsvBill.Items.Add(lsvItemRoom);
            List<BillShow> listBShow = BillShowDAO.Instance.GetBillShowByRoom(id);
            foreach (BillShow item in listBShow)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName);
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                tongTien += item.ThanhTien;
                lsvBill.Items.Add(lsvItem);
            }
            txbTongTien.Tag = tongTien;
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Text = (tongTien).ToString("c", culture);
        }
        #endregion
        #region sự kiện
        private void btnOrderRoom_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            //int maDV = (cbListService.SelectedItem as Service).MaDV;
            //int count = (int)numCount.Value;
            int billID;
            Staff staff = StaffDAO.Instance.GetStaffByUserName(userName);
            try
            {
                if (room.TinhTrang == 1)
                {
                    MessageBox.Show("Phòng đã có người!!!");
                    return;
                }
                else if (room.TinhTrang == 2)
                {
                    MessageBox.Show("Phòng đang sửa!!!");
                    return;
                }
                else
                {
                    BillDAO.Instance.InsertBill(staff.MaNV, room.MaPhong);
                    try
                    {
                        billID = BillDAO.Instance.isUncheckBill(room.MaPhong);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng chọn phòng!!");
                        return;
                    }

                    //BillDAO.Instance.InsertBill(staff.MaNV,room.MaPhong);
                    billID = BillDAO.Instance.getLastBillID();
                    fKhachHang f = new fKhachHang(billID);
                    f.ShowDialog();
                    //this.btn_Click(sender, e);
                    this.fOrderRoom_Load(sender, e);
                }
                
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phòng!!");
                return;
            }
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            txbInfoOrder.Clear();
            Room room = (sender as Button).Tag as Room;
            int roomID = room.MaPhong;
            Bill b = BillDAO.Instance.GetBillByRoom(room.MaPhong);
            int price=0;
            int tongSoNgay=0;
            try
            {
                
                DateTime ngaymuon = Convert.ToDateTime(b.NgayVao);
                DateTime ngaytra = DateTime.Now;
                TimeSpan time = ngaytra - ngaymuon;
                tongSoNgay = time.Days;
                if (tongSoNgay==0)
                {
                    tongSoNgay = 1;
                }
                price = room.GiaPhong * tongSoNgay;
            }
            catch (Exception)
            {
     
            }
            
            lsvBill.Tag = room;
            ShowBill(roomID,price,tongSoNgay);
            try
            {
                ThongTinDatPhong dp = KhachHangDAO.Instance.GetKHByMaBill(b.MaBill);
                Staff staff = StaffDAO.Instance.GetStaffByBillID(b.MaBill);
                txbInfoOrder.Text = "Tên khách hàng: "+dp.TenKH + Environment.NewLine + "Tên phòng: " + dp.TenPhong + Environment.NewLine + "Số người: " + dp.SoNguoi + Environment.NewLine + "CMND: " + dp.Cmnd + Environment.NewLine + "Số điện thoại: " + dp.Phone+Environment.NewLine + "Tên nhân viên: " + staff.TenNV;
                
            }
            catch (Exception)
            {

                
            }
            
        }

            private void mstAdmin_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.fOrderRoom_Load(sender, e);
            this.Show();
        }

        private void cbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbListService.DataSource = null;
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category curCate = cb.SelectedItem as Category;
            id = curCate.CategoryID;
            LoadService(ServiceDAO.Instance.GetServiceByCataID(id));
        }

        private void btnOrderService_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            int maDV = (cbListService.SelectedItem as Service).MaDV;
            int count = (int)numCount.Value;
            int billID;
            //Staff staff = StaffDAO.Instance.GetStaffByUserName(UserName);
            try
            {
                billID = BillDAO.Instance.isUncheckBill(room.MaPhong);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phòng!!");
                return;
            }
            if (billID == -1)
            {
                MessageBox.Show("Phòng chưa được đặt!!!");
                return;
            }
            else
            {
                BillInfoDAO.Instance.InsertChiTietHD(billID, maDV, count);
            }
            int price = 0;
            int tongSoNgay = 0;
            try
            {
                Bill b = BillDAO.Instance.GetBillByRoom(room.MaPhong);
                DateTime ngaymuon = Convert.ToDateTime(b.NgayVao);
                DateTime ngaytra = DateTime.Now;
                TimeSpan time = ngaytra - ngaymuon;
                tongSoNgay = time.Days;
                if (tongSoNgay == 0)
                {
                    tongSoNgay = 1;
                }
                price = room.GiaPhong * tongSoNgay;
            }
            catch (Exception)
            {

            }
            numCount.Value = 0;
            ShowBill(room.MaPhong,price,tongSoNgay);
            LoadRoom(RoomDAO.Instance.LoadRoom_fOrder());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Room room = lsvBill.Tag as Room;
            int billID = BillDAO.Instance.isUncheckBill(room.MaPhong);
            if (billID != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán " + room.TenPhong + " không ?", "Thông báo!!!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    int discount = (int)numDiscount.Value;
                    string tongTien = txbTongTien.Tag.ToString();
                    BillDAO.Instance.ThanhToan(discount, tongTien, billID);
                    int price = 0;
                    int tongSoNgay = 0;
                    try
                    {
                        Bill b = BillDAO.Instance.GetBillByRoom(room.MaPhong);
                        DateTime ngaymuon = Convert.ToDateTime(b.NgayVao);
                        DateTime ngaytra = DateTime.Now;
                        TimeSpan time = ngaytra - ngaymuon;
                        tongSoNgay = time.Days;
                        if (tongSoNgay == 0)
                        {
                            tongSoNgay = 1;
                        }
                        price = room.GiaPhong * tongSoNgay;
                    }
                    catch (Exception)
                    {

                    }
                    fInHoaDon f = new fInHoaDon(billID);
                    f.ShowDialog();
                    txbInfoOrder.Clear();
                    ShowBill(room.MaPhong, price,tongSoNgay);
                    LoadRoom(RoomDAO.Instance.LoadRoom_fOrder());
                    //fInHoaDon print = new fInHoaDon();
                    //print.ShowDialog();
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            double tongTien = Convert.ToDouble(txbTongTien.Tag);
            tongTien *= (100 - Convert.ToDouble(numDiscount.Value)) / 100;
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Tag = tongTien;
            txbTongTien.Text = (tongTien).ToString("c", culture);
        }
        #endregion
        private void fOrderRoom_Load(object sender, EventArgs e)
        {
            Account acc = AccountDAO.Instance.GetAccByUsername(userName);
            if (acc.Type != 1)
            {
                mstAdmin.Enabled = false;
            }
            flpnlRoom.Controls.Clear();
            LoadIconRoom();
            LoadRoom(RoomDAO.Instance.LoadRoom_fOrder());
            LoadCategory(CategoryDAO.Instance.GetCategoryName());
        }



        private void mstRename_Click(object sender, EventArgs e)
        {
            Account acc = AccountDAO.Instance.GetAccByUsername(userName);
            fRename f = new fRename(acc);
            f.ShowDialog();
        }

        private void mstChangePass_Click(object sender, EventArgs e)
        {
            Account acc = AccountDAO.Instance.GetAccByUsername(userName);
            fChangePass f = new fChangePass(acc);
            f.ShowDialog();
        }

        private void mstExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mstHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Đây là ứng dụng Quản lí khách sạn. Đồ án kết thúc môn :Hướng phát triển phần mềm hướng đối tượng!" + '\n' +
                            "Được phát triền bởi nhóm 6 bao gồm các thành viên:" + '\n' +
                            "1.Bùi Đức Tấn Minh" + '\n' +
                            "2.Bùi Cao Kiều Huyên" + '\n' +
                            "3.Nguyễn Nhật Trường" + '\n' +
                            "Xin chân thành cám ơn!!!", "Giới thiệu");

        }
    }

}

