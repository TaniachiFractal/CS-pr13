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

namespace taskPers_3
{
    public partial class taskPers_3 : Form
    {
        // File Name
        string file = @"D:/sam3.txt";


        public taskPers_3()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {   
            try
            {
                FileInfo f1 = new FileInfo(file);
                StreamWriter sw = f1.CreateText();
                sw.Write(tbName.Text + "\n" + tbCity.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamReader sr = new StreamReader(file);
                tbName.Text = sr.ReadLine();
                tbCity.Text = sr.ReadLine();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
