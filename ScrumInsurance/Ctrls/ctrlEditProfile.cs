using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance.Ctrls
{
    public partial class ctrlEditProfile : UserControl
    {
        public ctrlEditProfile()
        {
            InitializeComponent();
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }
    }
}
