using System.Collections.Generic;
using System.Drawing;
using OOP.Classes.Base_Classes;

namespace OOP.Classes.MainDrawingModule
{
    public class ShapeHistoryManager
    {
        private Stack<BaseShape> undoStack = new Stack<BaseShape>();
        private Stack<BaseShape> redoStack = new Stack<BaseShape>();

        public IReadOnlyCollection<BaseShape> Shapes => undoStack;

        public void AddShape(BaseShape shape)
        {
            undoStack.Push(shape);
            redoStack.Clear(); 
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                var shape = undoStack.Pop();
                redoStack.Push(shape);
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var shape = redoStack.Pop();
                undoStack.Push(shape);
            }
        }

        public void DrawAll(Graphics g)
        {
            foreach (var shape in undoStack)
            {
                shape.Draw(g);
            }
        }

        public void Clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }
    }
}
