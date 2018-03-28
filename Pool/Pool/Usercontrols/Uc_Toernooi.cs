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
    public partial class Toernooi : UserControl
    {

        public int HoeveelheidSpelers;

        public Toernooi()
        {
            InitializeComponent();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnVerder_Click(object sender, EventArgs e)
        {

        }

        private void RadiobtnVierspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 4;
        }

        private void RadiobtnZesspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 6;
        }

        private void RadiobtnAchtspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 8;
        }

        private void RadiobtnTienspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 10;
        }
    }
}
