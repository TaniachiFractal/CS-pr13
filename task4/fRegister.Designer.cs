namespace task4
{
    partial class fRegister
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
            this.Регистрация = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Регистрация
            // 
            this.Регистрация.AutoSize = true;
            this.Регистрация.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Регистрация.Location = new System.Drawing.Point(12, 9);
            this.Регистрация.Name = "Регистрация";
            this.Регистрация.Size = new System.Drawing.Size(193, 42);
            this.Регистрация.TabIndex = 0;
            this.Регистрация.Text = "Регистрация";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 77);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(167, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя пользователя:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(187, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 33);
            this.tbName.TabIndex = 2;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(187, 113);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(340, 33);
            this.tbLogin.TabIndex = 4;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(14, 116);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(66, 25);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Логин:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(187, 152);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(340, 33);
            this.tbPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(14, 155);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 25);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Пароль:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(14, 194);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(71, 25);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "e-mail:";
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(19, 242);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(508, 54);
            this.btEnter.TabIndex = 9;
            this.btEnter.Text = " Создать Аккаунт";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(187, 194);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(340, 33);
            this.tbEmail.TabIndex = 10;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 318);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.Регистрация);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "fRegister";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Регистрация;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

