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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Tb_Naam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Wachtwoord_Click(object sender, EventArgs e)
        {
            WachtwoordVergeten wachtwoordVergeten = new WachtwoordVergeten();
            Controls.Add(wachtwoordVergeten);
            wachtwoordVergeten.BringToFront();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string naam = Tb_Naam.Text;
            string wachtwoord = Tb_Wachtwoord.Text;
            query.login(naam, wachtwoord);


            Ingelogd ingelogd = new Ingelogd();
            Controls.Add(ingelogd);
            ingelogd.BringToFront();
        }

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
