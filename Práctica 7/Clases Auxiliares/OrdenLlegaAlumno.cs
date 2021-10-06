using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable comp)
        {
            aula.nuevoAlumno((IAlumno)comp);
        }
    }
}
