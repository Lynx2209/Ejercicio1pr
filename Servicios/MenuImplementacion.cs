using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1pr.Servicios
{
    internal class MenuImplementacion:MenuInterfaz
    {
        public int pedirNum()
        {
            Console.WriteLine("Introduzca un numero: ");
            int n1;
            n1=Convert.ToInt32(Console.ReadLine());
            return n1;
        }
    }
}
