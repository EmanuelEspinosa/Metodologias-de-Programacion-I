using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class ComparacionPorPromedio : IComparisonStrategy
    {
        public bool EsIgual(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getPromedio() == ((Alumno)comp2).getPromedio();
        }

        public bool EsMayor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getPromedio() > ((Alumno)comp2).getPromedio();
        }

        public bool EsMenor(Comparable comp1, Comparable comp2)
        {
            return ((Alumno)comp1).getPromedio() < ((Alumno)comp2).getPromedio();
        }
    }
}
