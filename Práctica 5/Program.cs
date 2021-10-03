using System;

namespace Práctica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher maestro = new Teacher();
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

            for (int i = 0; i < 20; i++)
            {
                if (i <= 10)
                {
                    IAlumno alum = new ProxyAlumno(gen.stringAleatorio(10), gen.numeroAleatorio(500), 1);
                    IAlumno decorar = new NotaConLegajo(alum);
                    decorar = new NotaConPromocion(decorar);
                    decorar = new NotaConAsteriscos(decorar);
                    decorar = new NotaEnLetras(decorar);
                    decorar = new NotaSecuencial(decorar);
                    maestro.goToClass(new AdapterAlumno(decorar));
                }
                if (i > 10)
                {
                    IAlumno alum = new ProxyAlumno(gen.stringAleatorio(10), gen.numeroAleatorio(500), 4);
                    IAlumno decorar = new NotaConLegajo(alum);
                    decorar = new NotaConPromocion(decorar);
                    decorar = new NotaConAsteriscos(decorar);
                    decorar = new NotaEnLetras(decorar);
                    decorar = new NotaSecuencial(decorar);
                    maestro.goToClass(new AdapterAlumno(decorar));
                }
            }
            maestro.teachingAClass();
            Console.ReadKey();
        }
    }
}
