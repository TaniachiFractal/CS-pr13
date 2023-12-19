using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class EditPersonForm : Form
    {
        public EditPersonForm()
        {
            InitializeComponent();
        }

        public string FName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public string Surname
        {
            get { return tbSur.Text; }
            set { tbSur.Text = value; }
        }

        public int Age
        {
            get { return (int)nudAge.Value; }
            set { nudAge.Value = value; }
        }

        public string Phone
        {
            get { return mtbPhone.Text; }
            set { mtbPhone.Text = value; }
        }

    }
}
