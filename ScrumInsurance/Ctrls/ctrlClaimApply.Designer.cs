namespace ScrumInsurance.Ctrls
{
    partial class ctrlClaimApply
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnDocs = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblClaimDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            this.btnBrowseDocument = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.ofdClaimDocument = new System.Windows.Forms.OpenFileDialog();
            this.btnTestUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(463, 154);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(158, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Apply for claim";
            // 
            // btnDocs
            // 
            this.btnDocs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocs.Location = new System.Drawing.Point(267, 353);
            this.btnDocs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(169, 62);
            this.btnDocs.TabIndex = 1;
            this.btnDocs.Text = "Upload Documents";
            this.btnDocs.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(484, 389);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 26);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblClaimDetails
            // 
            this.lblClaimDetails.AutoSize = true;
            this.lblClaimDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimDetails.Location = new System.Drawing.Point(572, 209);
            this.lblClaimDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimDetails.Name = "lblClaimDetails";
            this.lblClaimDetails.Size = new System.Drawing.Size(133, 18);
            this.lblClaimDetails.TabIndex = 4;
            this.lblClaimDetails.Text = "Enter Claim Details";
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Location = new System.Drawing.Point(575, 228);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(254, 136);
            this.txtDetails.TabIndex = 6;
            this.txtDetails.Text = "";
            // 
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.Location = new System.Drawing.Point(229, 139);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(615, 298);
            this.pbxPillar2.TabIndex = 99;
            this.pbxPillar2.TabStop = false;
            // 
            // btnBrowseDocument
            // 
            this.btnBrowseDocument.Location = new System.Drawing.Point(267, 242);
            this.btnBrowseDocument.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBrowseDocument.Name = "btnBrowseDocument";
            this.btnBrowseDocument.Size = new System.Drawing.Size(104, 26);
            this.btnBrowseDocument.TabIndex = 102;
            this.btnBrowseDocument.Text = "Browse Files";
            this.btnBrowseDocument.UseVisualStyleBackColor = true;
            this.btnBrowseDocument.Click += new System.EventHandler(this.btnBrowseDocument_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(267, 209);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(195, 20);
            this.lblFileName.TabIndex = 103;
            this.lblFileName.Text = "File Name";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(466, 416);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(141, 13);
            this.lblError.TabIndex = 106;
            this.lblError.Text = "Cleared on Initialize";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTestUpload
            // 
            this.btnTestUpload.Location = new System.Drawing.Point(267, 294);
            this.btnTestUpload.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTestUpload.Name = "btnTestUpload";
            this.btnTestUpload.Size = new System.Drawing.Size(104, 26);
            this.btnTestUpload.TabIndex = 107;
            this.btnTestUpload.Text = "Test Upload";
            this.btnTestUpload.UseVisualStyleBackColor = true;
            this.btnTestUpload.Click += new System.EventHandler(this.btnTestUpload_Click);
            // 
            // ctrlClaimApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnTestUpload);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBrowseDocument);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblClaimDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlClaimApply";
            this.Size = new System.Drawing.Size(1080, 607);
            this.Load += new System.EventHandler(this.ctrlClaimApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblClaimDetails;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.PictureBox pbxPillar2;
        private System.Windows.Forms.Button btnBrowseDocument;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.OpenFileDialog ofdClaimDocument;
        private System.Windows.Forms.Button btnTestUpload;
    }
}
