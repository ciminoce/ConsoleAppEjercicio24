using System;

namespace ConsoleAppEjercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Conversion de Temperaturas");
                Console.WriteLine("(C)elsius");
                Console.WriteLine("(F)ahrenheit");
                Console.Write("Ingrese C o F para indicar la temperatura que ingresa:");

                string opcion = Console.ReadLine();
                if (opcion.ToUpper() == "C" || opcion.ToUpper() == "F")
                {
                    if (opcion.ToUpper() == "C")
                    {
                        Console.Write("Ingrese la temperatura en grados celsius:");
                        var celsius = float.Parse(Console.ReadLine());
                        var fahrenheit = 1.8f * celsius + 32;
                        Console.WriteLine($"{celsius} grados C equivalen a {fahrenheit} grados F");
                    }
                    else
                    {
                        Console.Write("Ingrese la temperatura en grados Fahrenheit:");
                        var fahrenheit = float.Parse(Console.ReadLine());
                        var celsius = (fahrenheit - 32) / 1.8f;
                        Console.WriteLine($"{fahrenheit} grados F equivalen a {celsius} grados C");
                    }

                }
                else
                {
                    Console.WriteLine("Opción no contemplada o errónea");
                }

            }
            catch (Exception )
            {

                Console.WriteLine("Algo no se ingresó como corresponde");
            }
            Console.ReadLine();

        }
    }
}
