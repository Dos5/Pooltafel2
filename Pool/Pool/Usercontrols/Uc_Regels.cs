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
    public partial class Regels : UserControl
    {
        public Regels()
        {
            InitializeComponent();
        }

        private void Lbx_Regels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
