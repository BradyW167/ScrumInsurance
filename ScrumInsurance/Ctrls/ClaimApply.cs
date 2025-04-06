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
        //upload documents
        private void btnBrowseDocument_Click(object sender, EventArgs e) //choose which file
        {
            //make an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            // Change to filter image files only .jpg .jpeg .png
            openFileDialog.Filter = "All Files (*.*)|*.*"; //filter options
            openFileDialog.FilterIndex = 1; //filter index
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog.FileName; //get the path of specified file
                txtFilepaths.Text = filePath; // displays into the txtbox
                lblFileName.Text = Path.GetFileName(filePath); //shows the file name
            }
        }
        private byte[] ReadFile(string filePath)  //reads the uploaded document into an array
        {
            byte[] fileData = null;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    fileData = br.ReadBytes((int)fs.Length);
                }
                return fileData;
            }
        }
        private void btnUploadDocuments_Click(object sender, EventArgs e) //uploads to database
        {
            string filePath = txtFilepaths.Text;
            byte[] fileData = ReadFile(filePath);
            string fileName = Path.GetFileName(filePath);

            if (Session.DBController.UploadDocument(filePath, fileName, fileData))
            {
                MessageBox.Show("File uploaded successfully!");
            }
            else
            {
                MessageBox.Show("File upload failed.");
            }

            
        }
        

    }
}
  
