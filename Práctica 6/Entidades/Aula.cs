using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Aula
    {
        Teacher teacher;
        IAlumno alumno;

        public Aula(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public void comenzar()
        {
            Console.WriteLine("Instanciando un Teacher");
            teacher = new Teacher();
        }
        public void nuevoAlumno(IAlumno alum)
        {
            alumno = alum;
            if(alum.GetType().Name == "AlumnoComposite")
            {
                List<IAlumno> lista = ((AlumnoComposite)alum).getLista();
                foreach (IAlumno item in lista)
                {
                    teacher.goToClass(new AdapterAlumno(alumno));
                }
            }
            else
                teacher.goToClass(new AdapterAlumno(alumno));
        }
        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }
}
