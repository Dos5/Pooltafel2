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
            MessageBox.Show("Het desbtreffende spel wordt gestart");
        }

        private void BtnRegels_Click(object sender, EventArgs e)
        {
            Regels regels = new Regels();
            Controls.Add(regels);
            regels.BringToFront();
        }
    }
}
