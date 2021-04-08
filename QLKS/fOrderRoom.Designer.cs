namespace QLKS
{
    partial class fOrderRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrderRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAccInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mstRename = new System.Windows.Forms.ToolStripMenuItem();
            this.mstChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.mstExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOrderService = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.cbListService = new System.Windows.Forms.ComboBox();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.flpnlRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.txbInfoOrder = new System.Windows.Forms.TextBox();
            this.btnOrderRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(508, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 324);
            this.panel1.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.White;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(458, 324);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên dịch vụ";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 271;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbTongTien);
            this.panel3.Controls.Add(this.numDiscount);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(508, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 60);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(264, 17);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(100, 26);
            this.txbTongTien.TabIndex = 6;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDiscount
            // 
            this.numDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDiscount.Location = new System.Drawing.Point(12, 22);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(75, 20);
            this.numDiscount.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(370, 8);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(82, 46);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "       Thanh       toán\r\n";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(93, 7);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(99, 46);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(99, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstAdmin,
            this.mstAccInfo,
            this.mstExit,
            this.mstHelp});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripMenuItem.Image")));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // mstAdmin
            // 
            this.mstAdmin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstAdmin.Name = "mstAdmin";
            this.mstAdmin.Size = new System.Drawing.Size(183, 22);
            this.mstAdmin.Text = "Admin";
            this.mstAdmin.Click += new System.EventHandler(this.mstAdmin_Click);
            // 
            // mstAccInfo
            // 
            this.mstAccInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstRename,
            this.mstChangePass});
            this.mstAccInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstAccInfo.Name = "mstAccInfo";
            this.mstAccInfo.Size = new System.Drawing.Size(183, 22);
            this.mstAccInfo.Text = "Thông tin tài khoản";
            // 
            // mstRename
            // 
            this.mstRename.Name = "mstRename";
            this.mstRename.Size = new System.Drawing.Size(174, 22);
            this.mstRename.Text = "Thay đổi tên";
            this.mstRename.Click += new System.EventHandler(this.mstRename_Click);
            // 
            // mstChangePass
            // 
            this.mstChangePass.Name = "mstChangePass";
            this.mstChangePass.Size = new System.Drawing.Size(174, 22);
            this.mstChangePass.Text = "Thay đổi mật khẩu";
            this.mstChangePass.Click += new System.EventHandler(this.mstChangePass_Click);
            // 
            // mstExit
            // 
            this.mstExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstExit.Name = "mstExit";
            this.mstExit.Size = new System.Drawing.Size(183, 22);
            this.mstExit.Text = "Đăng xuất";
            this.mstExit.Click += new System.EventHandler(this.mstExit_Click);
            // 
            // mstHelp
            // 
            this.mstHelp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstHelp.Name = "mstHelp";
            this.mstHelp.Size = new System.Drawing.Size(183, 22);
            this.mstHelp.Text = "Giới thiệu";
            this.mstHelp.Click += new System.EventHandler(this.mstHelp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnOrderService);
            this.panel4.Controls.Add(this.numCount);
            this.panel4.Controls.Add(this.cbListService);
            this.panel4.Controls.Add(this.cbCatagory);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(509, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 60);
            this.panel4.TabIndex = 4;
            // 
            // btnOrderService
            // 
            this.btnOrderService.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderService.Image")));
            this.btnOrderService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderService.Location = new System.Drawing.Point(343, 4);
            this.btnOrderService.Name = "btnOrderService";
            this.btnOrderService.Size = new System.Drawing.Size(114, 47);
            this.btnOrderService.TabIndex = 7;
            this.btnOrderService.Text = "Thêm DV";
            this.btnOrderService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderService.UseVisualStyleBackColor = true;
            this.btnOrderService.Click += new System.EventHandler(this.btnOrderService_Click);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(281, 31);
            this.numCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(55, 20);
            this.numCount.TabIndex = 4;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbListService
            // 
            this.cbListService.FormattingEnabled = true;
            this.cbListService.Location = new System.Drawing.Point(16, 30);
            this.cbListService.Name = "cbListService";
            this.cbListService.Size = new System.Drawing.Size(259, 21);
            this.cbListService.TabIndex = 1;
            // 
            // cbCatagory
            // 
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(16, 3);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(259, 21);
            this.cbCatagory.TabIndex = 0;
            this.cbCatagory.SelectedIndexChanged += new System.EventHandler(this.cbCatagory_SelectedIndexChanged);
            // 
            // flpnlRoom
            // 
            this.flpnlRoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpnlRoom.Location = new System.Drawing.Point(3, 27);
            this.flpnlRoom.Name = "flpnlRoom";
            this.flpnlRoom.Size = new System.Drawing.Size(499, 500);
            this.flpnlRoom.TabIndex = 6;
            // 
            // txbInfoOrder
            // 
            this.txbInfoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInfoOrder.Location = new System.Drawing.Point(508, 29);
            this.txbInfoOrder.Multiline = true;
            this.txbInfoOrder.Name = "txbInfoOrder";
            this.txbInfoOrder.ReadOnly = true;
            this.txbInfoOrder.Size = new System.Drawing.Size(338, 108);
            this.txbInfoOrder.TabIndex = 7;
            // 
            // btnOrderRoom
            // 
            this.btnOrderRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderRoom.Image")));
            this.btnOrderRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderRoom.Location = new System.Drawing.Point(852, 49);
            this.btnOrderRoom.Name = "btnOrderRoom";
            this.btnOrderRoom.Size = new System.Drawing.Size(110, 46);
            this.btnOrderRoom.TabIndex = 8;
            this.btnOrderRoom.Text = "Đặt phòng";
            this.btnOrderRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderRoom.UseVisualStyleBackColor = true;
            this.btnOrderRoom.Click += new System.EventHandler(this.btnOrderRoom_Click);
            // 
            // fOrderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.btnOrderRoom);
            this.Controls.Add(this.txbInfoOrder);
            this.Controls.Add(this.flpnlRoom);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fOrderRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.fOrderRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstAdmin;
        private System.Windows.Forms.ToolStripMenuItem mstExit;
        private System.Windows.Forms.ToolStripMenuItem mstHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.ComboBox cbListService;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.FlowLayoutPanel flpnlRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.ToolStripMenuItem mstAccInfo;
        private System.Windows.Forms.ToolStripMenuItem mstRename;
        private System.Windows.Forms.ToolStripMenuItem mstChangePass;
        private System.Windows.Forms.Button btnOrderService;
        private System.Windows.Forms.TextBox txbInfoOrder;
        private System.Windows.Forms.Button btnOrderRoom;
    }
}