using System;

namespace ConsoleApp1
{
    class Program
    {
          static void Main(string[] args)
        {
             if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            
            }

            Console.WriteLine("Ingresa tu nombre por favor :");
            string nombre = Console.ReadLine();
           
            Console.WriteLine("Realiza tu suma");
            int primerNumero, segundoNumero, suma;

            Console.Write("Introduce el primer número: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            suma = primerNumero + segundoNumero;

            Console.WriteLine(" Hola {0} La suma de {1} y {2} es {3}",
                nombre ,primerNumero, segundoNumero, suma);
        }
    }
}
