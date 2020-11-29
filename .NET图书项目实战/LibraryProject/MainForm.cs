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
using Library.View.Models;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        LoginForm _loginForm;
        
        public MainForm(LoginForm form)
        {
            this.IsMdiContainer = true;
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
            List<BookInfo> bookInfos = BookService.GetBookInfo();
            int x = 2,y=2;

            foreach(BookInfo bookInfo in bookInfos)
            {
                BookInfoUserControl bookinfoC = new BookInfoUserControl();
                bookinfoC.booknamelabel.Text = bookInfo.BookName;
                if (bookInfo.Bookstate)
                {
                    bookinfoC.statelabel.Text = "正常";
                    if (bookInfo.Num <= bookInfo.Lendnum)
                    {
                        bookinfoC.statelabel.Text = "已全部借出";
                        bookinfoC.borrowbutton.Enabled = false;
                    }
                }
                else {
                    bookinfoC.statelabel.Text = "报废";
                    bookinfoC.borrowbutton.Enabled = false;
                }
                bookinfoC.authorlabel.Text = bookInfo.Author;
                bookinfoC.ISBNnumlabel.Text = bookInfo.ISBN;
                bookinfoC.BorderStyle = BorderStyle.FixedSingle;
                //bookinfoC.Location = new Point(x,y);
                //y = y + bookinfoC.Size.Height;

                 


                BookinfolistView.Items.Add(bookinfoC);
            }

        }

        private void 密码修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePWD_cs changePWD_Cs = new ChangePWD_cs(LoginForm.Manager);
            //changePWD_Cs.MdiParent = this;
            changePWD_Cs.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BookinfolistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
