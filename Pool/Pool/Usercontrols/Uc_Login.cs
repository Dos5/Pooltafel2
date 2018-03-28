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

        Query query = new Query();

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
            bool inloggen = false;
            string naam = Tb_naam.Text;
            string wachtwoord = Tb_wachtwoord.Text;
            inloggen = query.login(naam, wachtwoord);
            if (inloggen == true)
            {
                Ingelogd login = new Ingelogd();
                Controls.Add(login);
                login.BringToFront();
            }
            else if (inloggen == false)
            {
                MessageBox.Show("login failed");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
