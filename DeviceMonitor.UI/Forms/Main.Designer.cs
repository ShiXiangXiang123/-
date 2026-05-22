namespace DeviceMonitor.UI
{
    partial class Main
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
            uFormHeader1 = new Zhaoxi.CustControls.UFormHeader();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            navUser = new NavItem.NavItem();
            navReport = new NavItem.NavItem();
            navConnectionState = new NavItem.NavItem();
            navAlarm = new NavItem.NavItem();
            navTrends = new NavItem.NavItem();
            navSystem = new NavItem.NavItem();
            navDevice = new NavItem.NavItem();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uFormHeader1
            // 
            uFormHeader1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uFormHeader1.Background = Color.FromArgb(25, 55, 88);
            uFormHeader1.BorderColor = Color.FromArgb(23, 55, 77);
            uFormHeader1.Font = new Font("华文中宋", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uFormHeader1.Header = "智能设备监控预警中心";
            uFormHeader1.Location = new Point(1, 3);
            uFormHeader1.Name = "uFormHeader1";
            uFormHeader1.SecondaryColor = Color.SkyBlue;
            uFormHeader1.Size = new Size(1647, 62);
            uFormHeader1.TabIndex = 0;
            uFormHeader1.Text = "uFormHeader1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(1, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1647, 724);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(54, 98, 133);
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(navUser, 6, 0);
            tableLayoutPanel1.Controls.Add(navReport, 5, 0);
            tableLayoutPanel1.Controls.Add(navConnectionState, 0, 0);
            tableLayoutPanel1.Controls.Add(navAlarm, 3, 0);
            tableLayoutPanel1.Controls.Add(navTrends, 4, 0);
            tableLayoutPanel1.Controls.Add(navSystem, 1, 0);
            tableLayoutPanel1.Controls.Add(navDevice, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 799);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1650, 101);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // navUser
            // 
            navUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navUser.Icon = Properties.Resources.zhanghao;
            navUser.Location = new Point(1405, 3);
            navUser.Name = "navUser";
            navUser.Size = new Size(242, 95);
            navUser.TabIndex = 0;
            navUser.Title = "admin";
            // 
            // navReport
            // 
            navReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navReport.Icon = Properties.Resources.tongjibaobiao;
            navReport.Location = new Point(1174, 3);
            navReport.Name = "navReport";
            navReport.SelectedIcon = Properties.Resources.tongjibaobiao1;
            navReport.Size = new Size(225, 95);
            navReport.TabIndex = 0;
            navReport.Title = "报表统计";
            // 
            // navConnectionState
            // 
            navConnectionState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navConnectionState.Icon = Properties.Resources.baojingalarm;
            navConnectionState.Location = new Point(3, 3);
            navConnectionState.Name = "navConnectionState";
            navConnectionState.Size = new Size(241, 95);
            navConnectionState.TabIndex = 0;
            navConnectionState.Title = "已连接";
            // 
            // navAlarm
            // 
            navAlarm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navAlarm.Icon = Properties.Resources.yujingguanli;
            navAlarm.Location = new Point(712, 3);
            navAlarm.Name = "navAlarm";
            navAlarm.SelectedIcon = Properties.Resources.yujingguanli1;
            navAlarm.Size = new Size(225, 95);
            navAlarm.TabIndex = 0;
            navAlarm.Title = "预警管理";
            // 
            // navTrends
            // 
            navTrends.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navTrends.Icon = Properties.Resources.shishiquxian;
            navTrends.Location = new Point(943, 3);
            navTrends.Name = "navTrends";
            navTrends.SelectedIcon = Properties.Resources.shishiquxian1;
            navTrends.Size = new Size(225, 95);
            navTrends.TabIndex = 0;
            navTrends.Title = "实时曲线";
            // 
            // navSystem
            // 
            navSystem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navSystem.Icon = Properties.Resources.xitongpeizhi;
            navSystem.Location = new Point(250, 3);
            navSystem.Name = "navSystem";
            navSystem.SelectedIcon = Properties.Resources.xitongpeizhi1;
            navSystem.Size = new Size(225, 95);
            navSystem.TabIndex = 0;
            // 
            // navDevice
            // 
            navDevice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navDevice.Icon = Properties.Resources.shebeijiance;
            navDevice.Location = new Point(481, 3);
            navDevice.Name = "navDevice";
            navDevice.SelectedIcon = Properties.Resources.shebeijiance1;
            navDevice.Size = new Size(225, 95);
            navDevice.TabIndex = 0;
            navDevice.Title = "设备监控";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1650, 900);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(uFormHeader1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Zhaoxi.CustControls.UFormHeader uFormHeader1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private NavItem.NavItem navUser;
        private NavItem.NavItem navReport;
        private NavItem.NavItem navConnectionState;
        private NavItem.NavItem navAlarm;
        private NavItem.NavItem navTrends;
        private NavItem.NavItem navSystem;
        private NavItem.NavItem navDevice;
    }
}