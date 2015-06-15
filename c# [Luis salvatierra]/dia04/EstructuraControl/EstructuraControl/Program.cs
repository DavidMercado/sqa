using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraControl
{
    class Program{
        static void Main(string[] args){

            //Estructura de Control
            bool isValid = true;
            string text = isValid ? "Its true" : "Its false";
            Console.WriteLine(text);
            Console.ReadLine();

            // Etructura de control
            string[] array = null;
            if(array!=null && array.Length>0){
                //evalua la primera condicion pero no el ultimo
                //en || evualua ambas, siempre preguntar si es null
                // antes de acceder al tamanio
            }

            //Estructura de repeticion
            for (int cont = 3; cont < 11; cont ++ ){
                Console.WriteLine(cont);
                Console.ReadLine();
            }
        }
    }
}
