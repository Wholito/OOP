using OOP.Classes.Base_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP.Classes.Shapes_Classes
{
    internal class Polygon : BaseShape
    {
        private Point startPosition;
        private Point endPosition;
        private int nLines;

        public Polygon(Point startPoint)
        {
            startPosition = startPoint;
            endPosition = startPoint;
            nLines = 3; 
        }

        public void SetVerticesCount(int count)
        {
            nLines = Math.Max(3, count); 
        }

        public override void Draw(Graphics g)
        {
            if (nLines < 3) return;

            double angleStep = 2 * Math.PI / nLines;
            PointF[] points = new PointF[nLines];

            float a = Math.Abs(startPosition.X - endPosition.X) / 2;
            float b = Math.Abs(startPosition.Y - endPosition.Y) / 2;
            float centerX = (startPosition.X + endPosition.X) / 2;
            float centerY = (startPosition.Y + endPosition.Y) / 2;

            for (int i = 0; i < nLines; i++)
            {
                double angle = i * angleStep;
                float x = centerX + a * (float)Math.Cos(angle);
                float y = centerY + b * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
            }

            using (var brush = new SolidBrush(FillColor))
            using (var pen = new Pen(StrokeColor, StrokeWidth))
            {
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }
        }

        public override void UpdateShape(Point startPoint, Point endPoint)
        {
            startPosition = startPoint;
            endPosition = endPoint;
        }
    }
}
