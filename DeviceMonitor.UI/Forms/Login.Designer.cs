namespace DeviceMonitor.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnClose = new Button();
            uPanel1 = new Zhaoxi.CustControls.UPanel();
            lblMsg = new Label();
            btnLogin = new Zhaoxi.CustControls.UButton();
            uPanel3 = new Zhaoxi.CustControls.UPanel();
            txtUserPwd = new TextBox();
            pictureBox6 = new PictureBox();
            uPanel2 = new Zhaoxi.CustControls.UPanel();
            txtUserName = new TextBox();
            pictureBox5 = new PictureBox();
            uLine1 = new Zhaoxi.CustControls.ULine();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            uPanel1.SuspendLayout();
            uPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            uPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 16, 34);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1345, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // uPanel1
            // 
            uPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uPanel1.BgColor = Color.White;
            uPanel1.Controls.Add(lblMsg);
            uPanel1.Controls.Add(btnLogin);
            uPanel1.Controls.Add(uPanel3);
            uPanel1.Controls.Add(uPanel2);
            uPanel1.Controls.Add(uLine1);
            uPanel1.Controls.Add(pictureBox4);
            uPanel1.Controls.Add(pictureBox3);
            uPanel1.Controls.Add(pictureBox2);
            uPanel1.Controls.Add(pictureBox1);
            uPanel1.Controls.Add(label2);
            uPanel1.Controls.Add(label1);
            uPanel1.Location = new Point(202, 105);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 10;
            uPanel1.Size = new Size(997, 685);
            uPanel1.TabIndex = 1;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.Transparent;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(587, 555);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(339, 53);
            lblMsg.TabIndex = 5;
            lblMsg.Text = "请输入账号和密码！";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BgColor = Color.FromArgb(255, 128, 0);
            btnLogin.BorderColor = Color.Peru;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FocusBgColor = Color.DarkOrange;
            btnLogin.FocusForeColor = Color.White;
            btnLogin.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(595, 458);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 30;
            btnLogin.Size = new Size(324, 61);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登录系统";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // uPanel3
            // 
            uPanel3.BackColor = Color.Transparent;
            uPanel3.BgColor = Color.Transparent;
            uPanel3.BorderColor = Color.LightGray;
            uPanel3.BorderWidth = 1;
            uPanel3.Controls.Add(txtUserPwd);
            uPanel3.Controls.Add(pictureBox6);
            uPanel3.Location = new Point(587, 339);
            uPanel3.Name = "uPanel3";
            uPanel3.Size = new Size(339, 63);
            uPanel3.TabIndex = 3;
            // 
            // txtUserPwd
            // 
            txtUserPwd.BorderStyle = BorderStyle.None;
            txtUserPwd.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUserPwd.ForeColor = Color.FromArgb(64, 64, 64);
            txtUserPwd.Location = new Point(64, 19);
            txtUserPwd.Name = "txtUserPwd";
            txtUserPwd.Size = new Size(272, 27);
            txtUserPwd.TabIndex = 1;
            txtUserPwd.Text = "1234";
            txtUserPwd.UseSystemPasswordChar = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.mima;
            pictureBox6.Location = new Point(8, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 47);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // uPanel2
            // 
            uPanel2.BackColor = Color.Transparent;
            uPanel2.BgColor = Color.Transparent;
            uPanel2.BorderColor = Color.LightGray;
            uPanel2.BorderWidth = 1;
            uPanel2.Controls.Add(txtUserName);
            uPanel2.Controls.Add(pictureBox5);
            uPanel2.Location = new Point(587, 220);
            uPanel2.Name = "uPanel2";
            uPanel2.Size = new Size(339, 63);
            uPanel2.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUserName.ForeColor = Color.FromArgb(64, 64, 64);
            txtUserName.Location = new Point(64, 20);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(272, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "admin";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.zhanghao;
            pictureBox5.Location = new Point(8, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // uLine1
            // 
            uLine1.BackColor = Color.Transparent;
            uLine1.LineColor = Color.FromArgb(64, 64, 64);
            uLine1.LineWidth = 2;
            uLine1.Location = new Point(39, 500);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(411, 19);
            uLine1.TabIndex = 2;
            uLine1.Text = "uLine1";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.dev02;
            pictureBox4.Location = new Point(341, 371);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.dev02;
            pictureBox3.Location = new Point(189, 371);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.dev02;
            pictureBox2.Location = new Point(39, 371);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.dev01;
            pictureBox1.Location = new Point(174, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.FromArgb(53, 87, 117);
            label2.Location = new Point(657, 121);
            label2.Name = "label2";
            label2.Size = new Size(207, 42);
            label2.TabIndex = 0;
            label2.Text = "系统登录";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.FromArgb(53, 87, 117);
            label1.Location = new Point(13, 40);
            label1.Name = "label1";
            label1.Size = new Size(500, 73);
            label1.TabIndex = 0;
            label1.Text = "智能设备监控预警中心";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 55, 87);
            ClientSize = new Size(1406, 886);
            Controls.Add(uPanel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "智能设备监控预警中心";
            Load += Login_Load;
            uPanel1.ResumeLayout(false);
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Zhaoxi.CustControls.UPanel uPanel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Zhaoxi.CustControls.UPanel uPanel2;
        private Zhaoxi.CustControls.ULine uLine1;
        private Zhaoxi.CustControls.UPanel uPanel3;
        private PictureBox pictureBox5;
        private TextBox txtUserPwd;
        private PictureBox pictureBox6;
        private TextBox txtUserName;
        private Zhaoxi.CustControls.UButton btnLogin;
        private Label lblMsg;
    }
}