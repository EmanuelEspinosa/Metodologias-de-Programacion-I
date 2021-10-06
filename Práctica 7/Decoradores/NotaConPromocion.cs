using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class NotaConPromocion : Decorator
    {
        public NotaConPromocion(IAlumno alum) : base(alum) { }
        public override string mostrarCalificación()
        {
            int calificacion = alumno.getCalificación();
            string muestroCalif = base.mostrarCalificación(), aux = null; 
            int index = muestroCalif.LastIndexOf(")");

            if (calificacion >= 7)
                aux = "PROMOCIÓN";
            if (calificacion >= 4 && calificacion < 7)
                aux = "APROBADO";
            if (calificacion < 4)
                aux = "DESAPROBADO";

            string nuevo = muestroCalif.Insert(index + 1, "(" + aux + ")");
            return nuevo;    
        }
    }
}
