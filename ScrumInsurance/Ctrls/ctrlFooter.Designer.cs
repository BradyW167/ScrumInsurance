namespace ScrumInsurance.Ctrls
{
    partial class ctrlFooter
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
            this.lblTrademark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrademark
            // 
            this.lblTrademark.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTrademark.AutoSize = true;
            this.lblTrademark.BackColor = System.Drawing.Color.Black;
            this.lblTrademark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrademark.ForeColor = System.Drawing.Color.White;
            this.lblTrademark.Location = new System.Drawing.Point(493, 14);
            this.lblTrademark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(95, 13);
            this.lblTrademark.TabIndex = 33;
            this.lblTrademark.Text = "Scrum Insurance®";
            // 
            // ctrlFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblTrademark);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 40);
            this.MinimumSize = new System.Drawing.Size(1088, 40);
            this.Name = "ctrlFooter";
            this.Size = new System.Drawing.Size(1088, 40);
            this.Load += new System.EventHandler(this.ctrlFooter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrademark;
    }
}
