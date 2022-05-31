using System;

namespace ejercicio3
{
    class Program
    {
        static void Main ()
        {
            float numero = 0;

            Console.Clear();
            Console.WriteLine("--");
            Console.Write("Ingrese un numero: ");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("--");
            Console.WriteLine($"El numero ingresado es \t{numero}");
            Console.WriteLine($"El valor Absoluto es: \t" + Math.Abs(numero));
            Console.WriteLine($"El cuadrado es: \t" + Math.Pow(numero, 2));
            Console.WriteLine($"La raiz cuadrada es: \t" + Math.Sqrt(numero));
            Console.WriteLine($"El seno es: \t\t" + Math.Sin(numero));
            Console.WriteLine($"El coseno es: \t\t" + Math.Cos(numero));
            Console.WriteLine($"La parte entera es: \t" + Math.Truncate(numero));
            Console.Write("Presione una tecla...");
            Console.Read();
        }
    }
}
