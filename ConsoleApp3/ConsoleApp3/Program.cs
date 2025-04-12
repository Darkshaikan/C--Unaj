/*Desarrollar una calculadora donde el usuario ingrese un 1 para hacer sumas 2 para resta, 
 * 3 para multiplicacion y 4 para division lueo ingrerse 2 numeros y se realice la operacion mostrando el resultado.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Calculadora");
            System.Console.WriteLine("Ingrese 1 para suma");
            System.Console.WriteLine("Ingrese 2 para resta");
            System.Console.WriteLine("Ingrese 3 para multiplicacion");
            System.Console.WriteLine("Ingrese 4 para division");
            int num1, num2, num3, num4;
            num1 = Convert.ToInt32(System.Console.ReadLine());

            if (num1 == 1)
            {
                System.Console.WriteLine("Eligio suma, Ingrese 2 valores");
                System.Console.WriteLine("Ingrese primer valor");
                num2 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Ingrese segundo valor");
                num3 = System.Convert.ToInt32(System.Console.ReadLine());
                num4 = num2 + num3;
                System.Console.WriteLine("El Resutado es: ");
                System.Console.WriteLine(num4);
            }
            else if (num1 == 2)
            {
                System.Console.WriteLine("Eligio resta, Ingrese 2 valores");
                System.Console.WriteLine("Ingrese primer valor");
                num2 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Ingrese segundo valor");
                num3 = System.Convert.ToInt32(System.Console.ReadLine());
                num4 = num2 - num3;
                System.Console.WriteLine("El Resutado es: ");
                System.Console.WriteLine(num4);
            }else if (num1 == 3)
            {
                System.Console.WriteLine("Eligio multiplicacion, Ingrese 2 valores");
                System.Console.WriteLine("Ingrese primer valor");
                num2 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Ingrese segundo valor");
                num3 = System.Convert.ToInt32(System.Console.ReadLine());
                num4 = num2 * num3;
                System.Console.WriteLine("El Resutado es: ");
                System.Console.WriteLine(num4);
            }else if(num1 == 4)
            {
                System.Console.WriteLine("Eligio division, Ingrese 2 valores");
                System.Console.WriteLine("Ingrese primer valor");
                num2 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Ingrese segundo valor");
                num3 = System.Convert.ToInt32(System.Console.ReadLine());
                num4 = num2 / num3;
                System.Console.WriteLine("El Resutado es: ");
                System.Console.WriteLine(num4);
            }else
            {
                System.Console.WriteLine("Error");

            }
        }
    }
}
