using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            aula.comenzar();
        }
    }
}
