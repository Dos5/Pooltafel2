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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TbNaam.Text != "")
            {
                if (TbWw.Text != "")
                {
                    Ingelogd ingelogd = new Ingelogd();
                    Controls.Add(ingelogd);
                    ingelogd.BringToFront();
                }
                else
                {
                    MessageBox.Show("Vul een wachtwoord in");
                }
            }
            else
            {
                MessageBox.Show("Vul een naam in padoog");
            }
        }
    }
}
