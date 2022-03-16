using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWM01
{
    class BorderRadiusPanel:Panel
    {

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath originalPath = new GraphicsPath();
            int x = 0;
            int y = 0;
            int w = Width;
            int h = Height;
            int a = 60;
            Graphics g = CreateGraphics();
            originalPath.AddArc(x, y, a, a, 180, 90);          // bottom-left circle
            originalPath.AddArc(w - a, y, a, a, 270, 90);      // bottom-right circle
            originalPath.AddArc(w - a, h - a, a, a, 0, 90);    // top-right circle
            originalPath.AddArc(x, h - a, a, a, 90, 90);       // top-left circle
            originalPath.CloseAllFigures();
            Region = new Region(originalPath);
        }
    }
}
