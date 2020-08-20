using System;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero que dese :");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero que dese :");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero que dese :");
            int numero2 = int.Parse(Console.ReadLine());

            int multiplicacion = (int)Math.Pow(numero, 4)- (int)Math.Pow(numero1, 3) + (int)Math.Pow(numero2, 2);

            if (multiplicacion < 820)
            {
                Console.WriteLine("si es mayor ");
            }
            else
            {
                Console.WriteLine("no es mayor  ");
            }
        }
    }
}
