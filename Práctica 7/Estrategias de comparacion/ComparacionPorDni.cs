using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class ComparacionPorDni : IComparisonStrategy
    {
        public bool EsIgual(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getDni() == ((Alumno)comp2).getDni();
        }

        public bool EsMayor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getDni() > ((Alumno)comp2).getDni();
        }

        public bool EsMenor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getDni() < ((Alumno)comp2).getDni();
        }
    }
}
