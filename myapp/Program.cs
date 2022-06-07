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
            Console.WriteLine("Ambos textos concatenados: \t\t" + textoIngresado + " " + textoIngresadoDos);

            Console.WriteLine("Una subcadena de la segunda cadena ingresada es: " + textoIngresadoDos.Substring(3));

            Console.WriteLine("--");

            int operacion = 5;
            do
            {
                int resultado = 0;

                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("--");
                Console.Write("Ingrese la opcion: ");
                operacion = int.Parse(Console.ReadLine());

                if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4)
                {
                    Console.Write("Ingrese el primer numero: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    if (operacion == 1)
                    {
                        resultado = numero1 + numero2;
                        Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + resultado);

                    }
                    if (operacion == 2)
                    {
                        resultado = numero1 - numero2;
                        Console.WriteLine("La resta de " + numero1 + " y " + numero2 + " es: " + resultado);

                    }
                    if (operacion == 3)
                    {
                        resultado = numero1 * numero2;
                        Console.WriteLine("La multiplicacion de " + numero1 + " y " + numero2 + " es: " + resultado);

                    }
                    if (operacion == 4 && numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("La division de " + numero1 + " y " + numero2 + " es: " + resultado);

                    }
                    Console.WriteLine("--");

                }
            } while (operacion != 0) ;

            Console.Write("Presione una tecla");
            Console.Read();
            
        }
    }
}