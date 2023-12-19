namespace OpenImage
{
    partial class Open_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open_Image));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(12, 70);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1007, 718);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(200, 52);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Открыть картинку";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Open_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1031, 800);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbMain);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Open_Image";
            this.Text = "Открывашка картинок";
            this.ResizeEnd += new System.EventHandler(this.Open_Image_ResizeEnd);
            this.Resize += new System.EventHandler(this.Open_Image_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

