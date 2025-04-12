using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese Nombre, Apellido y Nota");
            String nombre, apellido;
            int nota;
            nombre = Console.ReadLine();
            apellido = Console.ReadLine();
            nota = Convert.ToInt32(Console.ReadLine());

            
            if (nota >= 0)
            {
                System.Console.WriteLine(nombre + " " + apellido + " " + "Esta aprobado");
            }
            else
            {
                System.Console.WriteLine(nombre + "" + apellido + "" + "No esta Aprobado");
            }
        }
    }
}
