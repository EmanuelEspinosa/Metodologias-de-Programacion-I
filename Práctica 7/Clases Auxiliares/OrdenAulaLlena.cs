using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            aula.claseLista();
        }
    }
}
