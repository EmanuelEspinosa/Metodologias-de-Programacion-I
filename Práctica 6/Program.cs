using System;

namespace Práctica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher maestro = new Teacher();
            //AlumnoComposite alumno = new AlumnoComposite();
            //for (int i = 0; i < 5; i++)
            //{
            //    IAlumno alum = (IAlumno)fabricaDeComparables.crearAleatorio(1);
            //    alumno.AddAlum(alum);
            //}
            //Aula aula = new Aula(maestro);
            //aula.nuevoAlumno(alumno);
            //maestro.teachingAClass();

            GeneradorDeDatosAleatorios ran = new GeneradorDeDatosAleatorios();
            Teacher profe = new Teacher();
            for (int a = 0; a < 10; a++)
            {
                ProxyAlumno prox = new ProxyAlumno(ran.stringAleatorio(10), ran.numeroAleatorio(10), 2);
                profe.goToClass(new AdapterAlumno(prox));
            }
            for (int b = 0; b < 10; b++)
            {
                AlumnoComposite alumn = (AlumnoComposite)fabricaDeComparables.crearAleatorio(3);
                profe.goToClass(new AdapterAlumno(alumn));
            }
            profe.teachingAClass();




        }
    }
}
