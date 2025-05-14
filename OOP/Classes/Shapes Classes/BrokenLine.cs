using OOP.Classes.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Shapes_Classes
{
    internal class BrokenLine : BaseShape
    {
        private List<Point> points = new List<Point>();

        public BrokenLine(Point startPoint)
        {
            points.Add(startPoint);
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public override void Draw(Graphics g)
        {
            if (points.Count < 2) return;

            using (var pen = new Pen(StrokeColor, StrokeWidth))
            {
                g.DrawLines(pen, points.ToArray());
            }
        }

        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            if (points.Count == 1)
            {
                points.Add(endPoint);
            }
            else
            {
                points[points.Count - 1] = endPoint;
            }
        }
    }
}
