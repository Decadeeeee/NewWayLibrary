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
using Library.BLL;

namespace LibraryProject
{
    
    public partial class LoginForm : Form
    {
        /// <summary>
        /// 用户模型
        /// </summary>
        Manager manager;

        public Manager Manager { get => manager; set => manager = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string id = CounttextBox.Text.Trim();
            string pwd = PasswordtextBox.Text.Trim();

            Manager = LoginService.CheckLogin(id,pwd);

            if(Manager.Managerid==id&&Manager.ManagerPassword==pwd)
            {
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();

            }
            else MessageBox.Show("账号密码错误");
        }

    }
}
