using System;

Console.Write("Ingrese un numero: ");
string numeroIngresado = Console.ReadLine();

Console.WriteLine("El numero ingresado es: " + numeroIngresado);
Console.Write("El numero invertido es: ");

char[] numeroArray = numeroIngresado.ToCharArray();

for (int i = numeroArray.Length; i > 0 ; i--)
{
    Console.Write(numeroArray[i - 1]);
}





