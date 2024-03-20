namespace todo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthLogin = new System.Windows.Forms.TextBox();
            this.AuthPassword = new System.Windows.Forms.TextBox();
            this.AuthBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AuthLogin
            // 
            this.AuthLogin.Location = new System.Drawing.Point(134, 127);
            this.AuthLogin.Name = "AuthLogin";
            this.AuthLogin.Size = new System.Drawing.Size(205, 20);
            this.AuthLogin.TabIndex = 0;
            // 
            // AuthPassword
            // 
            this.AuthPassword.Location = new System.Drawing.Point(134, 165);
            this.AuthPassword.Name = "AuthPassword";
            this.AuthPassword.Size = new System.Drawing.Size(205, 20);
            this.AuthPassword.TabIndex = 1;
            // 
            // AuthBtn
            // 
            this.AuthBtn.Location = new System.Drawing.Point(134, 203);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(205, 36);
            this.AuthBtn.TabIndex = 2;
            this.AuthBtn.Text = "Login";
            this.AuthBtn.UseVisualStyleBackColor = true;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 369);
            this.Controls.Add(this.AuthBtn);
            this.Controls.Add(this.AuthPassword);
            this.Controls.Add(this.AuthLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AuthLogin;
        private System.Windows.Forms.TextBox AuthPassword;
        private System.Windows.Forms.Button AuthBtn;
    }
}

