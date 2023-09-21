using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_04_sesion05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el numero límite: ");
            int numlim = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================");
            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1: Números pares: ");
            Console.WriteLine("2: Número impares: ");
            Console.WriteLine("3: Factorial: ");
            string numlim1texto = Console.ReadLine();
            int numlim1 = int.Parse(numlim1texto);
            int suma = 0;
            int factorial = 1;
            switch (numlim1texto)
            {
                case "1":
                    Console.WriteLine("--> 1  ");
                    for (int i = 1; i <= numlim; i++)
                    {
                        if (i % 2 == 0) //detecta si es par
                        {
                            Console.Write(i + ",");
                            suma = suma + i;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("--> 2 ");
                    for (int i = 1; i < numlim; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + ",");
                            suma = suma + i;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("--> 3");
                    for (int i = 1; i <= numlim; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.Write("El factorial es: " + factorial);
                    break;
            }
            Console.ReadKey();
        }
    }
}