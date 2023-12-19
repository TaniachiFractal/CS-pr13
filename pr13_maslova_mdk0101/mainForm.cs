using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr13_maslova_mdk0101
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Select the text box font
        private void dropFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            tbMain.Font = fontDialog.Font;
        }

        // Select the text box text color
        private void dropColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            tbMain.ForeColor = colorDialog.Color;
        }

        // Show info about the creator
        private void menuHelp_Click(object sender, EventArgs e)
        {
            Info newForm = new Info();
            newForm.Show();
        }

        // Kill the app
        private void menuExit_Click(object sender, EventArgs e)
        {
            var MBresult = MessageBox.Show("Завершить работу?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MBresult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dropSave_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        // Save a file
        private void dropSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog.FileName;
                this.Text += " - сохранён файл " + fn;
                if (fn != string.Empty)
                {
                    FileInfo f1 = new FileInfo(fn);
                    try
                    {
                        StreamWriter sw = f1.CreateText();
                        sw.Write(tbMain.Text);
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка записи \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        // Open a file
        private void dropOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = string.Empty;
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                string fn = openFileDialog.FileName; this.Text += " - открыт файл " + fn;
                try
                {
                    StreamReader sr = new StreamReader(fn);
                    tbMain.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения \n" + ex.ToString(), "ОШИБКА",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
