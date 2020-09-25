using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Space_speed_1 
    

{
    class Program
    {
        
         

        static void Main(string[] args)

        { double H, V;
          const double M = 5.976E24;
          const double G = 6.672E-11;
          const double R = 6371000;
            Console.WriteLine("Введите высоту: ");
             H = Convert.ToDouble(Console.ReadLine());
             V = Math.Round(Math.Sqrt(G * M / R + H),0);
            
            Console.WriteLine($"Скорость спутника: {V} ");
            
        }
    }
}
