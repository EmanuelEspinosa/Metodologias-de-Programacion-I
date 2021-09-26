using System;

namespace Práctica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //ColeccionMultiple coleccion = new ColeccionMultiple(pila, cola);
            //llenarPersonas(pila);
            //llenarPersonas(cola);
            //informarPersonas(coleccion);


            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //Conjunto conjunto = new Conjunto();
            //Diccionario diccionario = new Diccionario();
            //llenarAlumnos(pila);
            //llenarAlumnos(cola);
            //llenarAlumnos(conjunto);
            //llenarAlumnos(diccionario);
            //imprimirElementos(pila);
            //Console.WriteLine("\n");
            //imprimirElementos(cola);
            //Console.WriteLine("\n");
            //imprimirElementos(conjunto);
            //Console.WriteLine("\n");
            //imprimirElementos(diccionario);

            Pila pila = new Pila();
            llenarAlumnos(pila);

            //cambiarEstrategia(pila, new ComparacionPorNombre());
            //informarAlumno(pila);

            cambiarEstrategia(pila, new ComparacionPorDni());
            Console.WriteLine("\n");
            informarAlumno(pila);

            //cambiarEstrategia(pila, new ComparacionPorLegajo());
            //informarAlumno(pila);

            //cambiarEstrategia(pila, new ComparacionPorPromedio());
            //informarAlumno(pila);

            Console.ReadKey();
        }
        public static void llenarPersonas(Coleccionable coleccion)
        {
            Comparable comparable;
            Random rdn = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = generarNombre();
                int numeroDNI = rdn.Next(11000000, 45000000);
                comparable = new Persona(nombre, numeroDNI);
                coleccion.agregar(comparable);
            }
        }
        public static void llenarAlumnos(Coleccionable coleccion)
        {
            Comparable comparable;
            Random rdn = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombre = generarNombre();
                int numDNI = rdn.Next(25000000, 50000000);
                int leg = rdn.Next(21000, 99999);
                double prom = rdn.Next(1, 10);
                comparable = new Alumno(nombre, numDNI, leg, prom);
                coleccion.agregar(comparable);
            }
        }
        public static string generarNombre()
        {
            Random rnd = new Random();
            string[] nombres = { "Juan", "Pablo", "Maria", "Pedro", "Carmen", "Jose", "Mariana", "Alberto", "Marcelo", "Julia", "Andres", "Guido", "Carolina", "Hernan" };
            string[] apellidos = { "Sanchez", "Perez", "Lopez", "Zelaya", "Alvarez", "Garcia", "Espinosa", "Gerez", "Acosta", "Drago", "Gonzalez", "Bustamante", "Rega", "Zamudio" };
            string gen = nombres[rnd.Next(0, 14)] + " " + apellidos[rnd.Next(0, 14)];
            return gen;
        }
        public static void informarPersonas(Coleccionable colec)
        {
            Console.WriteLine("* Hay {0} elementos en la colección", colec.Cuantos());
            Console.WriteLine("* El menor elemento es: {0}", colec.minimo());
            Console.WriteLine("* El mayor elemento es: {0}", colec.maximo());
            Console.Write("Ingrese un valor por teclado: ");
            Comparable comparable = new Persona("", int.Parse(Console.ReadLine()));
            if (colec.contiene(comparable))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");

        }
        public static void informarAlumno(Coleccionable colec)
        {
            Console.WriteLine("* Hay {0} elementos en la colección", colec.Cuantos());
            Console.WriteLine("* El menor elemento es: {0}", colec.minimo());
            Console.WriteLine("* El mayor elemento es: {0}", colec.maximo());
            Console.Write("Ingrese un valor por teclado: ");
            Comparable comp = new Alumno("", int.Parse(Console.ReadLine()), 0, 0);
            if (colec.contiene(comp))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }
        public static void imprimirElementos(Iterable colec)
        {
            Iterador it = colec.crearIterador();
            while (!it.fin())
            {
                Console.Write(it.actual() + " ");
                it.siguiente();
            }
        }
        public static void cambiarEstrategia(Iterable coleccion, IComparisonStrategy estrategia)
        {
            Iterador itec = coleccion.crearIterador();
            while (!itec.fin())
            {
                object alumno = itec.actual();
                ((Alumno)alumno).setEstrategia(estrategia);
                Console.Write(itec.actual() + " ");
                itec.siguiente();
            }
        }
    }
}
