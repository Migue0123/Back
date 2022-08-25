using System;

namespace FirstAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad = 23;

            //console.writeline($"tienes una edad de {edad}");

            //CONVERSION EXPLÍCITA
            //CASTING

            //double temperatura = 34.9;
            //int temperaturaMed;

            //temperaturaMed = (int)temperatura;

            //Console.WriteLine(temperaturaMed);

            //CONVERSIÓN IMPLÍCITA

            //int habitantes = 10000000;

            //long habitantes2018 = habitantes;

            //float peso = 5.7F;

            //double pesoPrec = peso;

            //Console.WriteLine(pesoPrec);

            //INGRESO DE DATOS POR CONSOLA

            //Console.WriteLine("Introduce el primer número:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce el segundo número:");
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;

            //Console.WriteLine($"El resultado es: {sum}");

            //CONSTANTES

            //const double PI = 3.1416;

            //Console.WriteLine("Introduce la medida del radio");

            //double radio = double.Parse(Console.ReadLine());

            //double area = Math.Pow(radio, 2) * PI;

            //Console.WriteLine($"El área del círculo es: {area}");

            //MÉTODOS

            //int num1 = 5, num2 = 5;
            sumaNumeros(5, 6);
        }

        static void sumaNumeros(int num1, int num2)
        {
             Console.WriteLine($"La suma de los números es: {num1 + num2}");
        }
    }
}
