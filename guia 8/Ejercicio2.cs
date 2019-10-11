using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_8
{
    class Ejercicio2
    {
        //Ejercicio 2
        #region
        public struct Producto
        {
            public string nombre;
            private int cant;
            private decimal precio;

            public void setCant(int cant)
            {
                if (cant > 0)
                {
                    this.cant = cant;
                }
            }
            public decimal getCant()
            {
                return cant;
            }
            public void setPrecio(decimal precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
            }
            public decimal getPrecio()
            {
                return precio + (precio * 0.13M);
            }
        }
        #endregion
        public void ejer2()
        {
            Console.WriteLine("Ejercicio 2");
            int max;
            Console.WriteLine("Cuantos productos: ");
            int.TryParse(Console.ReadLine(), out max);
            Producto[] b = new Producto[max];
            for (int i = 0; i < b.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Producto Nª " + (i + 1));
                Console.WriteLine("Nombre: ");
                b[i].nombre = Console.ReadLine();
                Console.WriteLine("Cantidad: ");
                b[i].setCant(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Precio: ");
                b[i].setPrecio(Convert.ToDecimal(Console.ReadLine()));
            }
            Console.WriteLine("Presione <ENTER> para continuar");
            Console.ReadKey();
            Console.Clear();
            int n = 0;
            decimal total = 0M;
            foreach (Producto product in b)
            {
                n++;
                total = total + (product.getCant() * product.getPrecio());
                Console.WriteLine("\nProducto Nª " + n);
                Console.WriteLine("Nombre: " + product.nombre);
                Console.WriteLine("Cantidad: " + product.getCant());
                Console.WriteLine("Precio(+IVA): " + product.getPrecio().ToString("C2"));
                // Console.WriteLine("Total: "+(product.getCant() * product.getPrecio()));
            }
            Console.WriteLine("=====================================");

            Console.WriteLine("\nTotal a pagar: " + total.ToString("C2"));
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
