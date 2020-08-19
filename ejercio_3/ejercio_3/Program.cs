using System;

namespace ejercio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double wer = 0;
            double er = 0; 
            Console.WriteLine(" que tela dese compra uno o dos ;");
            int tela = int.Parse(Console.ReadLine());
            Console.WriteLine("años que lleva comprando en la compañia ");
            int exp = int.Parse(Console.ReadLine());

            switch (tela)
            {
                case 1:
                    if (exp == 5)
                    {
                        Console.WriteLine("metros de tela que desea comprar :  ");
                        double metros = double.Parse(Console.ReadLine());
                        er = metros * 400;
                        wer = (er * 0.8) - metros;
                        Console.WriteLine(+wer);


                    }
                    if (exp == 6)
                    {
                        Console.WriteLine("metros de tela que desea comprar :  ");
                        double metros = double.Parse(Console.ReadLine());
                        er = metros * 400;
                        wer = (er * 0.6) - metros;
                        Console.WriteLine(+wer);


                    }
                    break;

                case 2:
                    if (exp == 5)
                    {
                        Console.WriteLine("metros de tela que desea comprar :  ");
                        double metros = double.Parse(Console.ReadLine());
                        er = metros * 250;
                        wer = (er * 0.8) - metros;
                        Console.WriteLine("cosas "+wer);


                    }
                    if (exp == 6)
                    {
                        Console.WriteLine("metros de tela que desea comprar :  ");
                        double metros = double.Parse(Console.ReadLine());
                        er = metros * 250;
                        wer = (er * 0.6) - metros;
                        Console.WriteLine(+wer);


                    }
                    break;



            }

          
        }
    }
}
