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
    public partial class WachtwoordVergeten : UserControl
    {
        public WachtwoordVergeten()
        {
            InitializeComponent();
        }

        private Query query = new Query();
        private string naam;
        private string wachtwoord;
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Btn_Verander_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Tb_Naam.Text)|| string.IsNullOrEmpty(Tb_Wachtwoord.Text))
                {
                    MessageBox.Show("niet alle vakken zijn goed ingevuld");
                }
                else
                {
                    naam = Tb_Naam.Text;
                    wachtwoord = Tb_Wachtwoord.Text;
                    query.change_password(naam, wachtwoord);
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void WachtwoordVergeten_Load(object sender, EventArgs e)
        {

        }
    }
}