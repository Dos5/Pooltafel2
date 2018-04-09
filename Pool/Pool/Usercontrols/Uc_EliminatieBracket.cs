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
        public EliminatieBracket(int ToernooiSpelers)
        {
            InitializeComponent();
            if (ToernooiSpelers == 4)
            {
                Tc_Eliminatiebracket.SelectTab(Tc_4Spelers);
            }
            else if (ToernooiSpelers == 6)
            {
                Tc_Eliminatiebracket.SelectTab(Tc_6Spelers);
            }
            else if (ToernooiSpelers == 8)
            {
                Tc_Eliminatiebracket.SelectTab(Tc_8Spelers);
            }
            else if (ToernooiSpelers == 10)
            {
                Tc_Eliminatiebracket.SelectTab(Tc_10Spelers);
            }
        }
        private void EliminatieBracket_Load(object sender, EventArgs e)
        {

        }
        private void DrawBracket (Label VariabeleLabel1, Label VariabeleLabel2, Label VariabeleLabel3, PaintEventArgs e)
        {
            Pen BracketLine = new Pen (Color.Black, 5);
            int X1 = (VariabeleLabel1.Location.X + VariabeleLabel1.Width);
            int X2 = (VariabeleLabel3.Location.X);
            int X3 = ((X1 + X2) / 2);
            int Y1 = (VariabeleLabel1.Location.Y + (VariabeleLabel1.Height / 2));
            int Y2 = (VariabeleLabel3.Location.Y + (VariabeleLabel3.Height / 2));
            int Y3 = (VariabeleLabel2.Location.Y + (VariabeleLabel2.Height / 2));
            Point Point1 = new Point (X1, Y1);
            Point Point2 = new Point (X1, Y3);
            Point Point3 = new Point (X2, Y2);
            Point Point4 = new Point (X3, Y1);
            Point Point5 = new Point (X3, Y2);
            Point Point6 = new Point (X3, Y3);
            e.Graphics.DrawLine(BracketLine, Point1, Point4);
            e.Graphics.DrawLine(BracketLine, Point2, Point6);
            e.Graphics.DrawLine(BracketLine, Point4.X, Point4.Y - 2, Point5.X, Point5.Y);
            e.Graphics.DrawLine(BracketLine, Point5.X, Point5.Y, Point6.X, Point6.Y + 3);
            e.Graphics.DrawLine(BracketLine, Point5, Point3);
            BracketLine.Dispose();
        }
        private void Tc_4Spelers_Paint(object sender, PaintEventArgs e)
        {
            // Ronde 1
            DrawBracket(Lb_4Speler_Ronde1_Speler1, Lb_4Speler_Ronde1_Speler2, Lb_4Speler_Ronde2_Speler1, e);
            DrawBracket(Lb_4Speler_Ronde1_Speler3, Lb_4Speler_Ronde1_Speler4, Lb_4Speler_Ronde2_Speler2, e);
            // Ronde 2
            DrawBracket(Lb_4Speler_Ronde2_Speler1, Lb_4Speler_Ronde2_Speler2, Lb_4Speler_Winnaar, e);
        }
        private void Tc_6Spelers_Paint(object sender, PaintEventArgs e)
        {
            // Ronde 1
            DrawBracket(Lb_6Speler_Ronde1_Speler1, Lb_6Speler_Ronde1_Speler2, Lb_6Speler_Ronde2_Speler1, e);
            DrawBracket(Lb_6Speler_Ronde1_Speler3, Lb_6Speler_Ronde1_Speler4, Lb_6Speler_Ronde2_Speler3, e);
            // Ronde 2
            DrawBracket(Lb_6Speler_Ronde2_Speler1, Lb_6Speler_Ronde2_Speler2, Lb_6Speler_Ronde3_Speler1, e);
            DrawBracket(Lb_6Speler_Ronde2_Speler3, Lb_6Speler_Ronde2_Speler4, Lb_6Speler_Ronde3_Speler2, e);
            // Ronde 3
            DrawBracket(Lb_6Speler_Ronde3_Speler1, Lb_6Speler_Ronde3_Speler2, Lb_6Speler_Winnaar, e);
        }
        private void Tc_8Spelers_Paint(object sender, PaintEventArgs e)
        {
            // Ronde 1
            DrawBracket(Lb_8Speler_Ronde1_Speler1, Lb_8Speler_Ronde1_Speler2, Lb_8Speler_Ronde2_Speler1, e);
            DrawBracket(Lb_8Speler_Ronde1_Speler3, Lb_8Speler_Ronde1_Speler4, Lb_8Speler_Ronde2_Speler2, e);
            DrawBracket(Lb_8Speler_Ronde1_Speler5, Lb_8Speler_Ronde1_Speler6, Lb_8Speler_Ronde2_Speler3, e);
            DrawBracket(Lb_8Speler_Ronde1_Speler7, Lb_8Speler_Ronde1_Speler8, Lb_8Speler_Ronde2_Speler4, e);
            // Ronde 2
            DrawBracket(Lb_8Speler_Ronde2_Speler1, Lb_8Speler_Ronde2_Speler2, Lb_8Speler_Ronde3_Speler1, e);
            DrawBracket(Lb_8Speler_Ronde2_Speler3, Lb_8Speler_Ronde2_Speler4, Lb_8Speler_Ronde3_Speler2, e);

            // Lijnen tekenen van ronde 3 naar de winnaar
            Pen BracketLine = new Pen(Color.Black, 5);
            e.Graphics.DrawLine
                (BracketLine,
                Lb_8Speler_Ronde3_Speler1.Location.X + Lb_8Speler_Ronde3_Speler1.Width, 
                Lb_8Speler_Ronde3_Speler1.Location.Y + (Lb_8Speler_Ronde3_Speler1.Height / 2), 
                Lb_8Speler_Ronde3_Speler2.Location.X + Lb_8Speler_Ronde3_Speler2.Width, 
                Lb_8Speler_Ronde3_Speler2.Location.Y + (Lb_8Speler_Ronde3_Speler2.Height / 2));
            BracketLine.Dispose();
        }
        private void Tc_10Spelers_Paint(object sender, PaintEventArgs e)
        {
            // Ronde 1
            DrawBracket(Lb_10Speler_Ronde1_Speler1, Lb_10Speler_Ronde1_Speler2, Lb_10Speler_Ronde2_Speler1, e);
            DrawBracket(Lb_10Speler_Ronde1_Speler3, Lb_10Speler_Ronde1_Speler4, Lb_10Speler_Ronde2_Speler4, e);
            DrawBracket(Lb_10Speler_Ronde1_Speler5, Lb_10Speler_Ronde1_Speler6, Lb_10Speler_Ronde2_Speler5, e);
            DrawBracket(Lb_10Speler_Ronde1_Speler7, Lb_10Speler_Ronde1_Speler8, Lb_10Speler_Ronde2_Speler6, e);
            // Ronde 2
            DrawBracket(Lb_10Speler_Ronde2_Speler1, Lb_10Speler_Ronde2_Speler2, Lb_10Speler_Ronde3_Speler1, e);            
            DrawBracket(Lb_10Speler_Ronde2_Speler3, Lb_10Speler_Ronde2_Speler4, Lb_10Speler_Ronde3_Speler2, e);
            DrawBracket(Lb_10Speler_Ronde2_Speler5, Lb_10Speler_Ronde2_Speler6, Lb_10Speler_Ronde4_Speler2, e);
            // Ronde 3
            DrawBracket(Lb_10Speler_Ronde3_Speler1, Lb_10Speler_Ronde3_Speler2, Lb_10Speler_Ronde4_Speler1, e);

            // Lijnen tekenen van ronde 4 naar de winnaar
            Pen BracketLine = new Pen(Color.Black, 5);
            e.Graphics.DrawLine
                (BracketLine,
                Lb_10Speler_Ronde4_Speler1.Location.X + Lb_10Speler_Ronde4_Speler1.Width,
                Lb_10Speler_Ronde4_Speler1.Location.Y + (Lb_10Speler_Ronde4_Speler1.Height / 2),
                Lb_10Speler_Ronde4_Speler2.Location.X + Lb_10Speler_Ronde4_Speler2.Width,
                Lb_10Speler_Ronde4_Speler2.Location.Y + (Lb_10Speler_Ronde4_Speler2.Height / 2));
            BracketLine.Dispose();
        }
        private void Btn_Terug1_Click(object sender, EventArgs e)
        {
            //Sluit dit scherm
            this.Visible = false;
        }
    }
}