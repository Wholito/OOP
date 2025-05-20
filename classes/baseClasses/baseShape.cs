using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP
{
    public abstract class baseShape
{

        public Color ColorLine { get; set; }
        public float WidthLine { get; set; }


        public Pen pen;

        public baseShape(Color colorL, float widthL)
        {

            ColorLine = colorL;
            WidthLine = widthL;
            pen = new Pen(ColorLine, WidthLine);
        }

        public abstract void Draw(Graphics graphics);

    }
}
