namespace QLKS
{
    partial class fRename
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbDislayName = new System.Windows.Forms.TextBox();
            this.txbRePass = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.lbRePass = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txbDislayName);
            this.panel1.Controls.Add(this.txbRePass);
            this.panel1.Controls.Add(this.lbDisplayName);
            this.panel1.Controls.Add(this.lbRePass);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbAccount);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 256);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(202, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbDislayName
            // 
            this.txbDislayName.Location = new System.Drawing.Point(112, 78);
            this.txbDislayName.Name = "txbDislayName";
            this.txbDislayName.Size = new System.Drawing.Size(180, 21);
            this.txbDislayName.TabIndex = 1;
            // 
            // txbRePass
            // 
            this.txbRePass.Location = new System.Drawing.Point(112, 164);
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.Size = new System.Drawing.Size(180, 21);
            this.txbRePass.TabIndex = 3;
            this.txbRePass.UseSystemPasswordChar = true;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(17, 81);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(87, 15);
            this.lbDisplayName.TabIndex = 4;
            this.lbDisplayName.Text = "Tên hiển thị:";
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Location = new System.Drawing.Point(17, 170);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(65, 15);
            this.lbRePass.TabIndex = 1;
            this.lbRePass.Text = "Nhập lại:";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(112, 119);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(180, 21);
            this.txbPass.TabIndex = 2;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(112, 34);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(180, 21);
            this.txbUserName.TabIndex = 0;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(17, 125);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 15);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Mật khẩu:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(17, 34);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(74, 15);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Tài khoản:";
            // 
            // fRename
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(325, 280);
            this.Controls.Add(this.panel1);
            this.Name = "fRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi tên";
            this.Load += new System.EventHandler(this.fRename_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbDislayName;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox txbRePass;
        private System.Windows.Forms.Label lbRePass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}
