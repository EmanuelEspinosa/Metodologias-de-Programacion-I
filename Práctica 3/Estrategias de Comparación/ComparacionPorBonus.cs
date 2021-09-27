using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class ComparacionPorBonus : IComparisonStrategy
    {
        public bool EsIgual(Comparable comp1, Comparable comp2)
        {
            return ((Vendedor)comp1).getSueldoBasico() == ((Vendedor)comp2).getSueldoBasico();
        }

        public bool EsMayor(Comparable comp1, Comparable comp2)
        {
            return ((Vendedor)comp1).getSueldoBasico() > ((Vendedor)comp2).getSueldoBasico();
        }

        public bool EsMenor(Comparable comp1, Comparable comp2)
        {
            return ((Vendedor)comp2).getSueldoBasico() < ((Vendedor)comp2).getSueldoBasico();
        }
    }
}
