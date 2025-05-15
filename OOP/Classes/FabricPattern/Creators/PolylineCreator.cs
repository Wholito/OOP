using OOP.Classes.Base_Classes;
using OOP.Classes.Fabric_Pattern;
using OOP.Classes.Shapes_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.FabricPattern.Creators
{
    public class PolylineCreator : ShapeCreator
    {
        protected override BaseShape CreateShape(Point startPoint) => new BrokenLine(startPoint);
    }
}