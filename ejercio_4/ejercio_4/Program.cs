using System;
using System.Diagnostics;

namespace ejercio_4
{
    class Program
    {
       

        static void Main(string[] args)
        {
            double suma = 0;
            Console.WriteLine("ingrese uno si es suma , dos si es resta , 3 si es multiplicaicpon , 4 si es division : ");
            int tiempo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero numeros : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero numeros : ");
            double num2 = double.Parse(Console.ReadLine());


            switch (tiempo)
            {
                case 1:
                    suma = num1 + num2;
                    Console.WriteLine(suma);
                    break;

                case 2:
                    suma = num1 - num2;
                    Console.WriteLine(suma);
                    break;

                case 3:
                    suma = num1 * num2;
                    Console.WriteLine(suma);

                    break;

                case 4:
                    suma = num1 / num2;
                    Console.WriteLine(suma);
                    break;

                default:
                    
                    Console.WriteLine("INGRES UN NUMERO QUE SE LE ESTA DICIENDO ");
                    break;


            }
            
        }

    }
}
