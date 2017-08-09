using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCode
{
    interface IAreaCalculable<T>
    {
        T GetArea();
    }

    /// <summary>
    /// The circle.
    /// </summary>
    class Circle : IAreaCalculable<double>
    {
        public double Raduisss { get; set; }

        public double GetArea()
        {
            Console.WriteLine("Getting an area of a circle...");

            return Math.PI * Raduisss * Raduisss;
        }
    }

    /// <summary>
    /// The triangle.
    /// </summary>
    class Triangle : IAreaCalculable<double>
    {
        public double Height { get; set; }
        public double Base { get; set; }

        public virtual double GetArea()
        {
            Console.WriteLine("Getting an area of a triangle...");

            return 0.5 * Height * Base;
        }
    }

    /// <summary>
    /// Triangle, but with a hole inside.
    /// </summary>
    class TriangleWithHole : Triangle
    {
        public Circle Hole { get; set; }

        public override double GetArea()
        {
            Console.WriteLine("Getting an area of a triangle minus an area of a circle...");

            return base.GetArea() - Hole.GetArea();
        }
    }
}
