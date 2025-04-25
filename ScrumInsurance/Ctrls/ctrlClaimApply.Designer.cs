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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblClaimDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.pbxPillar2 = new System.Windows.Forms.PictureBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.ofdClaimDocument = new System.Windows.Forms.OpenFileDialog();
            this.flpDocumentList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilenames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(185, 76);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(180, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Claim Application";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(740, 464);
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
            this.lblClaimDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimDetails.Location = new System.Drawing.Point(556, 196);
            this.lblClaimDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimDetails.Name = "lblClaimDetails";
            this.lblClaimDetails.Size = new System.Drawing.Size(160, 21);
            this.lblClaimDetails.TabIndex = 4;
            this.lblClaimDetails.Text = "Enter Claim Overview";
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Location = new System.Drawing.Point(560, 218);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(300, 158);
            this.txtDetails.TabIndex = 6;
            this.txtDetails.Text = "";
            // 
            // pbxPillar2
            // 
            this.pbxPillar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxPillar2.Location = new System.Drawing.Point(190, 103);
            this.pbxPillar2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbxPillar2.Name = "pbxPillar2";
            this.pbxPillar2.Size = new System.Drawing.Size(700, 400);
            this.pbxPillar2.TabIndex = 99;
            this.pbxPillar2.TabStop = false;
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(250, 465);
            this.btnBrowseFiles.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(104, 26);
            this.btnBrowseFiles.TabIndex = 102;
            this.btnBrowseFiles.Text = "Browse Files";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(732, 450);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(120, 13);
            this.lblError.TabIndex = 106;
            this.lblError.Text = "Cleared on Initialize";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpDocumentList
            // 
            this.flpDocumentList.AutoScroll = true;
            this.flpDocumentList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpDocumentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDocumentList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDocumentList.Location = new System.Drawing.Point(250, 152);
            this.flpDocumentList.Margin = new System.Windows.Forms.Padding(0);
            this.flpDocumentList.Name = "flpDocumentList";
            this.flpDocumentList.Padding = new System.Windows.Forms.Padding(10);
            this.flpDocumentList.Size = new System.Drawing.Size(270, 300);
            this.flpDocumentList.TabIndex = 107;
            this.flpDocumentList.WrapContents = false;
            // 
            // lblFilenames
            // 
            this.lblFilenames.AutoSize = true;
            this.lblFilenames.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblFilenames.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilenames.Location = new System.Drawing.Point(246, 131);
            this.lblFilenames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilenames.Name = "lblFilenames";
            this.lblFilenames.Size = new System.Drawing.Size(89, 21);
            this.lblFilenames.TabIndex = 108;
            this.lblFilenames.Text = "Documents";
            // 
            // ctrlClaimApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.lblFilenames);
            this.Controls.Add(this.flpDocumentList);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblClaimDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbxPillar2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlClaimApply";
            this.Size = new System.Drawing.Size(1080, 607);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPillar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblClaimDetails;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.PictureBox pbxPillar2;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.OpenFileDialog ofdClaimDocument;
        private System.Windows.Forms.FlowLayoutPanel flpDocumentList;
        private System.Windows.Forms.Label lblFilenames;
    }
}
