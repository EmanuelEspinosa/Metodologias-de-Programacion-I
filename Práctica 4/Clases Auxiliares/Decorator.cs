using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_4
{
    abstract class Decorator : IAlumno
    {
        protected IAlumno alumno;

        public Decorator(IAlumno alumno)
        {
            this.alumno = alumno;
        }
        public int getCalificación() { return this.alumno.getCalificación(); }

        public int getLegajo() { return this.alumno.getLegajo(); }

        public string getNombre() { return this.alumno.getNombre(); }

        public virtual string mostrarCalificación() { return this.alumno.mostrarCalificación(); }

        public int responderPregunta(int pregunta) { return this.alumno.responderPregunta(pregunta); }

        public void setCalificación(int calif) { this.alumno.setCalificación(calif); }

        public bool sosIgual(Comparable n) { return this.alumno.sosIgual(n); }

        public bool sosMayor(Comparable n) { return this.alumno.sosMayor(n); }

        public bool sosMenor(Comparable n) { return this.alumno.sosMenor(n); }

    }
}
