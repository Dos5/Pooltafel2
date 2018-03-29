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
    public partial class Register : UserControl
    {
        Query Query = new Query();
        //Fields
        private string naam;
        private string wachtwoord;
        private string Email;
        private int telefoonNummer;
        public Register()
        {
            InitializeComponent();
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Tb_Naam.Text) || string.IsNullOrEmpty(Tb_Wachtwoord.Text) || string.IsNullOrEmpty(Tb_Email.Text) || string.IsNullOrEmpty(Tb_Mobiel.Text))
            {
                 //Laat waarschuwing zien
                 MessageBox.Show("Niet alle velden zijn ingevuld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //Zet de velden naar de ingevoerde data
                    naam = Tb_Naam.Text;
                    wachtwoord = Tb_Wachtwoord.Text;
                    Email = Tb_Email.Text;
                    telefoonNummer = Convert.ToInt32(Tb_Mobiel.Text);
                    //Roep de Query aan voor registratie
                    Query.RegistratieQuery(naam, wachtwoord, Email, telefoonNummer);
                }
                catch (Exception Ex)
                {
                    //Schrijf de fout naar een Txt bestand
                    File.AppendAllText(Environment.CurrentDirectory.ToString() + "\\Error Log.txt", DateTime.Now.ToString() + " Een registratie fout is waargenomen." + Environment.NewLine + Ex + Environment.NewLine + Environment.NewLine);
                    //Geef een fout melding naar de gebruiker
                    MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            //Sluit dit scherm
            this.Hide();
        }
    }
}