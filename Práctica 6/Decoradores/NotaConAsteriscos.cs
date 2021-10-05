using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class NotaConAsteriscos : Decorator
    {
        public NotaConAsteriscos(IAlumno alum) : base(alum) { }
        public override string mostrarCalificación()
        {
            string a = "***************************************";
            a += "\n *  " + base.mostrarCalificación() + "*";
            a += "\n***************************************";
            return a;
        }

    }
}
