
namespace taskPers_1
{
    partial class DoubleClickF
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(364, 42);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Кликни 2 раза по форме!";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Location = new System.Drawing.Point(12, 77);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(113, 42);
            this.lbChange.TabIndex = 1;
            this.lbChange.Text = "Цвет = ";
            // 
            // DoubleClickF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 259);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbInfo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "DoubleClickF";
            this.Text = "Двойной Клик";
            this.Load += new System.EventHandler(this.DoubleClickF_Load);
            this.DoubleClick += new System.EventHandler(this.DoubleClick_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbChange;
    }
}

