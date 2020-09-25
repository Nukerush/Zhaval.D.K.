using System;

namespace Uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите два числа (x,y): ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            bool x1 = (x < 0) & (y > 0);//true если оба оператора true.
            if (x1) 
            { 
                Console.WriteLine($"x < 0,y > 0 {true}");
            }
            else 
            {
                Console.WriteLine($"x < 0,y > 0 {false}");
            }
            if (x > y)
            {
                Console.WriteLine($"x > y {true}");
            }
            else
            {
                Console.WriteLine($"x > y {false}");
            }
            Console.WriteLine("Введите два числа: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            bool x2 = (x - 5 < 0) | (y*(-1) > 0);//true если хоть 1 оператор true;не работает с переменными строкового типа.
            if (x2)
            {
                Console.WriteLine($"(x - 5) < 0,(y * (-1)) > 0 {true}");
            }
            else
            {
                Console.WriteLine($"(x - 5) < 0,(y * (-1)) > 0 {false}");
            }
            
           
        }

    }
}