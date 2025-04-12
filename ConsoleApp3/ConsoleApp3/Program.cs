using System.Timers;

//Pedir que se ingrese un nombre e imprimir un saludo hacia ese nombre, ejemplo: “hola Juan"

String nombre;
System.Console.WriteLine("Ingrese su nombre:");
nombre = System.Console.ReadLine();
System.Console.WriteLine("Hola " + nombre);

//Pedir nombre, apellido, nro. de alumno y la comisión a la que desea suscribirse
//Mostrar el siguiente mensaje “La solicitud de inscripción a la comisión <comision>
//solicitada por el alumno <apellido>, <nombre> está siendo procesada”

string apellido;
string comision;
int nroAlumno;
System.Console.WriteLine("Ingrese su nombre:");
nombre = System.Console.ReadLine();
System.Console.WriteLine("Ingrese su apellido:");
apellido = System.Console.ReadLine();
System.Console.WriteLine("Ingrese su nro de alumno:");
nroAlumno = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Ingrese su comision:");
comision = System.Console.ReadLine();
System.Console.WriteLine("La solicitud de inscripción a la comisión " + comision + " solicitada por el alumno " + apellido + ", " + nombre + " está siendo procesada");

/*Escriba un programa que multiplique por 365 el número entero ingresado por
el usuario desde la consola. El resultado debe ser impreso en la consola dígito
por dígito, uno en cada línea, comenzando por el dígito menos significativo al
más significativo.
Ayuda: convertir el número obtenido a string y acceder a los elementos del string
*/

int numero;
System.Console.WriteLine("Ingrese un numero:");
numero = int.Parse(System.Console.ReadLine());
int resultado = numero * 365;
string resultadoString = resultado.ToString();
for (int i = resultadoString.Length - 1; i >= 0; i--)
{
    System.Console.WriteLine(resultadoString[i]);
}
