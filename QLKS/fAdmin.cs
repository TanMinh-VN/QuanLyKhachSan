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
    public partial class fAdmin : Form
    {
        BindingSource bindingServiceList = new BindingSource();
        BindingSource bindingCateList = new BindingSource();
        BindingSource bindingAccList = new BindingSource();
        BindingSource bindingStaffList = new BindingSource();
        BindingSource bindingRoomList = new BindingSource();
        BindingSource bindingGuestList = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            dtgvService.DataSource = bindingServiceList;
            dtgvCategory.DataSource = bindingCateList;
            dtgvStaff.DataSource = bindingStaffList;
            dtgvAcc.DataSource = bindingAccList;
            dtgvRoom.DataSource = bindingRoomList;
            dtgvGuest.DataSource = bindingGuestList;
            bindingAccList.DataSource = AccountDAO.Instance.AccList();
            bindingServiceList.DataSource = ServiceDAO.Instance.ServiceList();
            bindingStaffList.DataSource = StaffDAO.Instance.StaffList();
            LoadCateForCbServiceCategory(CategoryDAO.Instance.GetCategoryName());
            LoadStaffForCbListStaff(StaffDAO.Instance.GetListStaff());
            bindingRoomList.DataSource = RoomDAO.Instance.RoomList();
            bindingCateList.DataSource = CategoryDAO.Instance.getCategoryToDtTable();
            bindingGuestList.DataSource = KhachHangDAO.Instance.GuestList();
            BindingService();
            BindingCategory();
            BindingStaff();
            BindingAcc();
            BindingRoom();
            BindingGuest();
        }
        
        #region Catagory
        //Hàm
        void BindingCategory()
        {
            txbIDCategory.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Mã danh mục", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }
        void AddCategory()
        {
            string name = txbCategoryName.Text;
            if (CategoryDAO.Instance.AddCategory(name))
            {
                MessageBox.Show("Đã thêm một danh mục!");
                
            }

        }
        void EditCategory()
        {
            string name = txbCategoryName.Text;
            string id = txbIDCategory.Text;
            if (CategoryDAO.Instance.EditCategory(name, id))
            {
                
                MessageBox.Show("Đã sửa thành công!");
            }

        }
        void DelCategory()
        {
            string id = txbIDCategory.Text;
            if (CategoryDAO.Instance.DelCategory(id))
            {
                
                MessageBox.Show("Đã xóa thành công!");
            }
        }
        //Sự kiện
        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            AddCategory();
            bindingCateList.DataSource = CategoryDAO.Instance.getCategoryToDtTable();
            LoadCateForCbServiceCategory(CategoryDAO.Instance.GetCategoryName());
        }

        private void btnDelCatagory_Click(object sender, EventArgs e)
        {
            DelCategory();
            bindingCateList.DataSource = CategoryDAO.Instance.getCategoryToDtTable();
            LoadCateForCbServiceCategory(CategoryDAO.Instance.GetCategoryName());
        }

        private void btnEditCatagory_Click(object sender, EventArgs e)
        {
            EditCategory();
            bindingCateList.DataSource = CategoryDAO.Instance.getCategoryToDtTable();
            LoadCateForCbServiceCategory(CategoryDAO.Instance.GetCategoryName());
        }

        private void btnViewCatagory_Click(object sender, EventArgs e)
        {
            bindingCateList.DataSource = CategoryDAO.Instance.getCategoryToDtTable();
        }
        #endregion

        #region Service
        //Hàm
        void BindingService()
        {
            txbIDService.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "Mã dịch vụ", true, DataSourceUpdateMode.Never));
            txbServiceName.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "Tên dịch vụ", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "Giá", true, DataSourceUpdateMode.Never));
        }
        void LoadCateForCbServiceCategory(List<Category> cata)
        {
            cbServiceCategory.DataSource = cata;
            cbServiceCategory.DisplayMember = "categoryName";
        }
        void AddService()
        {
            Category curCata = cbServiceCategory.SelectedItem as Category;
            int id = curCata.CategoryID;
            string name = txbServiceName.Text;
            string price = txbPrice.Text;
            try
            {
                Convert.ToInt32(price);
            }
            catch (Exception)
            {

                MessageBox.Show("Giá dịch vụ phải là số");
                return;
            }
            if (ServiceDAO.Instance.AddService(id, name, price))
            {
                MessageBox.Show("Đã thêm một món ăn!");
            }

        }
        void EditService()
        {
            Category cata = cbServiceCategory.SelectedItem as Category;
            int cataID = cata.CategoryID;
            string name = txbServiceName.Text;
            string price = txbPrice.Text;
            string foodID = txbIDService.Text;
            if (ServiceDAO.Instance.EditService(cataID, name, price, foodID))
            {
                MessageBox.Show("Đã sửa thành công!");
            }

        }
        void DelService()
        {
            string id = txbIDService.Text;
            if (ServiceDAO.Instance.DelService(id))
            {
                MessageBox.Show("Đã xóa thành công!");
            }
        }
        //Sự kiện
        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddService();
            bindingServiceList.DataSource = ServiceDAO.Instance.ServiceList();
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            //ChiTietHoaDonDAO.Instance.XoaChiTietHD(txbIDFood.Text);
            DelService();
            bindingServiceList.DataSource = ServiceDAO.Instance.ServiceList();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            EditService();
            bindingServiceList.DataSource = ServiceDAO.Instance.ServiceList();
        }

        private void btnViewService_Click(object sender, EventArgs e)
        {
            bindingServiceList.DataSource = ServiceDAO.Instance.ServiceList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingServiceList.DataSource = ServiceDAO.Instance.SearchService(txbSearchService.Text);
        }
        private void txbIDService_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAcc.SelectedCells.Count > 0)
            {
                string tenCate = Convert.ToString(dtgvService.SelectedCells[0].OwningRow.Cells["Tên danh mục"].Value);
                List<Category> lCate = cbServiceCategory.DataSource as List<Category>;
                foreach (Category item in lCate)
                {
                    if (tenCate == item.CategoryName)
                    {
                        cbServiceCategory.SelectedItem = item;
                    }
                }
            }
        }
        #endregion
        #region Account
        //Hàm
        void BindingAcc()
        {
            txbAccName.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
        }
        void LoadStaffForCbListStaff(List<Staff> staff)
        {
            cbListStaff_mstAcc.DataSource = staff;
            cbListStaff_mstAcc.DisplayMember = "tenNV";
        }
        void AddAcc()
        {
            
            if (txbAccName.Text != "" && txbDisplayName.Text != "")
            {
                
                string userName = txbAccName.Text;
                string displayName = txbDisplayName.Text;
                int type = cbTypeAcc.SelectedIndex;
                Staff staff = cbListStaff_mstAcc.SelectedItem as Staff;
                int maNV = staff.MaNV;
                try
                {
                    AccountDAO.Instance.AddAcc(userName, displayName, type, maNV);
                }
                catch (Exception)
                {

                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                    return;
                }
                
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm!!");
        }
        void EditAcc()
        {
            string displayName = txbDisplayName.Text;
            int type = cbTypeAcc.SelectedIndex;
            string userName = txbAccName.Text;
            string correctUser = Convert.ToString(dtgvAcc.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value);
            Staff staff = cbListStaff_mstAcc.SelectedItem as Staff;
            int maNV = staff.MaNV;
            if (userName == correctUser)
            {
                if (AccountDAO.Instance.EditAcc(displayName, type, userName,maNV))
                {
                    //LoadCatagory(CatagoryDAO.Instance.GetCatagoryName());
                    MessageBox.Show("Đã sửa thành công!");
                }
            }
            else
                MessageBox.Show("Không được sửa tên đăng nhập");
        }
        void DelAcc()
        {
            string userName = txbAccName.Text;
            if (AccountDAO.Instance.DelAcc(userName))
            {
                MessageBox.Show("Đã xóa thành công!");
            }


        }
        //Sự kiện
        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AddAcc();
            bindingAccList.DataSource = AccountDAO.Instance.AccList();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DelAcc();
                bindingAccList.DataSource = AccountDAO.Instance.AccList();
            }

        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            EditAcc();
            bindingAccList.DataSource = AccountDAO.Instance.AccList();
        }

        private void btnViewAcc_Click(object sender, EventArgs e)
        {
            bindingAccList.DataSource = AccountDAO.Instance.AccList();
        }
        private void txbAccName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvAcc.SelectedCells.Count > 0)
            {

                //Binding cb loại tài khoản
                int type = 0;
                if ((Int32.TryParse(Convert.ToString(dtgvAcc.SelectedCells[0].OwningRow.Cells["Loại tài khoản"].Value), out type)))
                {
                    if (type == 0)
                    {
                        cbTypeAcc.SelectedIndex = 0;
                    }
                    else
                        cbTypeAcc.SelectedIndex = 1;

                }

                //Binding cb nhân viên
                string tenNV = Convert.ToString(dtgvAcc.SelectedCells[0].OwningRow.Cells["Tên nhân viên"].Value);
                List<Staff> lStaff = cbListStaff_mstAcc.DataSource as List<Staff>;
                foreach (Staff item in lStaff)
                {
                    if (tenNV == item.TenNV)
                    {
                        cbListStaff_mstAcc.SelectedItem = item;
                    }
                }
                //string name = Convert.ToString(dtgvFood.SelectedCells[0].OwningRow.Cells["Tên danh mục"].Value);
                //if (tenNV != "")
                //{
                //    int index = -1;
                //    int i = 0;
                //    foreach (Staff item in cbListStaff_mstAcc.Items)
                //    {
                //        if (item.TenNV == tenNV)
                //        {
                //            index = i;
                //            break;
                //        }
                //        i++;
                //    }
                //    cbListStaff_mstAcc.SelectedIndex = index;
                //}
            }

        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                AccountDAO.Instance.ResetPass(txbAccName.Text);
                MessageBox.Show("Đặt lại thành công!!!");
            }

        }
        #endregion
        #region Staff
        //Hàm
        void BindingStaff()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never));
            txbStaffName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Tên nhân viên", true, DataSourceUpdateMode.Never));
            txbStaffAddress.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txbStaffPhone.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
        }
        void AddStaff()
        {
            string name = txbStaffName.Text;
            string address = txbStaffAddress.Text;
            string phone = txbStaffPhone.Text;
            try
            {
                Convert.ToInt32(phone);
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại phải là số");
                return;
            }
            if (StaffDAO.Instance.AddStaff(name,address,phone))
            {
                MessageBox.Show("Đã thêm thành công!");

            }

        }
        void EditStaff()
        {
            int id = Convert.ToInt32(txbMaNV.Text);
            string name = txbStaffName.Text;
            string address = txbStaffAddress.Text;
            string phone = txbStaffPhone.Text;
            try
            {
                Convert.ToInt32(txbStaffPhone.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại phải là số");
            }
            if (StaffDAO.Instance.EditStaff(id,name, address, phone))
            {
                MessageBox.Show("Đã sửa thành công!");

            }

        }
        void DelStaff()
        {
            int id = Convert.ToInt32(txbMaNV.Text);
            if (StaffDAO.Instance.DelStaff(id))
            {
                MessageBox.Show("Đã xóa thành công!");

            }

        }
        //Sự kiện
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff();
            bindingStaffList.DataSource = StaffDAO.Instance.StaffList();
            LoadStaffForCbListStaff(StaffDAO.Instance.GetListStaff());
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            DelStaff();
            bindingStaffList.DataSource = StaffDAO.Instance.StaffList();
            LoadStaffForCbListStaff(StaffDAO.Instance.GetListStaff());
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
            bindingStaffList.DataSource = StaffDAO.Instance.StaffList();
            LoadStaffForCbListStaff(StaffDAO.Instance.GetListStaff());
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            bindingStaffList.DataSource = StaffDAO.Instance.StaffList();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            bindingStaffList.DataSource = StaffDAO.Instance.SearchStaff(txbSearchStaff.Text);
        }
        #endregion
        #region Room
        //Hàm
        void BindingRoom()
        {
            txbRoomName.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never));
            txbGiaPhong.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "Giá phòng", true, DataSourceUpdateMode.Never));
        }
        void EditRoom()
        {
            int id = 0;
            if (dtgvRoom.SelectedCells.Count > 0)
            {
               
                Int32.TryParse(Convert.ToString(dtgvRoom.SelectedCells[0].OwningRow.Cells["Mã phòng"].Value), out id);

            }
            string name = txbRoomName.Text;
            int price = Convert.ToInt32(txbGiaPhong.Text);
            int status = cbRoomStatus.SelectedIndex;
            int type = cbRoomType.SelectedIndex;
            if (RoomDAO.Instance.EditRoom(type,status,name,price,id))
            {
                MessageBox.Show("Đã sửa thành công!");
            }
        }
        void DelRoom()
        {
            int id = 0;
            if (dtgvRoom.SelectedCells.Count > 0)
            {

                Int32.TryParse(Convert.ToString(dtgvRoom.SelectedCells[0].OwningRow.Cells["Mã phòng"].Value), out id);

            }
            if (RoomDAO.Instance.DelRoom(id))
            {
                MessageBox.Show("Đã xóa thành công!");
            }
        }

        //Sự kiện
        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            DelRoom();
            bindingRoomList.DataSource = RoomDAO.Instance.RoomList();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            EditRoom();
            bindingRoomList.DataSource = RoomDAO.Instance.RoomList();
        }

        private void btnViewRoom_Click(object sender, EventArgs e)
        {
            bindingRoomList.DataSource = RoomDAO.Instance.RoomList();
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            bindingRoomList.DataSource = RoomDAO.Instance.SearchRoom(txbSearchRoom.Text);
        }
        private void txbRoomName_TextChanged(object sender, EventArgs e)
        {
            if (dtgvRoom.SelectedCells.Count > 0)
            {
                int type = 0;
                if ((Int32.TryParse(Convert.ToString(dtgvRoom.SelectedCells[0].OwningRow.Cells["Loại phòng"].Value), out type)))
                {
                    cbRoomType.SelectedIndex = type;

                }
                if ((Int32.TryParse(Convert.ToString(dtgvRoom.SelectedCells[0].OwningRow.Cells["Trạng thái"].Value), out type)))
                {
                    cbRoomStatus.SelectedIndex = type;

                }


            }
        }
        #endregion
        #region Guest
        //Hàm
        void BindingGuest()
        {
            txbGuestID.DataBindings.Add(new Binding("Text", dtgvGuest.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never));
            txbGuestName.DataBindings.Add(new Binding("Text", dtgvGuest.DataSource, "Tên khách hàng", true, DataSourceUpdateMode.Never));
            txbCMND.DataBindings.Add(new Binding("Text", dtgvGuest.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txbGuestPhone.DataBindings.Add(new Binding("Text", dtgvGuest.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txbGuestAddress.DataBindings.Add(new Binding("Text", dtgvGuest.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));

        }
        void AddGuest()
        {
            string name = txbGuestName.Text;
            string cmnd = txbCMND.Text;
            string phone = txbGuestPhone.Text;
            string address = txbGuestAddress.Text;
            try
            {
                Convert.ToInt32(cmnd);
            }
            catch (Exception)
            {

                MessageBox.Show("CMND phải là số");
                return;
            }
            try
            {
                Convert.ToInt32(phone);
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại phải là số");
                return;
            }

            if (KhachHangDAO.Instance.AddGuest(name,cmnd,phone,address))
            {
                MessageBox.Show("Đã thêm một khách hàng!");

            }

        }
        void EditGuest()
        {
            int id = Convert.ToInt16(txbGuestID.Text);
            string name = txbGuestName.Text;
            string cmnd = txbCMND.Text;
            string phone = txbGuestPhone.Text;
            string address = txbGuestAddress.Text;
            try
            {
                Convert.ToInt32(cmnd);
            }
            catch (Exception)
            {

                MessageBox.Show("CMND phải là số");
                return;
            }
            try
            {
                Convert.ToInt32(phone);
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại phải là số");
                return;
            }
            if (KhachHangDAO.Instance.EditGuest(id,name,cmnd,phone,address))
            {

                MessageBox.Show("Đã sửa thành công!");
            }

        }
        void DelGuest()
        {
            int id = Convert.ToInt16(txbGuestID.Text);
            if (KhachHangDAO.Instance.DelGuest(id))
            {

                MessageBox.Show("Đã xóa thành công!");
            }
        }
        //Sự kiện
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuest();
            bindingGuestList.DataSource = KhachHangDAO.Instance.GuestList();
        }

        private void btnDelGuest_Click(object sender, EventArgs e)
        {
            DelGuest();
            bindingGuestList.DataSource = KhachHangDAO.Instance.GuestList();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            EditGuest();
            bindingGuestList.DataSource = KhachHangDAO.Instance.GuestList();
        }

        private void btnViewGuest_Click(object sender, EventArgs e)
        {
            bindingGuestList.DataSource = KhachHangDAO.Instance.GuestList();
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            bindingGuestList.DataSource = KhachHangDAO.Instance.SearchGuest(txbSearchGuest.Text);
        }
        #endregion
        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnViewDoanhThu_Click(object sender, EventArgs e)
        {
            string beginDay = dtpkBegin.Value.ToString();
            string endDay = dtpkEnd.Value.ToString();
            dtgvDoanhThu.DataSource = BillDAO.Instance.DoanhThuList(beginDay, endDay);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string beginDay = dtpkBegin.Value.ToString();
            string endDay = dtpkEnd.Value.ToString();
            fInThongKe f = new fInThongKe(beginDay,endDay);
            f.ShowDialog();
        }
    }
}
