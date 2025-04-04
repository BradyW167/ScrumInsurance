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

namespace ScrumInsurance
{
    public partial class ctrlForgotPass : ScrumUserControl
    {
        public ctrlForgotPass()
        {
            InitializeComponent();
            lblForgotPasswordEmailError.Text = "";
            lblForgotPasswordQuestionError.Text = "";
        }

        private void ctrlForgotPass_Load(object sender, EventArgs e)
        {

        }

        //Shows security question step if email is associated with account
        private void btn_confirmEmailForgotPassword_Click(object sender, EventArgs e)
        {
            string question = Session.DBController.RequestInformation(new Dictionary<string, string> { { "email", txtbx_emailForgotPassword.Text } }, new string[] { "question" })[0];
            if (question != null)
            {
                Session.Email = txtbx_emailForgotPassword.Text;
                lblForgotPasswordQuestion.Text = "Question: " + question;
                lblForgotPasswordQuestion.Visible = true;
                txtForgotPasswordAnswer.Visible = true;
                btnForgotPasswordSubmit.Visible = true;
                lblForgotPasswordEmailError.Text = "";
            }
            else
            {
                lblForgotPasswordEmailError.Text = "Email not found";
            }
        }

        //Shows reset password step if security question is answered correctly
        private void btnForgotPasswordSubmit_Click(object sender, EventArgs e)
        {
            if (txtForgotPasswordAnswer.Text.Equals(Session.DBController.RequestInformation(new Dictionary<string, string> { { "email", Session.Email } }, new string[] { "answer" })[0]))
            {
                Session.Username = Session.DBController.RequestInformation(new Dictionary<string, string> { { "email", Session.Email } }, new string[] { "username" })[0];
                lblForgotPasswordNewPassword.Visible = true;
                txtForgotPasswordNewPassword.Visible = true;
                btnForgotPasswordNewPassword.Visible = true;
                lblForgotPasswordQuestionError.Text = "";
            }
            else
            {
                lblForgotPasswordQuestionError.Text = "Inccorrect Answer";
            }
        }

        private void btnForgotPasswordNewPassword_Click(object sender, EventArgs e)
        {
            // Updates the user's password and takes the user back to the login page
            Session.DBController.UpdateAccount(Session.Username, new Dictionary<string, string> { { "password", txtForgotPasswordNewPassword.Text } });
            this.swapCtrlMain(new ctrlLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Takes the user back to the login page
            this.swapCtrlMain(new ctrlLogin());
        }
    }
}
