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
        int buttonclick = 0;
       public static bool isopen = false;
        public PooltafelMain()
        {
            InitializeComponent();
        }
        private void Btn_Afsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Controls.Add(login);
            login.BringToFront();
        }
        private void Btn_Registreren_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Controls.Add(register);
            register.BringToFront();
        }
        private void Btn_Settings_Click(object sender, EventArgs e)
        {
         //   buttonclick++;        
            Settings settings = new Settings();
            Controls.Add(settings);
            settings.BringToFront();
            
        }
    }
}
