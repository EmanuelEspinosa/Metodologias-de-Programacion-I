using System;

namespace Práctica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Aula aulaNueva = new Aula(teacher);
            AlumnoComposite alumnoCompuesto = new AlumnoComposite();

            for (int i = 0; i < 5; i++)
            {
                IAlumno alum = (IAlumno)fabricaDeComparables.crearAleatorio(1);
                aulaNueva.nuevoAlumno(alum);
            }
            for (int i = 0; i < 2; i++)
            {
                IAlumno alum = (IAlumno)fabricaDeComparables.crearPorTeclado(2);
                aulaNueva.nuevoAlumno(alum);
            }
            for (int i = 0; i < 5; i++)
            {
                IAlumno alum = (IAlumno)fabricaDeComparables.crearLeyendoDeArchivo(1);
                alumnoCompuesto.AddAlum(alum);
            }
            aulaNueva.nuevoAlumno(alumnoCompuesto);
            teacher.teachingAClass();

            Console.ReadKey();

        }
        static void llenar(Coleccionable coleccion, int opcion)
        {
            Comparable comparable;
            for (int i = 0; i < 20; i++)
            {
                comparable = fabricaDeComparables.crearLeyendoDeArchivo(opcion);
                coleccion.agregar(comparable);
            }
        }

    }
}
