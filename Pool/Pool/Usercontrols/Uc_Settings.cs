using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Resources;

namespace Pool
{
    public partial class Settings : UserControl
    {
        
        public Settings()
        {
            InitializeComponent();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnBevestig_Click(object sender, EventArgs e)
        {
          /*if (RbtnEngels.Checked) {
                foreach (var item in Settings)
                {

                }
            }*/             
        }  
    }
}

