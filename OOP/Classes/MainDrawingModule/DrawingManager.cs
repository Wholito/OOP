using OOP.Classes.Base_Classes;
using OOP.Classes.Shapes_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.MainDrawingModule
{
    public class DrawingManager
    {
        private IShapeCreator currentCreator;
        private List<BaseShape> shapes = new List<BaseShape>();
        private BaseShape previewShape;

        public Color StrokeColor { get; set; } = Color.Black;
        public int StrokeWidth { get; set; } = 1;
        public Color FillColor { get; set; } = Color.Transparent;

        public void SetShapeCreator(IShapeCreator creator)
        {
            currentCreator = creator;
        }

        public void StartDrawing(Point startPoint)
        {
            if (currentCreator != null)
            {
                previewShape = currentCreator.StartCreating(startPoint);
                ApplyCurrentStyles(previewShape);
            }
        }

        public void UpdateDrawing(Point currentPoint)
        {
            if (currentCreator?.IsCreating == true)
            {
                currentCreator.UpdateShape(currentPoint);
            }
        }

        public void EndDrawing(Point endPoint)
        {
            if (currentCreator?.IsCreating == true)
            {
                currentCreator.UpdateShape(endPoint);
                shapes.Add(currentCreator.FinishCreating());
                previewShape = null;
            }
        }

        public void AddPointToCurrentShape(Point point)
        {
            if (previewShape is BrokenLine polyline)
            {
                polyline.AddPoint(point);
            }   
        }


        public void DrawAll(Graphics g)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }

            if (previewShape != null)
            {
                previewShape.Draw(g);
            }
        }

        private void ApplyCurrentStyles(BaseShape shape)
        {
            shape.StrokeColor = StrokeColor;
            shape.StrokeWidth = StrokeWidth;
            shape.FillColor = FillColor;
        }
    }
}
