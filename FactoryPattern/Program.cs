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
                fact.getShape((ShapeFactory.ShapeType)shape).draw();
            }
            Console.ReadKey();
        }
    }
}
