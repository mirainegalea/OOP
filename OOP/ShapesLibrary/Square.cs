﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Square: Shape
    {

        public double Length { get; set; }

        public Square(int x, int y, double length): base(x, y)
        {
            Length = length;
        
        }

        public override double FindArea()
        {
            return Length * Length;
        }

        public override double FindPerimeter()
        {
            return Length * 4;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(BorderColor), X, Y, (float)Length, (float)Length);
        }
    }
}
