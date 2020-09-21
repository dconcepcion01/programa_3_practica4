using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_3_practica4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ESTE PROGRAMA TE CALCULA TE REALIZA LAS OPERACIONES DE CALCULOS");
            Aritmetica.sumar(3, 4);

            Console.SetCursorPosition(5, 7);
            Console.WriteLine("El resultado de la suma es: " + Aritmetica.sumar(4, 5));


            Console.ReadKey();

            Aritmetica.Multi(3, 4);

            Console.SetCursorPosition(5, 8);
            Console.WriteLine("El resultado de la Multiplicacion es: " + Aritmetica.Multi(4, 5));


            Console.ReadKey();

            Aritmetica.resta(3, 4);

            Console.SetCursorPosition(5, 9);
            Console.WriteLine("El resultado de la Resta es: " + Aritmetica.resta(4, 5));


            Console.ReadKey();

            Aritmetica.division(3, 4);

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("El resultado de la Division es: " + Aritmetica.division(4, 5));


            Console.ReadKey();


        }
    }
}
