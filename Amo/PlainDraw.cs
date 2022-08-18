using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Amo
{
    public class PlainDraw : PictureBox
    {
        public PlainDraw()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
