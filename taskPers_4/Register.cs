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

namespace taskPers_4
{
    public partial class Register : Form
    {
        // File Name
        string file = @"D:/reg.txt";

        public Register()
        {
            InitializeComponent();
        }

        private void BtWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == string.Empty || cbCourse.Text == string.Empty || ReturnRadioText(gb) == string.Empty) { throw new InvalidExpressionException("Не все поля заполнены"); }
                FileInfo f1 = new FileInfo(file);
                StreamWriter sw = f1.CreateText();
                sw.Write(tbName.Text + "\n");
                sw.Write(ReturnRadioText(gb)+ "\n");
                sw.Write(cbCourse.Text + "\n");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRead_Click(object sender, EventArgs e)
        {
            try
            {
                

                StreamReader sr = new StreamReader(file);
                tbName.Text = sr.ReadLine();
                string rbBuffer = sr.ReadLine();
                cbCourse.Text = sr.ReadLine();
                if (rb9.Text==rbBuffer)
                {
                    rb9.Checked = true;
                }
                else if (rb10.Text==rbBuffer) 
                { 
                    rb10.Checked = true;
                }
                else
                {
                    rb11.Checked = true;    
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string ReturnRadioText(GroupBox groupBox)
        {
            foreach(RadioButton rb in groupBox.Controls.OfType<RadioButton>()) 
            { 
                if(rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "9";
        }
    }
}
