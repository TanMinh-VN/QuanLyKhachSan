namespace QLKS
{
    partial class fChangePass
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
            this.txbRePass = new System.Windows.Forms.TextBox();
            this.lbRePass = new System.Windows.Forms.Label();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txbRePass);
            this.panel1.Controls.Add(this.lbRePass);
            this.panel1.Controls.Add(this.txbNewPass);
            this.panel1.Controls.Add(this.txbPass);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.lbNewPass);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbAccount);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 256);
            this.panel1.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(236, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbRePass
            // 
            this.txbRePass.Location = new System.Drawing.Point(131, 164);
            this.txbRePass.Name = "txbRePass";
            this.txbRePass.Size = new System.Drawing.Size(209, 21);
            this.txbRePass.TabIndex = 3;
            this.txbRePass.UseSystemPasswordChar = true;
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Location = new System.Drawing.Point(20, 170);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(65, 15);
            this.lbRePass.TabIndex = 1;
            this.lbRePass.Text = "Nhập lại:";
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(131, 121);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(209, 21);
            this.txbNewPass.TabIndex = 2;
            this.txbNewPass.UseSystemPasswordChar = true;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(131, 77);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(209, 21);
            this.txbPass.TabIndex = 1;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(131, 28);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(209, 21);
            this.txbUserName.TabIndex = 0;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(20, 124);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(98, 15);
            this.lbNewPass.TabIndex = 0;
            this.lbNewPass.Text = "Mật khẩu mới:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(20, 83);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(89, 15);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Mật khẩu cũ:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.ForeColor = System.Drawing.Color.Black;
            this.lbAccount.Location = new System.Drawing.Point(20, 34);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(74, 15);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Tài khoản:";
            // 
            // fChangePass
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(369, 275);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.fChangePass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbRePass;
        private System.Windows.Forms.Label lbRePass;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbAccount;
    }
}