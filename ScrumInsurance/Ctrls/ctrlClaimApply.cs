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
    public partial class ctrlClaimApply : ScrumUserControl
    {
        public ctrlClaimApply()
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
            string file_path = txtFilepaths.Text;
            byte[] file_data = ReadFile(file_path);
            string file_name = Path.GetFileName(file_path);

            if (DBController.UploadDocument(file_name, file_data))
            {
                MessageBox.Show("File uploaded successfully!");
            }
            else
            {
                MessageBox.Show("File upload failed.");
            }

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DBController.SubmitClaim(Convert.ToInt64(Session.UserAccount.ID), txtTitle.Text, txtDetails.Text, Convert.ToInt32(txtAmount.Text)))
            {
                ((Client)Session.UserAccount).AddClaim(txtTitle.Text, txtDetails.Text, "Validating", Convert.ToInt32(txtAmount.Text));
                lblError.Text = "Claim submitted succcesfully";
                txtTitle.Text = "";
                txtDetails.Text = "";
                txtAmount.Text = "";
            }
            else
            {
                lblError.Text = "Unable to submit claim";
            }
            lblError.Visible = true;
        }

        private void btnSaveClaim_Click(object sender, EventArgs e)
        {
            if (DBController.SubmitClaim(Convert.ToInt64(Session.UserAccount.ID), txtTitle.Text, txtDetails.Text, Convert.ToInt32(txtAmount.Text)))
            {
                ((Client)Session.UserAccount).AddClaim(txtTitle.Text, txtDetails.Text, "Incomplete", Convert.ToInt32(txtAmount.Text));
                lblError.Text = "Claim saved succcesfully";
            }
            else
            {
                lblError.Text = "Unable to save claim";
            }
            lblError.Visible = true;
        }
    }
}
  
