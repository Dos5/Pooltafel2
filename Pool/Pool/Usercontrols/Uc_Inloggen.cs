using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Pool
{
    public partial class Login : UserControl
    {
        Query query = new Query();
        //Fields
        private string naam;
        private string wachtwoord;
        private bool inloggen = false;
        public Login()
        {
            InitializeComponent();
        }
        private void Btn_Wachtwoord_Click(object sender, EventArgs e)
        {
            //Open Wachtwoord vergeten scherm
            WachtwoordVergeten wachtwoordVergeten = new WachtwoordVergeten();
            Controls.Add(wachtwoordVergeten);
            wachtwoordVergeten.BringToFront();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tb_Naam.Text) || string.IsNullOrEmpty(Tb_Wachtwoord.Text))
            {
                //Laat waarschuwing zien
                MessageBox.Show("Niet alle velden zijn ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Vul de velden met de juiste data
                    naam = Tb_Naam.Text;
                    wachtwoord = Tb_Wachtwoord.Text;
                    //Roep de Login Query aan
                    inloggen = query.LoginQuery(naam, wachtwoord);
                    if (inloggen == true)
                    {
                        //Open ingelogd scherm
                        Ingelogd ingelogd = new Ingelogd();
                        Controls.Add(ingelogd);
                        ingelogd.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Wachtwoord is onjuist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                catch (Exception Ex)
                {
                    //Schrijf de fout naar een Txt bestand
                    File.AppendAllText(Environment.CurrentDirectory.ToString() + "\\Error Log.txt", DateTime.Now.ToString() + " Een login fout is waargenomen." + Environment.NewLine + Ex + Environment.NewLine + Environment.NewLine);
                    //Geef een fout melding naar de gebruiker
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            //Ingelogd ingelogd = new Ingelogd();
            //Controls.Add(ingelogd);
            //ingelogd.BringToFront();
        }
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            //Sluit dit scherm
            this.Visible = false;
        }
    }
}