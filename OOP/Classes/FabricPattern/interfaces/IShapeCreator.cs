using OOP.Classes.Base_Classes;

namespace OOP.Classes.Fabric_Pattern
{
    public interface IShapeCreator
    {
        BaseShape StartCreating(Point startPoint);
        void UpdateShape(Point currentPoint);
        BaseShape FinishCreating();
        bool IsCreating { get; }
    }
}