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
        Point[] KwartFinale;
        // bewaart de posities van de labels voor de eerste ronde
        Point[] SemiFinale;
        // bewaart de posities van de labels voor de tweede ronde
        Point[] Finale;
        // bewaart de posities van de labels voor de laatste ronde

        public Uc_EliminationBracket(int AantalSpelers)
        {            
            InitializeComponent();

            // Verticaal
            /*
            Posities[0] = new Point(7, 255);    // speler 1 ronde 1
            Posities[1] = new Point(81, 255);   // speler 2 ronde 1
            Posities[2] = new Point(187, 255);  // speler 3 ronde 1   
            Posities[3] = new Point(256, 255);  // speler 4 ronde 1
            Posities[4] = new Point(466, 255);  // speler 5 ronde 1
            Posities[5] = new Point(540, 255);  // speler 6 ronde 1
            Posities[6] = new Point(620, 255);  // speler 7 ronde 1
            Posities[7] = new Point(694, 255);  // speler 8 ronde 1
            Posities[8] = new Point(226, 191);  // speler 1 ronde 2
            Posities[9] = new Point(306, 191);  // speler 2 ronde 2
            Posities[10] = new Point(408, 191); // speler 3 ronde 2
            Posities[11] = new Point(497, 191); // speler 4 ronde 2
            Posities[12] = new Point(57, 145);  // speler 1 ronde 3
            Posities[13] = new Point(256, 145); // speler 2 ronde 3
            Posities[14] = new Point(458, 145); // speler 3 ronde 3
            Posities[15] = new Point(661, 145); // speler 4 ronde 3
            Posities[16] = new Point(150, 107); // speler 1 ronde 4
            Posities[17] = new Point(568, 107); // speler 2 ronde 4
            Posities[18] = new Point(356, 44);  // winnaar
            */
            // zetten van alle posities voor de labels en de lijnen 

            // Horizontaal
            /*
            Posities[0] = new Point(6, 32);    // speler 1 ronde 1
            Posities[1] = new Point(6, 49);   // speler 2 ronde 1
            Posities[2] = new Point(6, 94);  // speler 3 ronde 1   
            Posities[3] = new Point(6, 111);  // speler 4 ronde 1
            Posities[4] = new Point(6, 186);  // speler 5 ronde 1
            Posities[5] = new Point(6, 203);  // speler 6 ronde 1
            Posities[6] = new Point(6, 238);  // speler 7 ronde 1
            Posities[7] = new Point(6, 255);  // speler 8 ronde 1
            Posities[8] = new Point(104, 111);  // speler 1 ronde 2
            Posities[9] = new Point(104, 129);  // speler 2 ronde 2
            Posities[10] = new Point(104, 169); // speler 3 ronde 2
            Posities[11] = new Point(104, 186); // speler 4 ronde 2
            Posities[12] = new Point(217, 32);  // speler 1 ronde 3
            Posities[13] = new Point(217, 111); // speler 2 ronde 3
            Posities[14] = new Point(217, 186); // speler 3 ronde 3
            Posities[15] = new Point(217, 255); // speler 4 ronde 3
            Posities[16] = new Point(329, 86); // speler 1 ronde 4
            Posities[17] = new Point(329, 224); // speler 2 ronde 4
            Posities[18] = new Point(415, 148);  // winnaar
            */

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
