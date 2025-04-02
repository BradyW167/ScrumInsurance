using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ClaimApply : ScrumUserControl
    {
        public ClaimApply()
        {
            InitializeComponent();
        }
        private void btnBrowseDoc_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Call the ShowDialog method to show the dialog box
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialog.FileName;

                // Display the file path in the TextBox
                txtFilePath.Text = filePath;
            }
        }
        /*
        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
            // Get the file path from the TextBox
            string filePath = txtFilePath.Text;

            // Read the file into a byte array
            byte[] fileData = ReadFile(filePath);

            // Get the file name
            string fileName = Path.GetFileName(filePath);

            // Define your connection string (replace with your actual connection string)
            string connectionString = "your_connection_string_here";

            // Insert the file data into the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Document (fileName, fileData) VALUES (@Document_ID, @Document_Image)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@Document_ID", fileName);
                    cmd.Parameters.AddWithValue("@Document_Image", fileData);

                    // Open the connection and execute the query
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            // Optionally, display a message to indicate success
            MessageBox.Show("File uploaded successfully!");
        }
        */
      
    }
}
  
