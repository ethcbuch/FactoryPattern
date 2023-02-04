//Ethan Buchanan
//2-3-23
//CSCI352
//Main implementation runs through each shape
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            ShapeFactory fact = new ShapeFactory();

            foreach (var shape in Enum.GetValues(typeof(ShapeFactory.ShapeType)))
            {
                if (fact.getShape((ShapeFactory.ShapeType)shape) == null)
                    continue;
                else
                    fact.getShape((ShapeFactory.ShapeType)shape).draw();
            }
            Console.ReadKey();
        }
    }
}
