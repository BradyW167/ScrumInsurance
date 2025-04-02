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
        
            // need to use insert query here with the filename from the filepath, and filedata from the image upload
            //not sure how to do this with the sessions set up
         
            MessageBox.Show("File uploaded successfully!");
        }
        */

    }
}
  
