namespace task3
{
    partial class task3_f
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
            this.personsListView = new System.Windows.Forms.ListView();
            this.Name_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editPersonButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_,
            this.Surname_,
            this.Age_,
            this.Phone});
            this.personsListView.HideSelection = false;
            this.personsListView.Location = new System.Drawing.Point(10, 64);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(701, 436);
            this.personsListView.TabIndex = 5;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            // 
            // Name_
            // 
            this.Name_.Text = "Имя";
            // 
            // Surname_
            // 
            this.Surname_.Text = "Фамилия";
            this.Surname_.Width = 89;
            // 
            // Age_
            // 
            this.Age_.Text = "Возраст";
            this.Age_.Width = 89;
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(138, 12);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(147, 46);
            this.editPersonButton.TabIndex = 4;
            this.editPersonButton.Text = "Редактировать";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(10, 12);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(122, 46);
            this.addPersonButton.TabIndex = 3;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.Width = 88;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(291, 12);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(147, 46);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // task3_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 512);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.personsListView);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "task3_f";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader Name_;
        private System.Windows.Forms.ColumnHeader Surname_;
        private System.Windows.Forms.ColumnHeader Age_;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

