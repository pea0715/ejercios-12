using System;

namespace numero_entero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero : ");
            int numero = int.Parse(Console.ReadLine());
            double operacion = numero / 2;
            if (operacion >= 0)
            {
                Console.WriteLine("numero positivo");
            }
            else
                Console.WriteLine("numero negativo ");
        }
    }
}
