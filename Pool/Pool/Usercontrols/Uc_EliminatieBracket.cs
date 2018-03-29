using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Pool.Usercontrols
{
    public partial class EliminatieBracket : UserControl
    {
        public EliminatieBracket()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(tabControl1.ItemSize.Width, 1);
        }
        private void EliminatieBracket_Load(object sender, EventArgs e)
        {

        }
    }
}