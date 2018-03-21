using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnWachtwoord_Click(object sender, EventArgs e)
        {
            WachtwoordVergeten wachtwoordVergeten = new WachtwoordVergeten();
            Controls.Add(wachtwoordVergeten);
            wachtwoordVergeten.BringToFront();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Ingelogd ingelogd = new Ingelogd();
            Controls.Add(ingelogd);
            ingelogd.BringToFront();
        }
    }
}
