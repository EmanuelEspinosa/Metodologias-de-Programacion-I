using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    class AdapterAlumno : Student
    {
        private IAlumno alumno;

        public AdapterAlumno(IAlumno alumno)
        {
            this.alumno = alumno;
        }
        public IAlumno getAlumno() { return alumno; }

        public bool equals(Student student)
        {
            return alumno.sosIgual(((AdapterAlumno)student).getAlumno());
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AdapterAlumno)student).getAlumno());
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AdapterAlumno)student).getAlumno());
        }

        public void setScore(int score)
        {
            alumno.setCalificación(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificación();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
    }
}
