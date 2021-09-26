using System;

namespace Práctica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        public static void llenar(Coleccionable coleccion)
        {
            Comparable comparable;
            Random rdn = new Random();
            int numero;
            for (int i = 0; i < 20; i++)
            {
                numero = rdn.Next(5, 115);
                comparable = new Numero(numero);
                coleccion.agregar(comparable);
            }
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
    }
}
