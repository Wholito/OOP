using OOP.Classes.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Shapes_Classes
{
    internal class RectangleShape : BaseShape
    {
        private Rectangle rect;

        public RectangleShape(Point start, Point end)
        {
            UpdateRectangle(start, end);
        }

        private void UpdateRectangle(Point start, Point end)
        {
            rect = new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(start.X - end.X),
                Math.Abs(start.Y - end.Y));
        }

        public override void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(FillColor))
            using (var pen = new Pen(StrokeColor, StrokeWidth))
            {
                g.FillRectangle(brush, rect);
                g.DrawRectangle(pen, rect);
            }
        }

        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            UpdateRectangle(startPoint, endPoint);
        }
    }
}