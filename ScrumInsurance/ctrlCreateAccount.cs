using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScrumInsurance
{
    public partial class ctrlCreateAccount : UserControl
    {
        public ctrlCreateAccount()
        {
            InitializeComponent();
            lblCreateAccountError.Text = "";
        }

        private void ctrlCreateAccount_Load(object sender, EventArgs e)
        {
        }

        //Check if username, password and email are valid (not blank, classic password requirements)
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Session.addAccount(txtCreateUsername.Text, txtCreatePassword.Text, txtCreateEmail.Text, txtCreateQuestion.Text, txtCreateAnswer.Text);
            ctrlLogin c = new ctrlLogin();
            Session.swapControl(this, c);
        }
    }
}
