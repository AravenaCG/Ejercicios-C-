using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 1";
            int[] auxNum = new int [5];
            int aux;
            String palabra;
            int min=0;
            int max=0;
      //      float prom;
            for (int i = 0; i < 5; i++)
            {
            
                Console.WriteLine("ingrese un nro");
                palabra = Console.ReadLine();
                if ( int.TryParse(palabra, out aux))
                {
                    auxNum[i]=aux;
                }


            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(auxNum[j]);
                if (auxNum[j] <= min)
                {
                    min = auxNum[j];
                }
                max= auxNum[j];
                if (auxNum[j] > max)
                {
                    max = auxNum[j];
                }
            }


            Console.WriteLine("el numero minimo es:");
            Console.WriteLine(min);
            Console.WriteLine("el Numero maximo es");
            Console.WriteLine(max);

            Console.ReadKey();

        }
    }
}
