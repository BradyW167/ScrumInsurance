namespace ScrumInsurance.Ctrls
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
            this.rtxtDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(17, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(249, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Apply for claim";
            // 
            // btnDocs
            // 
            this.btnDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocs.Location = new System.Drawing.Point(76, 123);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(118, 99);
            this.btnDocs.TabIndex = 1;
            this.btnDocs.Text = "Upload Documents";
            this.btnDocs.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(212, 468);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Apply";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(260, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(203, 26);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Enter Claim Amount";
            // 
            // lblClaimDetails
            // 
            this.lblClaimDetails.AutoSize = true;
            this.lblClaimDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimDetails.Location = new System.Drawing.Point(260, 196);
            this.lblClaimDetails.Name = "lblClaimDetails";
            this.lblClaimDetails.Size = new System.Drawing.Size(193, 26);
            this.lblClaimDetails.TabIndex = 4;
            this.lblClaimDetails.Text = "Enter Claim Details";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(265, 159);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(198, 26);
            this.txtAmount.TabIndex = 5;
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDetails.Location = new System.Drawing.Point(265, 225);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDetails.Size = new System.Drawing.Size(198, 96);
            this.rtxtDetails.TabIndex = 6;
            this.rtxtDetails.Text = "";
            // 
            // ClaimApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.rtxtDetails);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblClaimDetails);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.lblHeader);
            this.Name = "ClaimApply";
            this.Size = new System.Drawing.Size(602, 572);
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
        private System.Windows.Forms.RichTextBox rtxtDetails;
    }
}
