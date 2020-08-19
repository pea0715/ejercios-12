using System;

namespace wey
{
    class Program
    {
        
        
            public static double factorial(int num)
            {
                if (num == 0 || num == 1)
                    return 1;
                return num * factorial(num - 1);
            }
            static void Main(string[] args)
            {
                int n;
                Console.Write("Digite el valor del numero que desea factorial : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("El factorial de {0} es: {1}", n, factorial(n));
                Console.ReadKey();
            }

        
    }
}
