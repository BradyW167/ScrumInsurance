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
            this.pnlList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblClaimsList
            // 
            this.lblClaimsList.AutoSize = true;
            this.lblClaimsList.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimsList.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblClaimsList.Location = new System.Drawing.Point(42, 31);
            this.lblClaimsList.Name = "lblClaimsList";
            this.lblClaimsList.Size = new System.Drawing.Size(167, 39);
            this.lblClaimsList.TabIndex = 0;
            this.lblClaimsList.Text = "Claims List";
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Location = new System.Drawing.Point(77, 101);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1463, 682);
            this.pnlList.TabIndex = 2;
            // 
            // ctrlClaimsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lblClaimsList);
            this.Name = "ctrlClaimsList";
            this.Size = new System.Drawing.Size(1620, 934);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimsList;
        private System.Windows.Forms.Panel pnlList;
    }
}
