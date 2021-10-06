using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class NotaEnLetras : Decorator
    {
        public NotaEnLetras(IAlumno alum) : base(alum) { }
        private string[] Notas = new string[] { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
        public override string mostrarCalificación()
        {
            string calif = base.mostrarCalificación();
            int index = calif.LastIndexOf(alumno.getCalificación().ToString());
            string nuevo = calif.Insert(index+2, "(" + Notas[alumno.getCalificación()] + ")");
            return nuevo;
        }
    }
}
