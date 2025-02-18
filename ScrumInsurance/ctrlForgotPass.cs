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
    public partial class ctrlForgotPass : UserControl
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
            string question = Session.findQuestion(txtbx_emailForgotPassword.Text);
            if (question != null)
            {
                lblForgotPasswordQuestion.Text = "Question: " + question;
                lblForgotPasswordQuestion.Visible = true;
                txtForgotPasswordAnswer.Visible = true;
                btnForgotPasswordSubmit.Visible = true;
                Session.userID = Session.findAccount(txtbx_emailForgotPassword.Text);
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
            if (txtForgotPasswordAnswer.Text.Equals(Session.getAccount(Session.userID).securityAnswer_))
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
            //updates the user's password and takes the user back to the login page
            Session.getAccount(Session.userID).password_ = txtForgotPasswordNewPassword.Text;
            ctrlLogin c = new ctrlLogin();
            Session.swapControl(this, c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //takes the user back to the login page
            ctrlLogin c = new ctrlLogin();
            Session.swapControl(this, c);
        }
    }
}
