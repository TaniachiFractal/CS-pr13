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
using System.Security.Cryptography;

namespace task4
{
    public partial class fRegister : Form
    {

        public fRegister()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            
            if(  !(FieldCheck.CheckNotEmpty(tbName.Text) && FieldCheck.CheckEmail(tbEmail.Text)
                && FieldCheck.CheckLogin(tbLogin.Text) && FieldCheck.CheckPassword(tbPassword.Text)) )
            {
                MessageBox.Show("Повторите Ввод.","ОШИБКА",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Write file
            FileInfo f1 = new FileInfo(@"D:/log.txt");
            try
            {
                StreamWriter sw = f1.CreateText();
                sw.Write(tbName.Text + "\n");
                sw.Write(tbLogin.Text + "\n");
                sw.Write(Hash(tbPassword.Text) + "\n");
                sw.Write(tbEmail.Text + "\n");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка записи \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Файл записан!", "УСПЕХ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        // Hashes a string using MD5
        private static string Hash(string source)
        {
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(source);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                // Output the MD5 hash
                return hash;

                // https://devtut.github.io/csharp/hash-functions.html#md5
            }
        }
    }
}
