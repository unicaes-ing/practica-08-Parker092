using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_8
{
    class Ejercicio1
    {
        //Ejercicio 1
        #region
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
            }
            public decimal getCum()
            {
                return cum;
            }
        }
        #endregion
        public void ejer1 ()
        {
            Console.WriteLine("Ejercicio 1");
            Estudiante a = new Estudiante();
             Console.WriteLine("Nombre: ");
             a.nombre = Console.ReadLine();
             Console.WriteLine("Carnet: ");
             a.carnet = Console.ReadLine();
             Console.WriteLine("Carrera: ");
             a.carrera = Console.ReadLine();
             Console.WriteLine("Cum: ");
             a.setCum(Convert.ToDecimal(Console.ReadLine()));
             Console.WriteLine("\nPresione <ENTER> para continuar");
             Console.ReadKey();
             Console.Clear();
             Console.WriteLine("Nombre: \t"+a.nombre);
             Console.WriteLine("Carnet: \t" + a.carnet);
             Console.WriteLine("Carrera: \t"+a.carrera);
             Console.WriteLine("Cum: \t"+a.getCum());
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
