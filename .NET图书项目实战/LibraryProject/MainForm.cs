using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        LoginForm _loginForm;
        
        public MainForm(LoginForm form)
        {
            InitializeComponent();
            LoginForm = form;
            if (LoginForm.Manager.MIdentity)
            {
                this.ManagermenuStrip.Visible = true;
                this.Text = "管理员界面";
            }
            else
            {
                this.UsermenuStrip.Visible = true;
            }
        }

        public LoginForm LoginForm { get => _loginForm; set => _loginForm = value; }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManagermenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Close();
        }

        private void Userpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quarybutton_Click(object sender, EventArgs e)
        {


            BookInfoUserControl bookinfo = new BookInfoUserControl();

        }
    }
}
