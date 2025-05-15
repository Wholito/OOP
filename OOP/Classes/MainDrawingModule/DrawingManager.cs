using OOP.Classes.Base_Classes;
using OOP.Classes.Fabric_Pattern;
using OOP.Classes.MainDrawingModule;
using OOP.Classes.Shapes_Classes;

public class DrawingManager
{
    private IShapeCreator currentCreator;
    private BaseShape previewShape;
    private ShapeHistoryManager shapeHistory = new ShapeHistoryManager();

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
            shapeHistory.AddShape(currentCreator.FinishCreating()); 
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

    public void Undo() => shapeHistory.Undo();
    public void Redo() => shapeHistory.Redo();

    public void DrawAll(Graphics g)
    {
        shapeHistory.DrawAll(g);

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

