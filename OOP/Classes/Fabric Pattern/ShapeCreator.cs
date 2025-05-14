using OOP.Classes.Base_Classes;
using OOP.Classes.Shapes_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Net;

namespace OOP.Classes.Fabric_Pattern
{
    public abstract class ShapeCreator : IShapeCreator
    {
        protected Point startPoint;
        protected Point endPoint;
        protected BaseShape currentShape;
        public bool IsCreating { get; protected set; }

        public BaseShape StartCreating(Point startPoint)
        {
            this.startPoint = startPoint;
            currentShape = CreateShape(startPoint);
            IsCreating = true;
            return currentShape;
        }

        public void UpdateShape(Point currentPoint)
        {
            if (IsCreating)
            {
                currentShape.UpdateShape(startPoint, currentPoint);
            }
        }

        public BaseShape FinishCreating()
        {
            IsCreating = false;
            return currentShape;
        }

        protected abstract BaseShape CreateShape(Point startPoint);
    }

    public class LineCreator : ShapeCreator
    {
        protected override BaseShape CreateShape(Point startPoint) => new Line(startPoint, startPoint);
    }

    public class RectangleCreator : ShapeCreator
    {
        protected override BaseShape CreateShape(Point startPoint) => new RectangleShape(startPoint, endPoint);
    }

    public class EllipseCreator : ShapeCreator
    {
        protected override BaseShape CreateShape(Point startPoint) => new Circle(startPoint, startPoint);
    }

    public class PolylineCreator : ShapeCreator
    {
        protected override BaseShape CreateShape(Point startPoint) => new BrokenLine(startPoint);
    }

    public class PolygonCreator : ShapeCreator
    {
        private int sides;

        public PolygonCreator(int sides)
        {
            this.sides = sides;
        }

        protected override BaseShape CreateShape(Point startPoint)
        {
            var polygon = new Polygon(startPoint);
            polygon.SetVerticesCount(sides);
            return polygon;
        }
    }
}
