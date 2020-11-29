using System.Windows.Forms;

namespace LibraryProject
{
    partial class BookInfoUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BookCoverpictureBox = new System.Windows.Forms.PictureBox();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.Label();
            this.ISBNnumlabel = new System.Windows.Forms.Label();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.statelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookCoverpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BookCoverpictureBox
            // 
            this.BookCoverpictureBox.BackgroundImage = global::LibraryProject.Properties.Resources.BookDefaultC;
            this.BookCoverpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookCoverpictureBox.InitialImage = global::LibraryProject.Properties.Resources.BookDefaultC;
            this.BookCoverpictureBox.Location = new System.Drawing.Point(5, 5);
            this.BookCoverpictureBox.Name = "BookCoverpictureBox";
            this.BookCoverpictureBox.Size = new System.Drawing.Size(116, 149);
            this.BookCoverpictureBox.TabIndex = 0;
            this.BookCoverpictureBox.TabStop = false;
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Location = new System.Drawing.Point(131, 8);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(52, 15);
            this.booknamelabel.TabIndex = 1;
            this.booknamelabel.Text = "书名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ISBN号：";
            // 
            // authorlabel
            // 
            this.authorlabel.AutoSize = true;
            this.authorlabel.Location = new System.Drawing.Point(131, 35);
            this.authorlabel.Name = "authorlabel";
            this.authorlabel.Size = new System.Drawing.Size(82, 15);
            this.authorlabel.TabIndex = 5;
            this.authorlabel.Text = "第一作者：";
            // 
            // ISBNnumlabel
            // 
            this.ISBNnumlabel.AutoSize = true;
            this.ISBNnumlabel.Location = new System.Drawing.Point(216, 62);
            this.ISBNnumlabel.Name = "ISBNnumlabel";
            this.ISBNnumlabel.Size = new System.Drawing.Size(39, 15);
            this.ISBNnumlabel.TabIndex = 6;
            this.ISBNnumlabel.Text = "0000";
            // 
            // borrowbutton
            // 
            this.borrowbutton.Location = new System.Drawing.Point(443, 131);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(75, 23);
            this.borrowbutton.TabIndex = 7;
            this.borrowbutton.Text = "借阅";
            this.borrowbutton.UseVisualStyleBackColor = true;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(131, 116);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(37, 15);
            this.statelabel.TabIndex = 8;
            this.statelabel.Text = "状态";
            // 
            // BookInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.statelabel);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.BookCoverpictureBox);
            this.Controls.Add(this.ISBNnumlabel);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booknamelabel);
            this.Name = "BookInfoUserControl";
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(521, 160);
            this.Load += new System.EventHandler(this.BookInfoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookCoverpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox BookCoverpictureBox;
        public System.Windows.Forms.Label booknamelabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label authorlabel;
        public System.Windows.Forms.Label ISBNnumlabel;
        public System.Windows.Forms.Button borrowbutton;
        public System.Windows.Forms.Label statelabel;

    }
}
