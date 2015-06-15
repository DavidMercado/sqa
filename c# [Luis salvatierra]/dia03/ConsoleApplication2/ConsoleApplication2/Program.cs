using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data types
            int x = 3;
            bool ban = true;
            Console.WriteLine("{0},{1},{2}", x, 10, 20);
            Console.ReadLine();

            //var types
            var a = "Hola ...";
            Console.WriteLine("{0}", a);
            Console.ReadLine();

            //anomyn types
            var persona = new {Nombre="Jhas", Universidad="umss"};
            Console.WriteLine("{0}", persona);
            Console.ReadLine();

            //debugging f5, f10---> saltar siguiente linea
            //f11--->Ingresar dentro de ese metodo[print]
            //No es necesario varios breakpoints
        }
    }
}
