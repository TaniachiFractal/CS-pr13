using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenImage
{
    public partial class Open_Image : Form
    {
        public Open_Image()
        {
            InitializeComponent();
        }

        private void Open_Image_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog.FileName; this.Text += " - открыт файл " + fn;
                try
                {
                    pbMain.Image = Image.FromFile(fn);  
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Open_Image form = new Open_Image();
            pbMain.Width = form.Width;
            pbMain.Height = form.Height;
        }

        private void Open_Image_Resize(object sender, EventArgs e)
        {
            Open_Image form = new Open_Image();
            pbMain.Width = form.Width;
            pbMain.Height = form.Height;
        }
    }
}
