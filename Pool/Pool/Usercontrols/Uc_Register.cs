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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            Controls.Add(login);
            login.BringToFront();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Tb_naam.Text)|| string.IsNullOrEmpty(Tb_wachtwoord.Text) || string.IsNullOrEmpty(Tb_email.Text) || string.IsNullOrEmpty(Tb_mobiel.Text))
                {
                    MessageBox.Show("foutmelding niet alle vakken zijn correct ingevuld");
                }
                else
                {
                    string Name = Tb_naam.Text;
                    string Password = Tb_wachtwoord.Text;
                    string Email = Tb_email.Text;
                    string mobiel1 = Tb_mobiel.Text;
                    int PhoneNumber = Convert.ToInt32(mobiel1);
                    Query.registratie(Name ,Password ,Email , PhoneNumber);
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextWw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
