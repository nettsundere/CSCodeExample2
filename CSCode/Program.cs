using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new TriangleWithHole()
            {
                Height = 1000,
                Base = 100,
                Hole = new Circle()
                {
                    Raduisss = 10
                }
            };

            triangle.GetArea();

            Console.ReadKey();
        }
    }
}
