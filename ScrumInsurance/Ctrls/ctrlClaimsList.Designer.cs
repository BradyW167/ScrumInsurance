namespace ScrumInsurance.Ctrls
{
    partial class ctrlClaimsList
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
            this.lblClaimsList = new System.Windows.Forms.Label();
            this.flpClaimList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblClaimsList
            // 
            this.lblClaimsList.AutoSize = true;
            this.lblClaimsList.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimsList.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClaimsList.Location = new System.Drawing.Point(260, 77);
            this.lblClaimsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimsList.Name = "lblClaimsList";
            this.lblClaimsList.Size = new System.Drawing.Size(113, 26);
            this.lblClaimsList.TabIndex = 0;
            this.lblClaimsList.Text = "Claims List";
            // 
            // flpClaimList
            // 
            this.flpClaimList.AutoScroll = true;
            this.flpClaimList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpClaimList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpClaimList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpClaimList.Location = new System.Drawing.Point(265, 103);
            this.flpClaimList.Margin = new System.Windows.Forms.Padding(0);
            this.flpClaimList.Name = "flpClaimList";
            this.flpClaimList.Padding = new System.Windows.Forms.Padding(40, 25, 40, 25);
            this.flpClaimList.Size = new System.Drawing.Size(550, 400);
            this.flpClaimList.TabIndex = 3;
            this.flpClaimList.WrapContents = false;
            // 
            // ctrlClaimsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.flpClaimList);
            this.Controls.Add(this.lblClaimsList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ctrlClaimsList";
            this.Size = new System.Drawing.Size(1080, 607);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimsList;
        private System.Windows.Forms.FlowLayoutPanel flpClaimList;
    }
}
