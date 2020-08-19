using System;

namespace ejercio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese altura del estudiante :");
            double tall = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el peso del estudiante :");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine("oprima 1 si es hombre y 2 si es mujer : ");
            int sexo = int.Parse(Console.ReadLine());

            if (sexo == 1)
            {
                if (tall >= 1.60  && kg >= 150)
                {
                    double dosis = tall * 0.20;
                    double qw = kg * 0.80;
                    double final = dosis + qw;
                    Console.WriteLine("estos son los litros que le debe poner : " + final);
                }
                else
                {
                    double dosis = tall * 0.30;
                    double qw = kg * 0.70;
                    double final = dosis + qw;
                    Console.WriteLine("estos son los litros que le debe poner : " + final);
                }

            }
            else
            {
                if (tall >= 1.50 && kg >= 130)
                {
                    double dosis = tall * 0.25;
                    double qw = kg * 0.75;
                    double final = dosis + qw;
                    Console.WriteLine("estos son los litros que le debe poner : " + final);
                }
                else
                {
                    double dosis = tall * 0.35;
                    double qw = kg * 0.65;
                    double final = dosis + qw;
                    Console.WriteLine("estos son los litros que le debe poner : " + final);
                }


            }
        }
    }
}
