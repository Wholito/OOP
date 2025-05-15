using OOP.Classes.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Shapes_Classes
{
    internal class Line : BaseShape
    {
        private Point startPoint;
        private Point endPoint;

        public Line(Point start, Point end)
        {
            startPoint = start;
            endPoint = end;
        }

        public override void Draw(Graphics g)
        {
            using (var pen = new Pen(StrokeColor, StrokeWidth))
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
        }
        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
    }
}