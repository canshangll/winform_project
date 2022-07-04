
namespace js_ape
{
    partial class Login_Page
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.forget_password = new System.Windows.Forms.LinkLabel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(212, 163);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(68, 30);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // forget_password
            // 
            this.forget_password.AutoSize = true;
            this.forget_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forget_password.Location = new System.Drawing.Point(295, 108);
            this.forget_password.Name = "forget_password";
            this.forget_password.Size = new System.Drawing.Size(68, 17);
            this.forget_password.TabIndex = 27;
            this.forget_password.TabStop = true;
            this.forget_password.Text = "忘记密码？";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(128, 163);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(68, 30);
            this.btn_Login.TabIndex = 26;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_PassWord.Location = new System.Drawing.Point(130, 101);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '*';
            this.txt_PassWord.Size = new System.Drawing.Size(160, 23);
            this.txt_PassWord.TabIndex = 25;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserName.Location = new System.Drawing.Point(130, 57);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(160, 23);
            this.txt_UserName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "账号：";
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.forget_password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Page";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.LinkLabel forget_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

