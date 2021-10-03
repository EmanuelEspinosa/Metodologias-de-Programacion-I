using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
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
            teacher.goToClass(new AdapterAlumno(alumno));
        }
        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }
}
