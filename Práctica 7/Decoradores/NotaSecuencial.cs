using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class NotaSecuencial : Decorator
    {
        static int cont = 1;
        public NotaSecuencial(IAlumno alum) : base(alum) { }
        public override string mostrarCalificación()
        {
            string calif = base.mostrarCalificación();
            string nuevo = calif.Insert(0, cont + ")");
            cont++;
            return nuevo;
        }
    }
}
