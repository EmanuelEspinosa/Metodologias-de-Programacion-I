using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    class ClaveValor : Comparable
    {
        private Comparable clave;
        private object valor;

        public ClaveValor(Comparable clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Comparable getClave()
        {
            return clave;
        }
        public object getValor()
        {
            return valor;
        }
        public void setValor(object dato)
        {
            this.valor = dato;
        }
        public bool sosIgual(Comparable n)
        {
            return this.clave.sosIgual(((ClaveValor)n).getClave());
        }

        public bool sosMayor(Comparable n)
        {
            return this.clave.sosMayor(((ClaveValor)n).getClave());
        }

        public bool sosMenor(Comparable n)
        {
            return this.clave.sosMenor(((ClaveValor)n).getClave());
        }
        public override string ToString()
        {
            return (clave, valor).ToString();
        }
    }
}
