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
        Query query = new Query();
        //Fields
        private string naam;
        private string wachtwoord;
        public Login()
        {
            InitializeComponent();
        }
        private void Btn_Wachtwoord_Click(object sender, EventArgs e)
        {
            WachtwoordVergeten wachtwoordVergeten = new WachtwoordVergeten();
            Controls.Add(wachtwoordVergeten);
            wachtwoordVergeten.BringToFront();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            naam = Tb_Naam.Text;
            wachtwoord = Tb_Wachtwoord.Text;
            query.LoginQuery(naam, wachtwoord);

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