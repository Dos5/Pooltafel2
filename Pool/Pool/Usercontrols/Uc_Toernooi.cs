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

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Verder_Click(object sender, EventArgs e)
        {

        }

        private void Rbtn_Vierspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 4;
        }

        private void Rbtn_Zesspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 6;
        }

        private void Rbtn_Achtspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 8;
        }

        private void Rbtn_Tienspelers_CheckedChanged(object sender, EventArgs e)
        {
            HoeveelheidSpelers = 10;
        }
    }
}
