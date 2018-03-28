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
    public partial class Uc_Spelers : UserControl
    {

        TextBox[] PlayerTextboxes = new TextBox[11];  

        public Uc_Spelers(int Aantal )
        {
            InitializeComponent();
            if (PlayerTextboxes[1] == null)
            {
                PlayerTextboxes[1] = TbxTeam1Speler1;
                PlayerTextboxes[2] = TbxTeam2Speler1;
                PlayerTextboxes[3] = TbxTeam1Speler2;
                PlayerTextboxes[4] = TbxTeam2Speler2;
                PlayerTextboxes[5] = TbxTeam1Speler3;
                PlayerTextboxes[6] = TbxTeam2Speler3;
                PlayerTextboxes[7] = TbxTeam1Speler4;
                PlayerTextboxes[8] = TbxTeam2Speler4;
                PlayerTextboxes[9] = TbxTeam1Speler5;
                PlayerTextboxes[10] = TbxTeam2Speler5;
            }

            for (int i = 10; i > Aantal; i--)
            {
                PlayerTextboxes[i].Visible = false;
            }

            for (int i = 1; i < Aantal; i++)
            {
                PlayerTextboxes[i].Visible = true;
            }
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
