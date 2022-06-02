using System;

namespace ejercicio4
{
    class Program
    {
        static void Main ()
        {
            string textoIngresado;
            Console.Clear();
            Console.WriteLine("--");
            Console.Write("Ingrese un texto: ");
            textoIngresado = Console.ReadLine();
            Console.WriteLine("El texto ingresado es: " + textoIngresado);
            Console.WriteLine("Primer caracter: " + textoIngresado[0]);
            Console.Write("Presione una tecla");
            Console.Read();
        }
    }
}