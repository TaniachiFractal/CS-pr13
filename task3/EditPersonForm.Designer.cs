namespace task3
{
    partial class EditPersonForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSur = new System.Windows.Forms.TextBox();
            this.lbSur = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lbPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 22);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Имя:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(278, 33);
            this.tbName.TabIndex = 1;
            // 
            // tbSur
            // 
            this.tbSur.Location = new System.Drawing.Point(109, 75);
            this.tbSur.Name = "tbSur";
            this.tbSur.Size = new System.Drawing.Size(278, 33);
            this.tbSur.TabIndex = 3;
            // 
            // lbSur
            // 
            this.lbSur.AutoSize = true;
            this.lbSur.Location = new System.Drawing.Point(12, 77);
            this.lbSur.Name = "lbSur";
            this.lbSur.Size = new System.Drawing.Size(91, 25);
            this.lbSur.TabIndex = 2;
            this.lbSur.Text = "Фамилия:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(12, 129);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(82, 25);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Возраст:";
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(12, 229);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 46);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(261, 229);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(126, 46);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(109, 129);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(278, 33);
            this.nudAge.TabIndex = 8;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(12, 180);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(87, 25);
            this.lbPhone.TabIndex = 9;
            this.lbPhone.Text = "Телефон:";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(109, 178);
            this.mtbPhone.Mask = "+0 (999) 000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(278, 33);
            this.mtbPhone.TabIndex = 10;
            // 
            // EditPersonForm
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(407, 288);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbSur);
            this.Controls.Add(this.lbSur);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "EditPersonForm";
            this.ShowInTaskbar = false;
            this.Text = "Редактировать данные человека";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSur;
        private System.Windows.Forms.Label lbSur;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}