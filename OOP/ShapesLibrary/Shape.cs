﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    //A class library is a non-executable project which its purpose is to contain a collection of "resources"/classes
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Color BorderColor { get; set; }
        public string FillColor { get; set; }


   

        public Shape(int x, int y, Color borderColor) 
        {
            BorderColor = borderColor;

        }

        public virtual double FindArea()
        {
            return 0;
        }

        public virtual double FindPerimeter()
        {
            return 0;
        }

        public virtual void Draw(Graphics g)
        {
            g.DrawLine(new Pen(BorderColor), X, Y, X, Y);
        }

    }
}
