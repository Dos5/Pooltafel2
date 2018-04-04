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
            Tc_Eliminatiebracket.ItemSize = new Size(Tc_Eliminatiebracket.ItemSize.Width, 1);
        }
        private void EliminatieBracket_Load(object sender, EventArgs e)
        {

        }

        private void DrawBracket (PaintEventArgs e, Label VariabeleLabel1, Label VariabeleLabel2, Label VariabeleLabel3)
        {
            Pen BracketLine = new Pen (Color.Black, 5);
            int X1 = (VariabeleLabel1.Location.X + VariabeleLabel1.Width + 15);
            int X2 = (VariabeleLabel3.Location.X - 15);
            int X3 = ((X1 + X2) / 2);
            int Y1 = (VariabeleLabel1.Height + 6);
            int Y2 = (VariabeleLabel2.Height + 6);
            int Y3 = ((Y1 + Y2) / 2);
            Point Point1 = new Point (X1, Y1);
            Point Point2 = new Point (X2, Y1);
            Point Point3 = new Point (X1, Y2);
            Point Point4 = new Point (X2, Y2);
            Point Point5 = new Point (X3, Y2);
            Point Point6 = new Point (X3, Y3);
            e.Graphics.DrawLine(BracketLine, Point1, Point3);
            e.Graphics.DrawLine(BracketLine, Point2, Point4);
            e.Graphics.DrawLine(BracketLine, Point3, Point5);
            e.Graphics.DrawLine(BracketLine, Point4, Point5);
            e.Graphics.DrawLine(BracketLine, Point5, Point6);
        }
    }
}