using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Pool
{
    public partial class Regels : UserControl
    {
        //Fields
        private int spel;
        private DataTable regels;
        Query query = new Query();
        public Regels(int spel)
        {
            InitializeComponent();
            //Zet de velden naar de juiste data
            this.spel = spel;
            try
            {
                //Voer de query uit
                regels = query.RegelsQuery(spel);
            }
            catch (Exception Ex)
            {
                //Schrijf de fout naar een Txt bestand
                File.AppendAllText(Environment.CurrentDirectory.ToString() + "\\Error Log.txt", DateTime.Now.ToString() + "Een lees fout is waargenomen." + Environment.NewLine + Ex + Environment.NewLine + Environment.NewLine);
            }
            //Vull de listbox met regel namen
            Lbx_NaamRegels.DataSource = regels;
            Lbx_NaamRegels.DisplayMember = "Name";
        }
        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            //Sluit dit scherm
            this.Hide();
        }
        private void Lbx_NaamRegels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbx_UitlegRegels.Items.Clear();
            Lbx_UitlegRegels.DataSource = regels;
            DataRow Find = regels.Rows.Find(Lbx_NaamRegels.SelectedItem);
            if (Find != null)
            {
                //yes
            }
            else
            {
                //fuck
            }
        }
    }
}