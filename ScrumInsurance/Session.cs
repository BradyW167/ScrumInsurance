using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrumInsurance.Ctrls;

namespace ScrumInsurance
{
    public class Session
    {
        // Default constructor
        public Session() {
            UserAccount = new Account();
            CtrlDashboard = null;
            CtrlMain = null;
            CtrlFooter = null;
            ForgotPassFailCount = 0;
        }

        // Stores logged in user's account details
        public Account UserAccount;

        // Stores each section's control
        public ScrumUserControl CtrlDashboard { get; set; }
        public ScrumUserControl CtrlMain { get; set; }
        public ScrumUserControl CtrlFooter { get; set; }

        // Stores error count to kick user out of forgot password page
        public int ForgotPassFailCount { get; set; }
    }
}
