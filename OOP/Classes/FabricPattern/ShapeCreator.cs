using OOP.Classes.Base_Classes;
using OOP.Classes.Shapes_Classes;
using OOP.Classes.Fabric_Pattern;
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





}