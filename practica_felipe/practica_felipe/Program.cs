using Microsoft.VisualBasic;
using System;
using System.Diagnostics;

namespace practica_felipe
{
    class Program
    {
        private static int comparacion;

        public static int Mayor(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

  
         static void main()
         {

            Console.WriteLine("ingresa un numero :  ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa un numero :  ");
            int num2 = int.Parse(Console.ReadLine());

            comparacion = Mayor(num1, num2);

            Console.WriteLine("el numero mayor es  :  "+comparacion);
         }

    }
}
