
namespace pr13_maslova_mdk0101
{
    partial class mainForm
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
            this.tbMain = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.dropFont = new System.Windows.Forms.ToolStripMenuItem();
            this.dropColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.dropSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dropOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMain.Location = new System.Drawing.Point(17, 31);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMain.Size = new System.Drawing.Size(523, 323);
            this.tbMain.TabIndex = 2;
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropFont,
            this.dropColor});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(47, 23);
            this.menuView.Text = "Вид";
            // 
            // dropFont
            // 
            this.dropFont.Name = "dropFont";
            this.dropFont.Size = new System.Drawing.Size(180, 24);
            this.dropFont.Text = "Шрифт";
            this.dropFont.Click += new System.EventHandler(this.dropFont_Click);
            // 
            // dropColor
            // 
            this.dropColor.Name = "dropColor";
            this.dropColor.Size = new System.Drawing.Size(180, 24);
            this.dropColor.Text = "Цвет";
            this.dropColor.Click += new System.EventHandler(this.dropColor_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(75, 23);
            this.menuHelp.Text = "Справка";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuHelp,
            this.menuExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(560, 27);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(63, 23);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropSave,
            this.dropOpen});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(56, 23);
            this.menuFile.Text = "Файл";
            // 
            // dropSave
            // 
            this.dropSave.Name = "dropSave";
            this.dropSave.Size = new System.Drawing.Size(180, 24);
            this.dropSave.Text = "Сохранить";
            this.dropSave.Click += new System.EventHandler(this.dropSave_Click);
            this.dropSave.DisplayStyleChanged += new System.EventHandler(this.dropSave_DisplayStyleChanged);
            // 
            // dropOpen
            // 
            this.dropOpen.Name = "dropOpen";
            this.dropOpen.Size = new System.Drawing.Size(180, 24);
            this.dropOpen.Text = "Открыть";
            this.dropOpen.Click += new System.EventHandler(this.dropOpen_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 366);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainForm";
            this.Text = "Блокнотик";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem dropFont;
        private System.Windows.Forms.ToolStripMenuItem dropColor;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem dropSave;
        private System.Windows.Forms.ToolStripMenuItem dropOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

