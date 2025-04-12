//Solicite que se ingrese un número e imprima el triple
using System.Timers;

System.Console.WriteLine("Ingrese un numero: ");
int numero;
numero = Convert.ToInt32(System.Console.ReadLine());
int triple;
triple = numero * 3;
System.Console.WriteLine("El triple de:" + " " + numero +  " " + "es" + " " + triple);

//Solicite que se ingrese un número e imprima la mitad

System.Console.WriteLine("Ingrese un numero: ");
int numero1;
numero1 = Convert.ToInt32(System.Console.ReadLine());
int mitad;
mitad = numero1 / 2 ;
System.Console.WriteLine("La mitad de:" + " " + numero1 + " " + "es" + " " + mitad);

//Solicite que se ingresen 3 notas e imprima el promedio. Recuerde que el promedio es la
//suma de los números dividido la cantidad.
decimal numero2, numero3, numero4, promedio;
System.Console.WriteLine("Ingrese 3 notas: ");
System.Console.WriteLine("Nota 1");
numero2 = Convert.ToDecimal(System.Console.ReadLine());

System.Console.WriteLine("Nota 2");
numero3 = Convert.ToDecimal(System.Console.ReadLine());

System.Console.WriteLine("Nota 3");
numero4 = Convert.ToDecimal(System.Console.ReadLine());

System.Console.WriteLine("El Promedio de esas notas es: ");
promedio = (numero2+numero3+ numero4) / 3;
System.Console.WriteLine(promedio);

/*Solicite que se ingrese el diámetro de un círculo y calcule su área y perímetro.
Recuerde que Perímetro = π * Diámetro , Área = π * radio2
. Por último, el diámetro = 2
* radio
*/

double area, perimetro, radio, diametro;
System.Console.WriteLine("Calculemos el area y el perimetro de un circulo: ");
System.Console.WriteLine("Empezemos por el area: ");

System.Console.WriteLine("Ingrese un valor para el radio");
radio = Convert.ToDouble(System.Console.ReadLine());

area = Math.PI * (Math.Pow(radio, 2));
System.Console.WriteLine("El Area es: " + "" + area);

System.Console.WriteLine("Ahora calcularesmo el perimetro");
diametro = radio * 2;
perimetro = Math.PI * radio;
System.Console.WriteLine("El Perimetro es: " + "" + perimetro);

//Solicite que se ingresen 2 números y mostrar la división entre ellos y el resto.

System.Console.WriteLine("Vamos a calular la division entre 2 numeros y su resto");
double num1, num2, div, resto;
System.Console.WriteLine("Ingrese el primer numero: ");
num1 =  Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese el segundo numero: ");
num2 =  Convert.ToDouble(System.Console.ReadLine());

div = num1 / num2;
resto = num1 % num2;
System.Console.WriteLine("La division es: " + "" +  div);
System.Console.WriteLine("El resto es: " + "" + resto);

/*Solicite que se ingrese el ancho y largo de un terreno y mostrar cuántos paneles de
pasto hay que comprar (son de 60x60 cm)*/

System.Console.WriteLine("Vamos a calcular cuantos paneles de pasto hay que comprar");
double ancho, largo, areaTerreno, areaPanel, cantidadPaneles;
    System.Console.WriteLine("Ingrese el ancho del terreno: ");
ancho = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese el largo del terreno: ");
largo = Convert.ToDouble(System.Console.ReadLine());
areaTerreno = ancho * largo;
System.Console.WriteLine("El area del terreno es: " + "" + areaTerreno);
areaPanel = 0.6 * 0.6;
System.Console.WriteLine("El area de cada panel es: " + "" + areaPanel);
cantidadPaneles = areaTerreno / areaPanel;
System.Console.WriteLine("La cantidad de paneles que se necesitan son: " + "" + cantidadPaneles);


/*Solicite que se ingresen datos de 4 productos con su cantidad y precio unitario y
mostrar cuánto se gasta por cada producto y el total*/

System.Console.WriteLine("Vamos a calcular el gasto de 4 productos");
double precio1, precio2, precio3, precio4, cantidad1, cantidad2, cantidad3, cantidad4, gasto1, gasto2, gasto3, gasto4, total;
System.Console.WriteLine("Ingrese el precio del producto 1: ");
precio1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese la cantidad del producto 1: ");
cantidad1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese el precio del producto 2: ");
precio2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese la cantidad del producto 2: ");
cantidad2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese el precio del producto 3: ");
precio3 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese la cantidad del producto 3: ");
cantidad3 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese el precio del producto 4: ");
precio4 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Ingrese la cantidad del producto 4: ");
cantidad4 = Convert.ToDouble(System.Console.ReadLine());
gasto1 = precio1 * cantidad1;
gasto2 = precio2 * cantidad2;
gasto3 = precio3 * cantidad3;
gasto4 = precio4 * cantidad4;
System.Console.WriteLine("El gasto del producto 1 es: " + "" + gasto1);
System.Console.WriteLine("El gasto del producto 2 es: " + "" + gasto2);
System.Console.WriteLine("El gasto del producto 3 es: " + "" + gasto3);
System.Console.WriteLine("El gasto del producto 4 es: " + "" + gasto4);
total = gasto1 + gasto2 + gasto3 + gasto4;
System.Console.WriteLine("El gasto total es: " + "" + total);

/*Diseñe un programa que, a partir del valor del lado de un cuadrado (3 metros), muestre
el valor de su perímetro (en metros) y el de su área (en metros cuadrados). (El perímetro
debe dar 12 metros y el área 9 metros cuadrados.)*/

System.Console.WriteLine("Vamos a calcular el perimetro y el area de un cuadrado");
double lado, perimetroCuadrado, areaCuadrado;
System.Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
lado = 3;
perimetroCuadrado = lado * 4;
System.Console.WriteLine("El perimetro del cuadrado es: " + "" + perimetroCuadrado);
areaCuadrado = lado * lado;
System.Console.WriteLine("El area del cuadrado es: " + "" + areaCuadrado);

