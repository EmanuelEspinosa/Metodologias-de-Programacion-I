using System;

namespace Práctica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher maestro = new Teacher();
            GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

            /*IMPLEMENTANDO EL PATRON << ADAPTER >>*/
            //AdapterAlumno alumno;
            //for (int i = 0; i < 20; i++)
            //{
            //    if(i <= 10)
            //    {
            //        alumno = new AdapterAlumno((Alumno)fabricaDeComparables.crearAleatorio(1));
            //        maestro.goToClass(alumno);
            //    }
            //    if(i > 10)
            //    {
            //        alumno = new AdapterAlumno((AlumnoMuyEstudioso)fabricaDeComparables.crearAleatorio(4));
            //        maestro.goToClass(alumno);

            //    }
            //}

            /*IMPLEMENTANDO EL PATRON << ADAPTER >> Y << DECORATOR >>*/
            for (int i = 0; i < 20; i++)
            {
                if (i <= 10)
                {
                    IAlumno alum = (Alumno)fabricaDeComparables.crearAleatorio(1);
                    IAlumno decorar = new NotaConLegajo(alum);
                    decorar = new NotaConPromocion(decorar);
                    decorar = new NotaConAsteriscos(decorar);
                    decorar = new NotaEnLetras(decorar);
                    decorar = new NotaSecuencial(decorar);
                    maestro.goToClass(new AdapterAlumno(decorar));
                }
                if (i > 10)
                {
                    IAlumno alum = (Alumno)fabricaDeComparables.crearAleatorio(4);
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
