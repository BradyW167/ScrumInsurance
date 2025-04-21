using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Paddings;

namespace ScrumInsurance
{
    public partial class ctrlClaimApply : ScrumUserControl
    {
        private List<string> DocumentPaths { get; set; }

        public ctrlClaimApply(ScrumUserControl oldCtrl) : base(oldCtrl)
        {
            InitializeComponent();

            DocumentPaths = new List<string>();
        }

        private void ctrlClaimApply_Load(object sender, EventArgs e)
        {
            // Set filter options (PDF, Word)
            this.ofdClaimDocument.Filter = "PDF files (*.pdf)|*.pdf|Word documents (*.docx)|*.docx";

            // Sets initial directory to user's documents directory
            this.ofdClaimDocument.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            // Enables selection of multiple files
            this.ofdClaimDocument.Multiselect = true;

            // Set title of dialog
            this.ofdClaimDocument.Title = "Select a Claim Document";
        }

        /**
         * Opens file dialog for selection of documents
         * Stores their paths in DocumentPaths
         */
        private void btnBrowseDocument_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.ofdClaimDocument.ShowDialog();

            // If file selection was successful...
            if (dr == DialogResult.OK)
            {
                // Loop through each file selected in the dialog
                foreach (string file_path in ofdClaimDocument.FileNames)
                {
                    // Add this file's file path to the list of document paths
                    DocumentPaths.Add(file_path);

                    // Displays file names, seperated by ';'
                    lblFileName.Text = Path.GetFileName(file_path) + ";";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (DBController.SubmitClaim(Session.UserAccount.ID, txtDetails.Text))
            {
                lblError.Text = "Claim submitted succcesfully";
                txtDetails.Text = "";
            }
            else
            {
                lblError.Text = "Unable to submit claim";
            }
            /*
            try
            {
                // Loop through each document in the List
                foreach (string document_path in DocumentPaths)
                {
                    // Stores file name from path
                    string file_name = Path.GetFileName(document_path);

                    // Stores file data as byte array
                    byte[] file_data = File.ReadAllBytes(document_path);

                    // Upload document info to database
                    DBController.UploadDocument(7, file_name, file_data);
                }
            }
            // Catch document upload errors
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }*/
        }

        private void btnTestUpload_Click(object sender, EventArgs e)
        {
            // Loop through each document in the List
            foreach (string document_path in DocumentPaths)
            {
                // Stores file name from path
                string file_name = Path.GetFileName(document_path);

                // Stores file data as byte array
                byte[] file_data = File.ReadAllBytes(document_path);

                // Upload document info to database
                DBController.UploadDocument(7, file_name, file_data);
            }
        }
    }
}
  
