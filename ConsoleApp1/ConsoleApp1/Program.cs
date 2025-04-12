/*Desarrollar un programa donde  se le solicite al usuario ingresar apellido y calificacion dado esos parametros validar si el alumno esta aprobado o no y le indique con un mensaje el resultado.*/

String nombre, apellido;
int nota;

System.Console.WriteLine("Ingrese su nombre apellido y nota");
nombre = Console.ReadLine();
apellido = Console.ReadLine(); 
nota = Convert.ToInt32(Console.ReadLine());

if (nota >= 7)
{
    System.Console.WriteLine(nombre + " " + apellido + " " + "Esta Aprobado");

}
else
{
    System.Console.WriteLine(nombre + " " + apellido + " " + "No esta Aprobado");
}