using System;

namespace Ejercicio_3_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal consumo;

            Console.Write("Introduzca el número de kilómetros recorridos: ");
            decimal kilometros = Convert.ToDecimal(Console.ReadLine());

            consumo = kilometros / 30;
            Console.WriteLine("\nEl rendimiento por litro de gasolina ronda los 30km/l");
            Console.WriteLine(kilometros + " kilómetros suponen un consumo de: " + Math.Round(consumo, 2) + " litros de gasolina.");
        }
    }
}
