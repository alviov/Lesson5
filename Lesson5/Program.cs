using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаём два вектора с рандомными координатами
            Random rnd = new Random();
            Vector vector1 = new Vector(rnd.NextDouble() * 10, rnd.NextDouble() * 10, rnd.NextDouble() * 10);
            Vector vector2 = new Vector(rnd.NextDouble() * 10, rnd.NextDouble() * 10, rnd.NextDouble() * 10);

            //выводим данные первого вектора (координаты и длина)
            Console.WriteLine("randomly generated vector1:");
            vector1.DisplayVectorInfo();
            Console.WriteLine("vector1 length is:");
            vector1.DisplayVectorLength();

            //выводим данные второго вектора (координаты и длина)
            Console.WriteLine();
            Console.WriteLine("randomly generated vector2:");
            vector2.DisplayVectorInfo();
            Console.WriteLine("vector2 length is:");
            vector2.DisplayVectorLength();

            //выводим скалярное произведение
            Console.WriteLine();
            vector1.DisplayScalarMultiplication(vector2);

            //рассчитываем и выводим векторное произведение
            Console.WriteLine();
            Vector vector3 = VectorMultiplication(vector1, vector2);
            Console.WriteLine("vector1 and vector2 vector multiplication is vector3:");
            vector3.DisplayVectorInfo();

            //рассчитываем и выводим угол между векторами
            Console.WriteLine();
            vector1.DisplayVectorAngle(vector2);

            //рассчитываем и выводим сумму векторов
            Console.WriteLine();
            Vector vector4 = VectorMultiplication(vector1, vector2);
            Console.WriteLine("vector1 and vector2 sum is vector4:");
            vector4.DisplayVectorInfo();

            //рассчитываем и выводим разность векторов
            Console.WriteLine();
            Vector vector5 = VectorMultiplication(vector1, vector2);
            Console.WriteLine("vector1 and vector2 subtraction is vector5:");
            vector5.DisplayVectorInfo();

            Console.ReadKey();
        }

        //метод для расчёта вектора - векторного произведения
        public static Vector VectorMultiplication(Vector vector1, Vector vector2)
        {
            double xm = vector1.y * vector2.z - vector1.z * vector2.y;
            double ym = vector1.z * vector2.x - vector1.x * vector2.z;
            double zm = vector1.x * vector2.y - vector1.y * vector2.x;
            return new Vector(xm, ym, zm);
        }

        //метод для расчёта вектора - векторного сложения
        public static Vector VectorSum(Vector vector1, Vector vector2)
        {
            double xs = vector1.x + vector2.x;
            double ys = vector1.y + vector2.y;
            double zs = vector1.z + vector2.z;
            return new Vector(xs, ys, zs);
        }
        //метод для расчёта вектора - векторной разности
        public static Vector VectorSubtraction(Vector vector1, Vector vector2)
        {
            double xsub = vector1.x - vector2.x;
            double ysub = vector1.y - vector2.y;
            double zsub = vector1.z - vector2.z;
            return new Vector(xsub, ysub, zsub);
        }

    }
}
