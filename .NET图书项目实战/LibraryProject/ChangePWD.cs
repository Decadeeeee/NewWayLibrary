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

/// <summary>
/// 修改密码
/// 
/// </summary>
namespace LibraryProject
{
    public partial class ChangePWD_cs : Form
    {

        public Manager Manager { get; set; }
        public ChangePWD_cs(Manager manager)
        {
            InitializeComponent();
            Manager = manager;
        }

        private void ChangePwdbutton_Click(object sender, EventArgs e)
        {

            if (OldPwdtextBox.Text.Length>0 && NewPwdtextBox.Text.Length>0)
            {
                string oldpwd = OldPwdtextBox.Text.Trim();
                string newpwd = NewPwdtextBox.Text.Trim();

                if (oldpwd == Manager.ManagerPassword)
                {
                   if(ChangePwdservice.SetPassword(Manager.Managerid, newpwd))
                    {
                        Manager.ManagerPassword = newpwd;
                        MessageBox.Show("修改成功");
                    }
                    
                }
                else
                {
                    MessageBox.Show("旧密码错误");
                }
            }

        }
    }
}
