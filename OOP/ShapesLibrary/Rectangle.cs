﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Rectangle: Square
    {
        public double Width { get; set; }

        public Rectangle(int x, int y, double length, double width)
            :base(x, y, length)
        {
            Width = width;
        }

        public override double FindPerimeter()
        {
            return (Length + Width) * 2;
        }

        public override double FindArea()
        {
            return Length * Width;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(BorderColor), X, Y, (float)Length, (float)Width);
        }
    }
}
