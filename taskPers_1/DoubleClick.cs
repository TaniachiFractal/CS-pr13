using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskPers_1
{
    public partial class DoubleClickF : Form
    {
        public DoubleClickF()
        {
            InitializeComponent();
        }

        private void DoubleClick_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
            lbChange.Text = "Цвет формы - " + BackColor.ToString();
        }

        private void DoubleClickF_Load(object sender, EventArgs e)
        {

            lbChange.Text = "Цвет формы - " + BackColor.ToString();
        }
    }
}
