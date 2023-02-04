//Ethan Buchanan
//2-3-23
//CSCI352
//IGeometricShape implementation and code for each shape class and their code

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
