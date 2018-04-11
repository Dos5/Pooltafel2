using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pool.Properties;
using Pool.Usercontrols;

namespace Pool.Usercontrols
{
    public partial class Uc_Duel : UserControl
    {
        int NumberOfClick = 0;
        public Uc_Duel()
        {
            InitializeComponent();
        }

        private void Btn_SpelerToevoegen_Click(object sender, EventArgs e)
        {
            string spelerinput =  Tb_SpelerInput.Text;
            ++NumberOfClick;
            switch (NumberOfClick)
            {
                case 1:
                    Lb_SpelerLinks.Text = spelerinput;
                    Tb_SpelerInput.Text = " ";
                    break;
                case 2:
                    Lb_SpelerRechts.Text = spelerinput;
                    break;
            }
        }

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Verder_Click(object sender, EventArgs e)
        {
            if(Lb_SpelerLinks.Text == "Speler1" || Lb_SpelerRechts.Text == "Speler2")
            {
                MessageBox.Show("vul eerst 2 namen in voor je verder kan");
            }
            else
            {
                Uc_Stand stand = new Uc_Stand();
                Controls.Add(stand);
                stand.BringToFront();
            }
        }
    }
}
