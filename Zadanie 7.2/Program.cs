using System;

namespace Zadanie_7._2
{
    class Program
    {   
            static void Main(string[] args)
            { 
                Console.WriteLine("Введите длинну ребра куба:");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Обьем куба:" + Math.Pow(a, 3) + " куб.см");
                Console.WriteLine("Площадь поверхности:" + Math.Pow(a, 2) * 6 + " кв.см");
                Console.ReadLine();
            }
        
    }
}
