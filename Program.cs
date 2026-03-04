using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int , string > productos = new Dictionary < int , string > ();
            int     ID = 589;
            Console.WriteLine (" ingrese el codigo del producto: ");
            int cod = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            if (!productos.ContainsKey(589))
            {
                Console.WriteLine(" ERROR : el codigo "  + " ya esta asignado ");
            }
            else
            {
                 productos.Add(cod, nombre);
                Console.WriteLine(" producto " + nombre + " se agrego exitosamente");
                
                    
            }


            

        }
    }
}
