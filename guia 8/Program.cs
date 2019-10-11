using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palacios A. Diego E. Octubre 2019
            int op;
            do
            {
                Console.WriteLine("\t*** GUIA 8 ***");
                Console.WriteLine("* 1 * Ejercicio 1.");
                Console.WriteLine("* 2 * Ejercicio 2.");
                Console.WriteLine("* 3 * Ejercicio 3.");
                //Console.WriteLine("* 4 * Ejercicio 4.");
                Console.WriteLine("* 5 * Salir.");
                Console.WriteLine("Seleccione una opccion: ");
               op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1 a = new Ejercicio1();
                        a.ejer1();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio2 b = new Ejercicio2();
                        b.ejer2();
                        Console.Clear();
                        break;
                    case 3:
                        Ejercicio3 c = new Ejercicio3();
                        c.ejer3();
                        Console.Clear();
                        break;
                }
            } while (op!=5);
            

        }
    }
}
