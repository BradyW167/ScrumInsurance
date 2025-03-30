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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.lblNumClaims = new System.Windows.Forms.Label();
            this.btnMessageA = new System.Windows.Forms.Button();
            this.btnMessageB = new System.Windows.Forms.Button();
            this.btnMessageC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(40, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 511);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Azure;
            this.btnNextPage.Location = new System.Drawing.Point(446, 514);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 34);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Azure;
            this.btnPrevPage.Location = new System.Drawing.Point(364, 514);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 34);
            this.btnPrevPage.TabIndex = 3;
            this.btnPrevPage.Text = "Back";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // lblNumClaims
            // 
            this.lblNumClaims.AutoSize = true;
            this.lblNumClaims.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNumClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClaims.Location = new System.Drawing.Point(376, 551);
            this.lblNumClaims.Name = "lblNumClaims";
            this.lblNumClaims.Size = new System.Drawing.Size(108, 20);
            this.lblNumClaims.TabIndex = 4;
            this.lblNumClaims.Text = "?-?/? Claims";
            this.lblNumClaims.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMessageA
            // 
            this.btnMessageA.BackColor = System.Drawing.Color.Azure;
            this.btnMessageA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMessageA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMessageA.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageA.Location = new System.Drawing.Point(428, 175);
            this.btnMessageA.Name = "btnMessageA";
            this.btnMessageA.Size = new System.Drawing.Size(75, 38);
            this.btnMessageA.TabIndex = 5;
            this.btnMessageA.Text = "View";
            this.btnMessageA.UseVisualStyleBackColor = false;
            // 
            // btnMessageB
            // 
            this.btnMessageB.BackColor = System.Drawing.Color.Azure;
            this.btnMessageB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMessageB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMessageB.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageB.Location = new System.Drawing.Point(428, 271);
            this.btnMessageB.Name = "btnMessageB";
            this.btnMessageB.Size = new System.Drawing.Size(75, 38);
            this.btnMessageB.TabIndex = 6;
            this.btnMessageB.Text = "View";
            this.btnMessageB.UseVisualStyleBackColor = false;
            // 
            // btnMessageC
            // 
            this.btnMessageC.BackColor = System.Drawing.Color.Azure;
            this.btnMessageC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMessageC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMessageC.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageC.Location = new System.Drawing.Point(428, 358);
            this.btnMessageC.Name = "btnMessageC";
            this.btnMessageC.Size = new System.Drawing.Size(75, 38);
            this.btnMessageC.TabIndex = 7;
            this.btnMessageC.Text = "View";
            this.btnMessageC.UseVisualStyleBackColor = false;
            // 
            // ctrlClaimsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.btnMessageC);
            this.Controls.Add(this.btnMessageB);
            this.Controls.Add(this.btnMessageA);
            this.Controls.Add(this.lblNumClaims);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.lblClaimsList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlClaimsList";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaimsList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Label lblNumClaims;
        private System.Windows.Forms.Button btnMessageA;
        private System.Windows.Forms.Button btnMessageB;
        private System.Windows.Forms.Button btnMessageC;
    }
}
