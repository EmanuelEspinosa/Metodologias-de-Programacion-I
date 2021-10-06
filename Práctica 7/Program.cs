using System;

namespace Práctica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            llenar(pila, 1);
            Iterador pilait = pila.crearIterador();
            
            while(! pilait.fin())
            {
                Console.WriteLine(pilait.actual());
                pilait.siguiente();
            }
            Console.ReadKey();

        }
        static void llenar(Coleccionable coleccion, int opcion)
        {
            Comparable comparable;
            for (int i = 0; i < 20; i++)
            {
                comparable = fabricaDeComparables.crearAleatorio(opcion);
                coleccion.agregar(comparable);
            }
        }

    }
}
