using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
        interface IGeometricShape
        {
            void draw();
        }

    class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("<Line> is drawn");
        }
    }
    class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("<Circle> is drawn");
        }
    }
    class Rectangle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("<Rectangle> is drawn");
        }
    }
}
