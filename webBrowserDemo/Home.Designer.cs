namespace WebBrowserApplication
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnBack = new Button();
            pbxPainting = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            txtbHome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxPainting).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(684, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pbxPainting
            // 
            pbxPainting.BackColor = Color.Transparent;
            pbxPainting.BackgroundImage = (Image)resources.GetObject("pbxPainting.BackgroundImage");
            pbxPainting.Location = new Point(58, 53);
            pbxPainting.Name = "pbxPainting";
            pbxPainting.Size = new Size(688, 361);
            pbxPainting.TabIndex = 1;
            pbxPainting.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(58, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtbHome
            // 
            txtbHome.BackColor = Color.Goldenrod;
            txtbHome.BorderStyle = BorderStyle.FixedSingle;
            txtbHome.Font = new Font("Segoe UI", 12F);
            txtbHome.ForeColor = Color.RoyalBlue;
            txtbHome.Location = new Point(337, 12);
            txtbHome.Name = "txtbHome";
            txtbHome.Size = new Size(291, 34);
            txtbHome.TabIndex = 3;
            txtbHome.Text = "Welcome Home";
            txtbHome.TextAlign = HorizontalAlignment.Center;
            txtbHome.TextChanged += txtbHome_TextChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbHome);
            Controls.Add(dateTimePicker1);
            Controls.Add(pbxPainting);
            Controls.Add(btnBack);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pbxPainting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private PictureBox pbxPainting;
        private DateTimePicker dateTimePicker1;
        private TextBox txtbHome;
    }
}