using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceMonitor.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void navUser_Load(object sender, EventArgs e)
        {

        }

        private void navUser_Click(object sender, EventArgs e)
        {
            // 1. 隐藏当前的主界面
            this.Hide();

            // 2. 实例化登录界面
            Login loginForm = new Login();

            // 3. 以对话框模式展示登录界面，并等待用户操作结束
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 如果登录成功（假设你在 Login 界面登录成功后设置了 DialogResult.OK）
                // 重新显示主界面（如果你需要重新加载权限或数据，可以先调用相关初始化方法）
                this.Show();
            }
            else
            {
                // 如果用户直接关闭了登录界面（例如点击右上角的 X）
                // 则彻底关闭主界面，结束当前进程
                this.Close();
                // 备用方案：Application.Exit();
            }
        }
    }
}
