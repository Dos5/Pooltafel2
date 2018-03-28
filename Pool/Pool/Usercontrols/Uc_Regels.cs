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
        Query Query = new Query();
        private DataTable regels;
        public Regels()
        {
            InitializeComponent();
            regels = Query.Rules;

        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Regels_Load(object sender, EventArgs e)
        {

        }
    }
}
