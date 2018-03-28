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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }
        Query Query = new Query();
        private void Register_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            Controls.Add(login);
            login.BringToFront();
        }
        private void TextWw_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Tb_Naam.Text) || string.IsNullOrEmpty(Tb_Wachtwoord.Text) || string.IsNullOrEmpty(Tb_Email.Text) || string.IsNullOrEmpty(Tb_Mobiel.Text))
                {
                    MessageBox.Show("foutmelding niet alle vakken zijn correct ingevuld");
                }
                else
                {
                    string Name = Tb_Naam.Text;
                    string Password = Tb_Wachtwoord.Text;
                    string Email = Tb_Email.Text;
                    string mobiel1 = Tb_Mobiel.Text;
                    int PhoneNumber = Convert.ToInt32(mobiel1);
                    Query.registratie(Name, Password, Email, PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}