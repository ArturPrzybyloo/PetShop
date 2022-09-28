namespace PetShopManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashBtn = new Guna.UI2.WinForms.Guna2Button();
            this.productBtn = new Guna.UI2.WinForms.Guna2Button();
            this.userBtn = new Guna.UI2.WinForms.Guna2Button();
            this.customerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(1176, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 682);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2CirclePictureBox2);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 87);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.logutBtn);
            this.panel3.Controls.Add(this.cashBtn);
            this.panel3.Controls.Add(this.productBtn);
            this.panel3.Controls.Add(this.userBtn);
            this.panel3.Controls.Add(this.customerBtn);
            this.panel3.Controls.Add(this.dashboardBtn);
            this.panel3.Location = new System.Drawing.Point(1, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 598);
            this.panel3.TabIndex = 2;
            // 
            // logutBtn
            // 
            this.logutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logutBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.logutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logutBtn.ForeColor = System.Drawing.Color.White;
            this.logutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logutBtn.Image")));
            this.logutBtn.Location = new System.Drawing.Point(62, 546);
            this.logutBtn.Name = "logutBtn";
            this.logutBtn.Size = new System.Drawing.Size(87, 49);
            this.logutBtn.TabIndex = 9;
            this.logutBtn.Text = "Logout";
            this.logutBtn.Click += new System.EventHandler(this.logutBtn_Click);
            // 
            // cashBtn
            // 
            this.cashBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cashBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cashBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cashBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cashBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.cashBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cashBtn.ForeColor = System.Drawing.Color.White;
            this.cashBtn.Image = ((System.Drawing.Image)(resources.GetObject("cashBtn.Image")));
            this.cashBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cashBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.cashBtn.Location = new System.Drawing.Point(0, 447);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(225, 70);
            this.cashBtn.TabIndex = 8;
            this.cashBtn.Text = "Cash";
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.productBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.productBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.productBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.productBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.productBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.productBtn.Location = new System.Drawing.Point(0, 381);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(225, 70);
            this.productBtn.TabIndex = 7;
            this.productBtn.Text = "Product";
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.userBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.userBtn.Location = new System.Drawing.Point(0, 314);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(225, 70);
            this.userBtn.TabIndex = 6;
            this.userBtn.Text = "User";
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BorderColor = System.Drawing.Color.White;
            this.customerBtn.BorderRadius = 10;
            this.customerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.customerBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.customerBtn.Location = new System.Drawing.Point(0, 249);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(222, 60);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = "Customers";
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.FillColor = System.Drawing.Color.DarkCyan;
            this.dashboardBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.dashboardBtn.Location = new System.Drawing.Point(0, 182);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(225, 70);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Controls.Add(this.Role);
            this.panel4.Controls.Add(this.Username);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Location = new System.Drawing.Point(1, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 184);
            this.panel4.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(77, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(64, 96);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(90, 22);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Role.ForeColor = System.Drawing.Color.White;
            this.Role.Location = new System.Drawing.Point(85, 134);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(40, 18);
            this.Role.TabIndex = 4;
            this.Role.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(98, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pet Shop Management";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1127, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 41);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::PetShopManagementSystem.Properties.Resources.logo;
            this.guna2CirclePictureBox2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(0, 4);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(83, 83);
            this.guna2CirclePictureBox2.TabIndex = 11;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 680);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button logutBtn;
        private Guna.UI2.WinForms.Guna2Button cashBtn;
        private Guna.UI2.WinForms.Guna2Button productBtn;
        private Guna.UI2.WinForms.Guna2Button userBtn;
        private Guna.UI2.WinForms.Guna2Button customerBtn;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label Username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}