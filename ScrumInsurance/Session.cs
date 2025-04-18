using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public class Session
    {
        // Default constructor
        public Session() {
            UserAccount = new Account();
            CtrlMain = null;
            CtrlDashboard = null;
            ForgotPassFailCount = 0;
        }

        public Account UserAccount;
        public ScrumUserControl CtrlMain { get; set; }
        public ScrumUserControl CtrlDashboard { get; set; }

        // Stores error count to kick user out of forgot password page
        public int ForgotPassFailCount { get; set; }
    }
}
