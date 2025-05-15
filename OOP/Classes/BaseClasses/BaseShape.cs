using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OOP.Classes.Base_Classes
{
    public abstract class BaseShape
    {
        public Color StrokeColor { get; set; }
        public int StrokeWidth { get; set; }
        public Color FillColor { get; set; }

        public abstract void Draw(Graphics g);
        public abstract void UpdateShape(Point startPoint, Point endPoint);
    }

}