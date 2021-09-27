using System;

namespace Práctica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            //llenar(pila,3);
            //llenar(cola,3);

            //informar(pila,3);
            //Console.WriteLine("\n");
            //informar(cola,3);
            //Console.WriteLine("\n");
            //informar(multiple,3);

            Coleccionable coleccion = new Cola();
            llenar(coleccion, 3);
            Gerente gerente = new Gerente("Alejandro", 11111111, 0001);
            Vendedor vend1 = new Vendedor("Gonzalo", 2222222, 52000);
            Vendedor vend2 = new Vendedor("Mario", 33333333, 43000);
            Vendedor vend3 = new Vendedor("Sofia", 44444444, 51000);
            Vendedor vend4 = new Vendedor("Paula", 55555555, 49000);
            vend1.agregarObservador(gerente);
            vend2.agregarObservador(gerente);
            vend3.agregarObservador(gerente);
            vend4.agregarObservador(gerente);

            vend1.venta(5100);
            vend3.venta(5500);
            vend2.venta(4900);
            vend4.venta(5247);
            vend1.venta(5900);
            vend1.venta(6100);
            vend1.venta(6100);
            vend1.venta(6100);
            gerente.cerrar();

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
        static void informar(Coleccionable coleccion, int opcion)
        {
            Console.WriteLine("Contiene {0}", coleccion.Cuantos());
            Console.WriteLine("El mínimo es {0}", coleccion.minimo());
            Console.WriteLine("El máximo es {0}", coleccion.maximo());
            Comparable comp = fabricaDeComparables.crearPorTeclado(opcion);
            if (coleccion.contiene(comp))
                Console.WriteLine("El elemento está en la colección");
            else
                Console.WriteLine("El elemento no está en la colección");
        }
        static void JornadaDeVentas(Coleccionable vendedores)
        {
            Random rdn = new Random();
            Iterador iterar = ((Iterable)vendedores).crearIterador();

            //Esto se va a repetir 20 veces, ya que es la cantidad de elementos que va a tener el coleccionable
            while (!iterar.fin())
            {
                double monto = rdn.Next(1, 7000);
                ((Vendedor)iterar.actual()).venta(monto);
            }
        }
    }
}
