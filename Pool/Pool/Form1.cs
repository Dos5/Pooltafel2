using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool
{
    public partial class PooltafelMain : Form
    {
        public PooltafelMain()
        {
            InitializeComponent();
        }
        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            Controls.Add(settings);
            settings.BringToFront();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Controls.Add(login);
            login.BringToFront();           
        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
