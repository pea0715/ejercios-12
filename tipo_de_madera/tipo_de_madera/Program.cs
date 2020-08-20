using System;

namespace tipo_de_madera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tipos de mandera que desea comprar : ");
            int tipo_madera = int.Parse(Console.ReadLine());
            Console.WriteLine("cuantos metros de madera va a comprar ");
            int metros_madera = int.Parse(Console.ReadLine());
            if(tipo_madera == 1)
            {
                if (metros_madera >= 30)
                {
                    double er = metros_madera * 20000;
                    double qw = er * 0.04;
                    double final = er - qw;
                    Console.WriteLine("usted debe pagar esto" + final);
                }
                else
                {
                    double er = metros_madera * 20000;
                    Console.WriteLine("usted debe pagar esto" + er);

                }

            }
            if (tipo_madera == 2)
            {
                if (metros_madera >= 30)
                {
                    double er = metros_madera * 20000;
                    double qw = er * 0.08;
                    double final = er - qw;
                    Console.WriteLine("usted debe pagar esto" + final);
                }
                else
                {
                    double er = metros_madera * 20000;
                    Console.WriteLine("usted debe pagar esto" + er);

                }

            }
            if (tipo_madera == 3)
            {
                if (metros_madera >= 30)
                {
                    double er = metros_madera * 20000;
                    double qw = er * 0.10;
                    double final = er - qw;
                    Console.WriteLine("usted debe pagar esto" + final);
                }
                else
                {
                    double er = metros_madera * 20000;
                    Console.WriteLine("usted debe pagar esto" + er);

                }

            }
        }
    }
}
