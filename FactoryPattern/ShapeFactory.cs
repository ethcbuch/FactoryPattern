using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
        class ShapeFactory
        {
           public enum ShapeType
            {   
                Line,
                Circle,
                Rectangle,
                Triangle
            }
        public IGeometricShape getShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Line:
                    Line aLine = new Line();
                    return aLine;
                case ShapeType.Circle:
                    Circle aCircle = new Circle();
                    return aCircle;
                case ShapeType.Rectangle:
                    Rectangle aRectangle = new Rectangle();
                    return aRectangle;
                default:
                    Console.WriteLine("The " + type + " has not been implemented yet.");
                    return null;
            }
        }
        }
}
