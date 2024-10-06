using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lufthanza
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FileNameTextBox.Text))
            {
                MessageBox.Show("Please write a file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if file name is empty
            }

            Info.fileName = "D:\\Airport\\" + FileNameTextBox.Text + ".dat";
            if (!File.Exists(Info.fileName)) 
            {
                File.Create(Info.fileName).Close();
                MessageBox.Show("File is Created Successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileExistsLabel.Visible = false;
            }
            else
            {
                FileExistsLabel.Visible = true;
            }
            FileNameTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Info.fileName = "D:\\Airport\\" + FileNameTextBox.Text + ".dat";
            if (File.Exists(Info.fileName))
            {
                File.Delete(Info.fileName);
                MessageBox.Show("File is Deleted Successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("File Not Exists", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FileNameTextBox.Clear();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddForm().Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteButton.Visible = true;
        }

        private void New_Click(object sender, EventArgs e)
        {
            CreateButton.Visible = true;
        }
    }
}
