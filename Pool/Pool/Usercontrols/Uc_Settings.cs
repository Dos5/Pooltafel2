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
            if (RbtnEngels.Checked)
            {
                //SetCulture("en-US");
               
            }            
        }
        // Set the form's culture.
        /*private void SetCulture(string culture)
        {
            // Make the CultureInfo.
            CultureInfo culture_info = new CultureInfo(culture);

            // Make a ComponentResourceManager.
            ComponentResourceManager component_resource_manager
                = new ComponentResourceManager(this.GetType());

            // Apply resources to the form.
            component_resource_manager.ApplyResources(
                this, "$this", culture_info);

            // Apply resources to the form's controls.
            foreach (Control ctl in this.Controls)
            {
                component_resource_manager.ApplyResources(
                    ctl, ctl.Name, culture_info);
            }
            
        }*/
        

    }
}

