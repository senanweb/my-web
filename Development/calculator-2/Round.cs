﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace calculator_2
{
    class Round :Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(p);
            base.OnPaint(pevent);
        }
    }
}
