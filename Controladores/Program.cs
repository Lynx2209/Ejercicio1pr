using Ejercicio1pr.Servicios;

namespace Ejercicio1pr.Controladores
{
    class Program
    {

        public static void Main(string[] args)
        {
            int n1;
            MenuInterfaz mi = new MenuImplementacion();
            n1 = mi.pedirNum();
            if (n1%2==0)
            {
                Console.WriteLine("El número " + n1 + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + n1 + " es impar.");
            }
        }


    }
}



