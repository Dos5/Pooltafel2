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
    public partial class Ingelogd : UserControl
    {
        public Ingelogd()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnVerder_Click(object sender, EventArgs e)
        {
            if (RadiobtnDuel.Checked)
            {
                if (Radiobtn9ball.Checked || Radiobtn8ball.Checked)
                {
                    MessageBox.Show("veel plezier! het duel is 'Emo' tegen 'Tuinkabouter'");
                }
                else
                {
                    MessageBox.Show("kies wel een speltype voor je verder kunt");
                }
            }
            else if (RadiobtnToernooi.Checked)
            {
                if (Radiobtn9ball.Checked || Radiobtn8ball.Checked)
                {
                    Toernooi toernooi = new Toernooi();
                    Controls.Add(toernooi);
                    toernooi.BringToFront();
                }
                else
                {
                    MessageBox.Show("selecteer wel een speltype voor je kan beginnen");
                }
            }
            else
            {
                MessageBox.Show("Selecteer ook of je toernooi of duel wil");
            }
            
        }

        private void BtnRegels_Click(object sender, EventArgs e)
        {
            Regels regels = new Regels();
            Controls.Add(regels);
            regels.BringToFront();
        }
    }
}
