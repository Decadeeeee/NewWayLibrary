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
            this.ISBNlabel = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.Label();
            this.ISBNnumlabel = new System.Windows.Forms.Label();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.attitudelabel = new System.Windows.Forms.Label();
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
            // ISBNlabel
            // 
            this.ISBNlabel.AutoSize = true;
            this.ISBNlabel.Location = new System.Drawing.Point(131, 62);
            this.ISBNlabel.Name = "ISBNlabel";
            this.ISBNlabel.Size = new System.Drawing.Size(69, 15);
            this.ISBNlabel.TabIndex = 3;
            this.ISBNlabel.Text = "ISBN号：";
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
            this.borrowbutton.Location = new System.Drawing.Point(445, 131);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(75, 23);
            this.borrowbutton.TabIndex = 7;
            this.borrowbutton.Text = "借阅";
            this.borrowbutton.UseVisualStyleBackColor = true;
            // 
            // attitudelabel
            // 
            this.attitudelabel.AutoSize = true;
            this.attitudelabel.Location = new System.Drawing.Point(131, 116);
            this.attitudelabel.Name = "attitudelabel";
            this.attitudelabel.Size = new System.Drawing.Size(37, 15);
            this.attitudelabel.TabIndex = 8;
            this.attitudelabel.Text = "状态";
            // 
            // BookInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attitudelabel);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.BookCoverpictureBox);
            this.Controls.Add(this.ISBNnumlabel);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.ISBNlabel);
            this.Controls.Add(this.booknamelabel);
            this.Name = "BookInfoUserControl";
            this.Size = new System.Drawing.Size(523, 162);
            this.Load += new System.EventHandler(this.BookInfoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookCoverpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookCoverpictureBox;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.Label ISBNlabel;
        private System.Windows.Forms.Label authorlabel;
        private System.Windows.Forms.Label ISBNnumlabel;
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.Label attitudelabel;
    }
}
