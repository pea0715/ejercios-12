using System;
using System.Runtime.InteropServices;

namespace menor_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba un numero :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba un numero :");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("este es el numero mayor "+num2);

            }
            else
            {
                Console.WriteLine("este es el numero mayor "+num1);
            }
        }
    }
}
