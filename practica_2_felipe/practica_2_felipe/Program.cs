using System;
using System.Diagnostics.CodeAnalysis;

namespace practica_2_felipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de su sueldo ");
            int plan = int.Parse(Console.ReadLine());

            if(plan < 1000000)
            {
                double aumento = plan * 0.15;
                Console.WriteLine("su sueldo nuevo es este : " + aumento);
               

                
            }
        }
    }
}
