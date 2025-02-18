using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public partial class ctrlForgotPass : ScrumUserControl
    {
        public ctrlForgotPass()
        {
            InitializeComponent();
        }

        private void ctrlForgotPass_Load(object sender, EventArgs e)
        {

        }

        //Shows security question step if email is associated with account
        private void btn_confirmEmailForgotPassword_Click(object sender, EventArgs e)
        {
            string question = session_.findQuestion(txtbx_emailForgotPassword.Text);
            if (question != null)
            {
                lblForgotPasswordQuestion.Text = "Question: " + question;
                lblForgotPasswordQuestion.Visible = true;
                txtForgotPasswordAnswer.Visible = true;
                btnForgotPasswordSubmit.Visible = true;
                session_.userID = session_.findAccount(txtbx_emailForgotPassword.Text);
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
            if (txtForgotPasswordAnswer.Text.Equals(session_.getAccount(session_.userID).SecurityAnswer))
            {
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
            session_.getAccount(session_.userID).Password = txtForgotPasswordNewPassword.Text;
            this.swapControl(new ctrlLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Takes the user back to the login page
            this.swapControl(new ctrlLogin());
        }
    }
}
