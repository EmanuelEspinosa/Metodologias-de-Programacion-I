using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class Numero : Comparable
    {
        private int valor;
        public Numero(int valor) { this.valor = valor; }
        public int getValor() { return valor; }

        public bool sosIgual(Comparable n)
        {
            return this.valor == ((Numero)n).valor;
        }

        public bool sosMayor(Comparable n)
        {
            return this.valor > ((Numero)n).getValor();
        }

        public bool sosMenor(Comparable n)
        {
            return this.valor < ((Numero)n).getValor();
        }
        public override string ToString()
        {
            return (valor).ToString();
        }
    }
}
