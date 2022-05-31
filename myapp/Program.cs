using System;

namespace ejercicio3
{
    class Program
    {
        static void Main ()
        {
            float numero = 0;
            int numero1 = 0;
            int numero2 = 0;

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

            Console.WriteLine("--");
            Console.Write("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("--");

            if (numero1 > numero2)
            {
                Console.WriteLine($"El mayor es: \t" + numero1);

            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El mayor es: \t" + numero2);
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }

            Console.Write("Presione una tecla...");
            Console.Read();
        }
    }
}
