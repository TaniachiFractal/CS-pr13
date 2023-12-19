using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class task3_f : Form
    {
        public task3_f()
        {
            InitializeComponent();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            // Create Form
            EditPersonForm editPersonForm = new EditPersonForm();
            editPersonForm.Text = "Добавить нового человека";

            // Show Form
            if (editPersonForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            ListViewItem newItem = personsListView.Items.Add(editPersonForm.FName);
            newItem.SubItems.Add(editPersonForm.Surname);
            newItem.SubItems.Add(editPersonForm.Age.ToString());
            newItem.SubItems.Add(editPersonForm.Phone);
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0)
            {
                return;
            }

            // Save the element in a variable
            ListViewItem item = personsListView.SelectedItems[0];
            // Create Form
            EditPersonForm editPersonForm = new EditPersonForm();
            editPersonForm.Text = "Редактировать данные человека";
            // Fill values
            editPersonForm.FName = item.Text;
            editPersonForm.Surname = item.SubItems[1].Text;
            editPersonForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            editPersonForm.Phone = item.SubItems[3].Text;
            if (editPersonForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            item.Text= editPersonForm.FName;
            item.SubItems[1].Text= editPersonForm.Surname;
            item.SubItems[2].Text= editPersonForm.Age.ToString();
            item.SubItems[3].Text = editPersonForm.Phone;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();
                foreach (ListViewItem str in personsListView.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItems in str.SubItems)
                    {
                        sb.Append(subItems.Text);
                        sb.Append(", ");
                    }
                    sb.AppendLine();
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }
        }
    }
}
