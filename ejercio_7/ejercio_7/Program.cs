using System;

namespace ejercio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("para cada timpo de silla oprima 1 y 2 para la otra y 3 para la otra");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("escriba numero que desea comprar de sillas");
                    int sillas = int.Parse(Console.ReadLine());
                    if (sillas >= 5 )
                    {
                        double re = sillas * 5000;
                        double we = (re * 0.05) - sillas ;
                        Console.WriteLine("er" + we);
                    }
                    else
                    {
                        double re = sillas * 5000;
                        Console.WriteLine("er" + re);

                    }
                    break;
                case 2:
                    Console.WriteLine("escriba numero que desea comprar de sillas");
                    int sillas1 = int.Parse(Console.ReadLine());
                    if (sillas1 >= 5)
                    {
                        double re = sillas1 * 7000;
                        double we = (re * 0.05) - sillas1;
                        Console.WriteLine("er" + we);
                    }
                    else
                    {
                        double re = sillas1 * 5000;
                        Console.WriteLine("er" + re);

                    }
                    break;


                case 3:
                    Console.WriteLine("escriba numero que desea comprar de sillas");
                    int sillas2 = int.Parse(Console.ReadLine());
                    if (sillas2 >= 5)
                    {
                        double re = sillas2 * 100000;
                        double we = (re * 0.05) - sillas2;
                        Console.WriteLine("er" + we);
                    }
                    else
                    {
                        double re = sillas2 * 5000;
                        Console.WriteLine("er" + re);

                    }
                    break;


            }

        }
    }
}
