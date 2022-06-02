using System;

namespace ejercicio4
{
    class Program
    {
        static void Main ()
        {
            string textoIngresado;
            string textoIngresadoDos;
            Console.Clear();
            Console.WriteLine("--");
            Console.Write("Ingrese un texto: ");
            textoIngresado = Console.ReadLine();
            Console.WriteLine("--");
            Console.WriteLine("El texto ingresado es: \t\t\t" + textoIngresado);
            Console.WriteLine("El primer caracter: \t\t\t" + textoIngresado[0]);
            Console.WriteLine("El largo de la cadena ingresada es: \t" + textoIngresado.Length);
            Console.WriteLine("--");
            Console.Write("Ingrese un segundo texto: ");
            textoIngresadoDos = Console.ReadLine();
            Console.WriteLine("--");
            Console.WriteLine("El texto ingresado es: \t\t\t" + textoIngresadoDos);
            Console.WriteLine("Ambos textos concatenados: \t\t" + textoIngresado + textoIngresadoDos);

            Console.Write("Presione una tecla");
            Console.Read();
        }
    }
}