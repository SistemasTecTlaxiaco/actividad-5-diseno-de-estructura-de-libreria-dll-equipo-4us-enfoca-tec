using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_biblioteca
{
    public class Calculadoratec
    {
        public static double sumar(double uno, double dos)
        {
            return uno + dos;
        }

        public static double multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double restar(double uno, double dos)
        {
            return uno - dos;
        }
        public static double dividir(double uno, double dos)
        {
            return uno / dos;
        }
        public static double raizCuadrada(double numero)
        {
            if (numero < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");//Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.
            return Math.Sqrt(numero);// Devuelve la raíz cuadrada de un número especificado./
        }

        public static double potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente); //Devuelve un número especificado elevado a la potencia especificada.
        }

        public static double porcentaje(double total, double porcentaje)
        {
            return (total * porcentaje) / 100;
        }

        public static double fraccion(double numerador, double denominador)
        {
            if (denominador == 0)
                throw new DivideByZeroException("El denominador no puede ser cero.");
            return numerador / denominador;
        }
        public static double LogaritmoNatural(double numero)
        {
            if (numero <= 0)
                throw new ArgumentException("No se puede calcular el logaritmo natural de un número menor o igual a cero.");
            return Math.Log(numero);
        }
    }
}