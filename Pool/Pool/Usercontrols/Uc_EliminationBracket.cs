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
    public partial class Uc_EliminationBracket : UserControl
    {
        Label[] ToernooiSpelers;
        // bewaart de labels waar de speler namen in zullen staan
        Point[] Posities;
        // bewaart de posities van de labels voor het toernooi     

        public Uc_EliminationBracket(int AantalSpelers)
        {
            
            InitializeComponent();

            Posities[0] = new Point(7, 255);
            Posities[1] = new Point(81, 255);
            Posities[2] = new Point(187, 255);
            Posities[3] = new Point(256, 255);
            Posities[4] = new Point(466, 255);
            Posities[5] = new Point(540, 255);
            Posities[6] = new Point(620, 255);
            Posities[7] = new Point(694, 255);
            Posities[8] = new Point(226, 191);
            Posities[9] = new Point(306, 191);
            Posities[10] = new Point(408, 191);
            Posities[11] = new Point(497, 191);
            Posities[12] = new Point(57, 145);
            Posities[13] = new Point(256, 145);
            Posities[14] = new Point(458, 145);
            Posities[15] = new Point(661, 145);
            Posities[16] = new Point(150, 107);
            Posities[17] = new Point(568, 107);
            Posities[18] = new Point(356, 44);
            // zetten van alle posities voor de labels en de lijnen

            for (int i = 0; i < AantalSpelers; i++)
            {
                ToernooiSpelers[i] = new Label();
                // maakt de speler labels aan
            }

            if (AantalSpelers == 4)
            {

            }


        }
    }
}
