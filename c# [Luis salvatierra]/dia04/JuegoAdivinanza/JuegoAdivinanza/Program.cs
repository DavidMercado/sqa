using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinanza{
    class Program{
        static void Main(string[] args){
            // var con mismo nombre te genera error
            string numero;
            int num, aleatorio, cont;

            Random random = new Random();
            aleatorio = random.Next(1, 50);

            bool acertado = false;
            cont = 1;

            while(cont <6 && !acertado){
                Console.WriteLine("Ingrese un numero entero positivo entre 1 y 50");
                numero = Console.ReadLine();
                num = Int32.Parse(numero);

                if (num == aleatorio){
                    Console.WriteLine("You Win!!!");
                    Console.ReadLine();
                    acertado = true;
                }
                cont++;
            }

            if(!acertado){
                Console.WriteLine("You loose ...");
                Console.WriteLine("El numero era: " + aleatorio);
                Console.ReadLine();
            }

        }
    }
}
