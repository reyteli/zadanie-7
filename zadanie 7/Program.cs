using System;

namespace zadanie_7
{
    class Program
    {
        public struct Triangle
        {
            public double x, y, z;
            public double Square()
            {
                double p = (x + y + z) / 2;
                double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
                return s;
            }
        }
        static void Main()
        {
            Triangle[] triagles = new Triangle[2];
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Введите длины (x,y,z) сторон треугольника {0}", i + 1);
                triagles[i].x = double.Parse(Console.ReadLine());
                triagles[i].y = double.Parse(Console.ReadLine());
                triagles[i].z = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < triagles.Length; i++)
            {
                Console.WriteLine("Площадь {0}-го треугольника = {1}", i + 1, triagles[i].Square());
            }
            int maxSquaredTriIdx = 0;
            for (int i = 1; i < triagles.Length; i++)
            {
                if (triagles[i].Square() > triagles[maxSquaredTriIdx].Square())
                    maxSquaredTriIdx = i;
            }
            Console.WriteLine("Макс площадь у {0}-го треугольника", maxSquaredTriIdx + 1);

            Console.ReadKey();
        }
        }
}
