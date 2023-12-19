namespace taskPers_3
{
    partial class taskPers_3
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
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(12, 12);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(131, 50);
            this.btWrite.TabIndex = 0;
            this.btWrite.Text = "Прочитать";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(149, 12);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(152, 50);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Записать";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 99);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя: ";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(12, 146);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(63, 25);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "Город:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 33);
            this.tbName.TabIndex = 4;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(94, 143);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(207, 33);
            this.tbCity.TabIndex = 5;
            // 
            // taskPers_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 203);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btWrite);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "taskPers_3";
            this.Text = "Чтение и Запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCity;
    }
}

