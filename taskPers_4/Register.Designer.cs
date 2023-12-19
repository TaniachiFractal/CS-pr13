namespace taskPers_4
{
    partial class Register
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
            this.btRead = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.lbCourse = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(149, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(152, 50);
            this.btRead.TabIndex = 3;
            this.btRead.Text = "Прочитать";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.BtRead_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(12, 12);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(131, 50);
            this.btWrite.TabIndex = 2;
            this.btWrite.Text = "Записать";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.BtWrite_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 33);
            this.tbName.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 25);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Имя: ";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(12, 136);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(65, 25);
            this.lbClass.TabIndex = 9;
            this.lbClass.Text = "Класс:";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rb11);
            this.gb.Controls.Add(this.rb10);
            this.gb.Controls.Add(this.rb9);
            this.gb.Location = new System.Drawing.Point(115, 111);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(154, 55);
            this.gb.TabIndex = 10;
            this.gb.TabStop = false;
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.Location = new System.Drawing.Point(103, 21);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(42, 29);
            this.rb11.TabIndex = 13;
            this.rb11.TabStop = true;
            this.rb11.Text = "11";
            this.rb11.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(51, 21);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(46, 29);
            this.rb10.TabIndex = 12;
            this.rb10.TabStop = true;
            this.rb10.Text = "10";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(6, 21);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(39, 29);
            this.rb9.TabIndex = 11;
            this.rb9.TabStop = true;
            this.rb9.Text = "9";
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(12, 186);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(87, 25);
            this.lbCourse.TabIndex = 11;
            this.lbCourse.Text = "Предмет:";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Информатика",
            "Математика",
            "Физика"});
            this.cbCourse.Location = new System.Drawing.Point(115, 183);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(207, 33);
            this.cbCourse.Sorted = true;
            this.cbCourse.TabIndex = 12;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(339, 236);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btWrite);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Register";
            this.Text = "Регистрация";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.ComboBox cbCourse;
    }
}

