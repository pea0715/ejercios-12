using System;

namespace ejercio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese valor a pagar   : ");
            double story = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese 1 si saco azul , 2 si saco rojo , 3 si saco blanco : ");
            int  bolita = int.Parse( Console.ReadLine());

            

            if (bolita == 1)
            {
                double cuenta = story * 0.20;
                double cuenta2 = story - cuenta;
                Console.WriteLine("valor que debe  pagar :" + cuenta2);

            }
            if (bolita == 2 )
            {
                double cuenta = story * 0.30;
                double cuenta2 = story - cuenta;
                Console.WriteLine("valor que debe  pagar :" + cuenta2);

            }
            if (bolita == 3)
            {
     
                Console.WriteLine("valor que debe pagar sin descuento  :" + story);

            }

        }
    }
}
