using System;

namespace Práctica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher maestro = new Teacher();
            //GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i <= 10)
            //    {
            //        IAlumno alum = new ProxyAlumno(gen.stringAleatorio(10), gen.numeroAleatorio(500), 1);
            //        IAlumno decorar = new NotaConLegajo(alum);
            //        decorar = new NotaConPromocion(decorar);
            //        decorar = new NotaConAsteriscos(decorar);
            //        decorar = new NotaEnLetras(decorar);
            //        decorar = new NotaSecuencial(decorar);
            //        maestro.goToClass(new AdapterAlumno(decorar));
            //    }
            //    if (i > 10)
            //    {
            //        IAlumno alum = new ProxyAlumno(gen.stringAleatorio(10), gen.numeroAleatorio(500), 4);
            //        IAlumno decorar = new NotaConLegajo(alum);
            //        decorar = new NotaConPromocion(decorar);
            //        decorar = new NotaConAsteriscos(decorar);
            //        decorar = new NotaEnLetras(decorar);
            //        decorar = new NotaSecuencial(decorar);
            //        maestro.goToClass(new AdapterAlumno(decorar));
            //    }
            //}
            //maestro.teachingAClass();

            Coleccionable colec = new PilaProxy();
            colec.agregar(new Numero(5));
            colec.agregar(new Numero(10));
            colec.agregar(new Numero(3));
            Console.WriteLine("La colección tiene {0} elemetos",colec.Cuantos());
            Console.WriteLine("El minimo elemento es: {0}",colec.minimo());
            Console.WriteLine("El máximo elemento es: {0}",colec.maximo());

            colec.agregar(new Numero(2));
            Console.WriteLine("El minimo elemento es: {0}", colec.minimo());
            //colec.agregar(new Numero(3));
            //Console.WriteLine(colec.minimo());

            Console.ReadKey();
        }
    }
}
