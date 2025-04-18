﻿namespace ScrumInsurance
{
    partial class ClaimApply
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblClaimDetails = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.lblBottomInformation = new System.Windows.Forms.Label();
            this.lblClaim4 = new System.Windows.Forms.Label();
            this.lblClaim3 = new System.Windows.Forms.Label();
            this.lblClaim2 = new System.Windows.Forms.Label();
            this.lblMyClaims = new System.Windows.Forms.Label();
            this.lblClaim1 = new System.Windows.Forms.Label();
            this.pbxSidePanel = new System.Windows.Forms.PictureBox();
            this.pbxBottomPanel = new System.Windows.Forms.PictureBox();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            this.txtFilepaths = new System.Windows.Forms.TextBox();
            this.btnUploadDocuments = new System.Windows.Forms.Button();
            this.btnBrowseDocument = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSaveClaim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBottomPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(444, 105);
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
            this.btnDocs.Location = new System.Drawing.Point(484, 175);
            this.btnDocs.Margin = new System.Windows.Forms.Padding(2);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(79, 64);
            this.btnDocs.TabIndex = 1;
            this.btnDocs.Text = "Upload Documents";
            this.btnDocs.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(609, 339);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 26);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(606, 175);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(141, 18);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Enter Claim Amount";
            // 
            // lblClaimDetails
            // 
            this.lblClaimDetails.AutoSize = true;
            this.lblClaimDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaimDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimDetails.Location = new System.Drawing.Point(606, 222);
            this.lblClaimDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimDetails.Name = "lblClaimDetails";
            this.lblClaimDetails.Size = new System.Drawing.Size(133, 18);
            this.lblClaimDetails.TabIndex = 4;
            this.lblClaimDetails.Text = "Enter Claim Details";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(610, 198);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(133, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Location = new System.Drawing.Point(610, 241);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(133, 64);
            this.txtDetails.TabIndex = 6;
            this.txtDetails.Text = "";
            // 
            // lblTrademark
            // 
            this.lblTrademark.AutoSize = true;
            this.lblTrademark.BackColor = System.Drawing.Color.Black;
            this.lblTrademark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrademark.ForeColor = System.Drawing.Color.White;
            this.lblTrademark.Location = new System.Drawing.Point(492, 550);
            this.lblTrademark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(95, 13);
            this.lblTrademark.TabIndex = 98;
            this.lblTrademark.Text = "Scrum Insurance®";
            // 
            // lblBottomInformation
            // 
            this.lblBottomInformation.AutoSize = true;
            this.lblBottomInformation.BackColor = System.Drawing.Color.Black;
            this.lblBottomInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomInformation.ForeColor = System.Drawing.Color.White;
            this.lblBottomInformation.Location = new System.Drawing.Point(110, 515);
            this.lblBottomInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottomInformation.Name = "lblBottomInformation";
            this.lblBottomInformation.Size = new System.Drawing.Size(863, 13);
            this.lblBottomInformation.TabIndex = 97;
            this.lblBottomInformation.Text = "Here is where you put all the random links and information that is at the bottom " +
    "of the web page like privacy, terms, about, sponsors, maybe also a disclaimer or" +
    " maintenence message.";
            // 
            // lblClaim4
            // 
            this.lblClaim4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim4.ForeColor = System.Drawing.Color.Black;
            this.lblClaim4.Location = new System.Drawing.Point(3, 200);
            this.lblClaim4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaim4.Name = "lblClaim4";
            this.lblClaim4.Size = new System.Drawing.Size(95, 30);
            this.lblClaim4.TabIndex = 96;
            this.lblClaim4.Text = "Unnamed Claim\r\nStatus: Incomplete";
            this.lblClaim4.Visible = false;
            // 
            // lblClaim3
            // 
            this.lblClaim3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim3.ForeColor = System.Drawing.Color.Black;
            this.lblClaim3.Location = new System.Drawing.Point(3, 160);
            this.lblClaim3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaim3.Name = "lblClaim3";
            this.lblClaim3.Size = new System.Drawing.Size(95, 30);
            this.lblClaim3.TabIndex = 95;
            this.lblClaim3.Text = "Unnamed Claim\r\nStatus: Incomplete";
            this.lblClaim3.Visible = false;
            // 
            // lblClaim2
            // 
            this.lblClaim2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim2.ForeColor = System.Drawing.Color.Black;
            this.lblClaim2.Location = new System.Drawing.Point(3, 120);
            this.lblClaim2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaim2.Name = "lblClaim2";
            this.lblClaim2.Size = new System.Drawing.Size(95, 30);
            this.lblClaim2.TabIndex = 94;
            this.lblClaim2.Text = "Unnamed Claim\r\nStatus: Incomplete";
            this.lblClaim2.Visible = false;
            // 
            // lblMyClaims
            // 
            this.lblMyClaims.AutoSize = true;
            this.lblMyClaims.BackColor = System.Drawing.Color.Black;
            this.lblMyClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMyClaims.ForeColor = System.Drawing.Color.White;
            this.lblMyClaims.Location = new System.Drawing.Point(2, 52);
            this.lblMyClaims.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyClaims.Name = "lblMyClaims";
            this.lblMyClaims.Size = new System.Drawing.Size(89, 20);
            this.lblMyClaims.TabIndex = 93;
            this.lblMyClaims.Text = "My Claims";
            this.lblMyClaims.Visible = false;
            // 
            // lblClaim1
            // 
            this.lblClaim1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClaim1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblClaim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblClaim1.ForeColor = System.Drawing.Color.Black;
            this.lblClaim1.Location = new System.Drawing.Point(3, 80);
            this.lblClaim1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaim1.Name = "lblClaim1";
            this.lblClaim1.Size = new System.Drawing.Size(95, 30);
            this.lblClaim1.TabIndex = 92;
            this.lblClaim1.Text = "Unnamed Claim\r\nStatus: Incomplete";
            this.lblClaim1.Visible = false;
            // 
            // pbxSidePanel
            // 
            this.pbxSidePanel.BackColor = System.Drawing.Color.Black;
            this.pbxSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pbxSidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSidePanel.Name = "pbxSidePanel";
            this.pbxSidePanel.Size = new System.Drawing.Size(100, 457);
            this.pbxSidePanel.TabIndex = 91;
            this.pbxSidePanel.TabStop = false;
            // 
            // pbxBottomPanel
            // 
            this.pbxBottomPanel.BackColor = System.Drawing.Color.Black;
            this.pbxBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxBottomPanel.Location = new System.Drawing.Point(0, 457);
            this.pbxBottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pbxBottomPanel.Name = "pbxBottomPanel";
            this.pbxBottomPanel.Size = new System.Drawing.Size(1080, 150);
            this.pbxBottomPanel.TabIndex = 90;
            this.pbxBottomPanel.TabStop = false;
            // 
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.Location = new System.Drawing.Point(297, 90);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(2);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(615, 297);
            this.pbxPillar2.TabIndex = 99;
            this.pbxPillar2.TabStop = false;
            // 
            // txtFilepaths
            // 
            this.txtFilepaths.Location = new System.Drawing.Point(332, 241);
            this.txtFilepaths.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilepaths.Name = "txtFilepaths";
            this.txtFilepaths.Size = new System.Drawing.Size(132, 20);
            this.txtFilepaths.TabIndex = 100;
            // 
            // btnUploadDocuments
            // 
            this.btnUploadDocuments.Location = new System.Drawing.Point(334, 298);
            this.btnUploadDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadDocuments.Name = "btnUploadDocuments";
            this.btnUploadDocuments.Size = new System.Drawing.Size(56, 19);
            this.btnUploadDocuments.TabIndex = 101;
            this.btnUploadDocuments.Text = "Upload";
            this.btnUploadDocuments.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDocument
            // 
            this.btnBrowseDocument.Location = new System.Drawing.Point(332, 211);
            this.btnBrowseDocument.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseDocument.Name = "btnBrowseDocument";
            this.btnBrowseDocument.Size = new System.Drawing.Size(94, 19);
            this.btnBrowseDocument.TabIndex = 102;
            this.btnBrowseDocument.Text = "Browse File";
            this.btnBrowseDocument.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFileName.Location = new System.Drawing.Point(334, 262);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(73, 12);
            this.lblFileName.TabIndex = 103;
            this.lblFileName.Text = "File Name";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(610, 155);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(133, 20);
            this.txtTitle.TabIndex = 105;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(606, 132);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 18);
            this.lblTitle.TabIndex = 104;
            this.lblTitle.Text = "Enter Title";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(540, 367);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(141, 13);
            this.lblError.TabIndex = 106;
            this.lblError.Text = "Cleared on Initialize";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // btnSaveClaim
            // 
            this.btnSaveClaim.Location = new System.Drawing.Point(495, 339);
            this.btnSaveClaim.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveClaim.Name = "btnSaveClaim";
            this.btnSaveClaim.Size = new System.Drawing.Size(110, 26);
            this.btnSaveClaim.TabIndex = 107;
            this.btnSaveClaim.Text = "Save";
            this.btnSaveClaim.UseVisualStyleBackColor = true;
            this.btnSaveClaim.Click += new System.EventHandler(this.btnSaveClaim_Click);
            // 
            // ClaimApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnSaveClaim);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBrowseDocument);
            this.Controls.Add(this.btnUploadDocuments);
            this.Controls.Add(this.txtFilepaths);
            this.Controls.Add(this.lblTrademark);
            this.Controls.Add(this.lblBottomInformation);
            this.Controls.Add(this.lblClaim4);
            this.Controls.Add(this.lblClaim3);
            this.Controls.Add(this.lblClaim2);
            this.Controls.Add(this.lblMyClaims);
            this.Controls.Add(this.lblClaim1);
            this.Controls.Add(this.pbxSidePanel);
            this.Controls.Add(this.pbxBottomPanel);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblClaimDetails);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClaimApply";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBottomPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDocs;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblClaimDetails;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Label lblTrademark;
        private System.Windows.Forms.Label lblBottomInformation;
        private System.Windows.Forms.Label lblClaim4;
        private System.Windows.Forms.Label lblClaim3;
        private System.Windows.Forms.Label lblClaim2;
        private System.Windows.Forms.Label lblMyClaims;
        private System.Windows.Forms.Label lblClaim1;
        private System.Windows.Forms.PictureBox pbxSidePanel;
        private System.Windows.Forms.PictureBox pbxBottomPanel;
        private System.Windows.Forms.PictureBox pbxPillar2;
        private System.Windows.Forms.TextBox txtFilepaths;
        private System.Windows.Forms.Button btnUploadDocuments;
        private System.Windows.Forms.Button btnBrowseDocument;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSaveClaim;
    }
}
