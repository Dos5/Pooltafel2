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
        private void Btn_Verder_Click(object sender, EventArgs e)
        {
            if (Rbtn_Toernooi.Checked || Rbtn_Duel.Checked)
            {
                if (Rbtn_9ball.Checked || Rbtn_8ball.Checked)
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
        private void Btn_Regels_Click(object sender, EventArgs e)
        {
            Regels regels = new Regels();
            Controls.Add(regels);
            regels.BringToFront();
        }
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}