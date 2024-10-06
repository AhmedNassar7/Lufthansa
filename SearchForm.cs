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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            string id = IDTB.Text;
            string fileName = "D:\\Airport\\" + FileNameTB.Text + ".dat"; // Assuming it's a binary file

            // Check if the FileNameTextBox is empty or if the file does not exist
            if (string.IsNullOrEmpty(id) || !File.Exists(fileName))
            {
                MessageBox.Show("File Name and ID not Exist.");
                return;
            }

            try
            {
                // Calculate hash value of the ID
                int hashValue = Math.Abs(id.GetHashCode());

                // Calculate the location in the file based on the hash value
                long position = (hashValue % (reader.BaseStream.Length / Info.rec_size)) * Info.rec_size;

                // Open the file and seek to the calculated position
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    reader.BaseStream.Seek(position, SeekOrigin.Begin);

                    // Read the ID from the file
                    int recordId = reader.ReadInt32();

                    // If the ID matches the search ID, read and display the record
                    if (recordId == int.Parse(id))
                    {
                        double phone = reader.ReadDouble();
                        string name = new string(reader.ReadChars(20));
                        char gender = reader.ReadChar();

                        // Display data in text boxes
                        NameTB.Text = name;
                        PhoneTB.Text = phone.ToString();
                        GenderTB.Text = gender.ToString();

                        MessageBox.Show("Tourist found.");
                    }
                    else
                    {
                        MessageBox.Show("ID not found in the file.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SearchForm_Load_1(object sender, EventArgs e)
        {
            FileNameTB.Text = Info.fileName;
        }  
    }
}
