using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserGitHubDemo
{
    public partial class ctrlCreateAccount : UserControl
    {
        public ctrlCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            formMain.session.AddAccount(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtSecurityQuestion.Text, txtlSecurtyQuestionAnswer.Text); ;
        }
    }
}
