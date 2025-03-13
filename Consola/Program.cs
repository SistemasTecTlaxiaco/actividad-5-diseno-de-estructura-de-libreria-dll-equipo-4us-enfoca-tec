using System;
using System.Collections.Generic;
using System.Linq;
using calculadora_biblioteca;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        private static double num1 = 0, num2 = 0, num0 = 0;
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.WriteLine(" Menu Principal de Calculadora del Tecnologico de Tlaxiaco");
                    Console.WriteLine("1. Sumar dos numeros");
                    Console.WriteLine("2. Restar dos numeros");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Raiz Cuadrada");
                    Console.WriteLine("6. Potencia");
                    Console.WriteLine("7. Porcentaje");
                    Console.WriteLine("8. Fraccion");
                    Console.WriteLine("9. Logaritmo natural");
                    Console.WriteLine("10. Salir");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            teclado1();
                            Console.WriteLine("El resultado de la suma es: " + Calculadoratec.sumar(num1, num2));
                            break;
                        case 2:
                            teclado1();
                            Console.WriteLine("El resultado de la Resta es: " + Calculadoratec.restar(num1, num2));
                            break;
                        case 3:
                            teclado1();
                            Console.WriteLine("El resultado de la Multiplicacion es: " + Calculadoratec.multiplicar(num1, num2));
                            break;
                        case 4:
                            teclado1();
                            Console.WriteLine("El resultado de la Division es: " + Calculadoratec.dividir(num1, num2));
                            break;
                        case 5:
                            teclado0();
                            Console.WriteLine("El resultado de la Raiz cuadrada es: " + Calculadoratec.raizCuadrada(num0));
                            break;
                        case 6:
                            teclado1();
                            Console.WriteLine("El resultado de la Potencia es: " + Calculadoratec.potencia(num1, num2));
                            break;
                        case 7:
                            teclado1();
                            Console.WriteLine("El resultado del porcentaje es: " + Calculadoratec.porcentaje(num1, num2));
                            break;
                        case 8:
                            teclado1();
                            Console.WriteLine("El resultado de la fraccion es: " + Calculadoratec.fraccion(num1, num2));
                            break;
                        case 9:
                            teclado0();
                            Console.WriteLine("El resultado del logaritmo natural es: " + Calculadoratec.LogaritmoNatural(num0));
                            break;
                        case 10:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            Environment.Exit(1);
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 10");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error al ingresar!!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private static void teclado0()
        {
            Console.WriteLine("Introduzca un numero");
            num0 = double.Parse(Console.ReadLine());
        }
        private static void teclado1()
        {
            Console.WriteLine("Introduzca el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = double.Parse(Console.ReadLine());
        }
    }
}