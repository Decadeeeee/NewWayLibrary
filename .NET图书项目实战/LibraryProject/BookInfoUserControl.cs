using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class BookInfoUserControl : UserControl
    {
        public static BookInfoUserControl form;
        public BookInfoUserControl()
        {
            InitializeComponent();
            form = this;
        }

        private void BookInfoUserControl_Load(object sender, EventArgs e)
        {

        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
