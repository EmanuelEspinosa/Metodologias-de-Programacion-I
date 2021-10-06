using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class NotaConLegajo : Decorator
    {
        public NotaConLegajo(IAlumno alum) : base(alum) { }
        public override string mostrarCalificación()
        {
            string calificacion = base.mostrarCalificación();
            int index = calificacion.IndexOf(" ");
            string nuevo = calificacion.Insert(index, "(" + alumno.getLegajo() + ")");
            return nuevo;
        }
    }
}
