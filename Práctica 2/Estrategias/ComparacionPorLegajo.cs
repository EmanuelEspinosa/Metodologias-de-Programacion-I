using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_2
{
    class ComparacionPorLegajo : IComparisonStrategy
    {
        public bool EsIgual(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getLegajo() == ((Alumno)comp2).getLegajo();
        }

        public bool EsMayor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getLegajo() > ((Alumno)comp2).getLegajo();
        }

        public bool EsMenor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getLegajo() < ((Alumno)comp2).getLegajo();
        }
    }
}
