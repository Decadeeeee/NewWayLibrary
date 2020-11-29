namespace LibraryProject
{
    partial class ChangePWD_cs
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
            this.ChangePwdbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldPwdtextBox = new System.Windows.Forms.TextBox();
            this.NewPwdtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChangePwdbutton
            // 
            this.ChangePwdbutton.Location = new System.Drawing.Point(258, 299);
            this.ChangePwdbutton.Name = "ChangePwdbutton";
            this.ChangePwdbutton.Size = new System.Drawing.Size(240, 69);
            this.ChangePwdbutton.TabIndex = 0;
            this.ChangePwdbutton.Text = "确认修改";
            this.ChangePwdbutton.UseVisualStyleBackColor = true;
            this.ChangePwdbutton.Click += new System.EventHandler(this.ChangePwdbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // OldPwdtextBox
            // 
            this.OldPwdtextBox.Location = new System.Drawing.Point(258, 59);
            this.OldPwdtextBox.Name = "OldPwdtextBox";
            this.OldPwdtextBox.Size = new System.Drawing.Size(245, 25);
            this.OldPwdtextBox.TabIndex = 3;
            // 
            // NewPwdtextBox
            // 
            this.NewPwdtextBox.Location = new System.Drawing.Point(258, 126);
            this.NewPwdtextBox.Name = "NewPwdtextBox";
            this.NewPwdtextBox.Size = new System.Drawing.Size(245, 25);
            this.NewPwdtextBox.TabIndex = 4;
            // 
            // ChangePWD_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewPwdtextBox);
            this.Controls.Add(this.OldPwdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePwdbutton);
            this.Name = "ChangePWD_cs";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePwdbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OldPwdtextBox;
        private System.Windows.Forms.TextBox NewPwdtextBox;
    }
}