using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    public class Vector
    {
        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void DisplayVectorInfo()
        {
            Console.WriteLine($"x: {x.ToString("F")} y: {y.ToString("F")} z: {z.ToString("F")}");
        }
        public void DisplayVectorLength()
        {
            Console.WriteLine(Math.Sqrt(x * x + y * y + z * z).ToString("F"));
        }
        public void DisplayScalarMultiplication(Vector b)
        {
            Console.WriteLine("Scalar multiplication of vector1 and vector2 is:");
            Console.WriteLine(Math.Sqrt(x * b.x + y * b.y + z * b.z).ToString("F"));
        }
        public void DisplayVectorAngle(Vector b)
        {
            Console.WriteLine("Vector1 and vector2 form angle:");
            Console.WriteLine((Math.Sqrt(x * b.x + y * b.y + z * b.z) / (Math.Sqrt(x * x + y * y + z * z) * Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z))).ToString("F"));
        }
    }
}
