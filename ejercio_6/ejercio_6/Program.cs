using System;

namespace ejercio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            Console.WriteLine("ingrese a la clase que pertene escriba 1 si es a , 2 si es b , 3 si es c : ");
            int tiempo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero de horas trabajadas : ");
            double num1 = double.Parse(Console.ReadLine());


            switch (tiempo)
            {
                case 1:
                    suma = num1 * 7;
                    Console.WriteLine(suma);
                    break;

                case 2:
                    suma = num1 * 5;
                    Console.WriteLine(suma);
                    break;

                case 3:
                    suma = num1 * 4;
                    Console.WriteLine(suma);

                    break;

                case 4:
                    suma = num1 * 3.5;
                    Console.WriteLine(suma);

                    break;


                default:

                    Console.WriteLine("INGRES UN NUMERO QUE SE LE ESTA DICIENDO ");
                    break;
            }
        }
    }

}