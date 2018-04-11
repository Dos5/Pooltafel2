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
        List<Class_regels> regel_list = new List<Class_regels>();
        private int gameId;

        public Regels(int gameid)
        {
            InitializeComponent();
            this.gameId = gameid;
        }

        private void Regels_Load(object sender, EventArgs e)
        {
            laad_regels();
        }

        public void laad_regels()
        {
            try
            {
                regel_list = Query.Inladen_regels(gameId);
                if (regel_list.Count > 0)
                {
                    foreach (Class_regels class_regels in regel_list)
                    {
                        Lb_Naamregel.Items.Add(class_regels);
                    }
                }
            }
            catch ( Exception e)
            {

                throw e;
            }
        }

        private void Lb_naamregel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Class_regels class_regels = new Class_regels();
                foreach (Class_regels regels in regel_list)
                {
                    if (Lb_Naamregel.SelectedItem == regels)
                    {
                        class_regels = regels;
                        break;
                       
                    }
                }
                Rtb_Regel_Uitleg.Clear();
                Rtb_Regel_Uitleg.Text = class_regels.description;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
