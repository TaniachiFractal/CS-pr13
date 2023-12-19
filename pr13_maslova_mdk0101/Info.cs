using System;
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
    public partial class Info : Form
    {
        
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "Текстовый редактор \"Блокнотик\"\r\nразработала студент\r\nгруппы ИП-21-3\r\nМаслова Татьяна";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
