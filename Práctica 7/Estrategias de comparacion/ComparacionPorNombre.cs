using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class ComparacionPorNombre : IComparisonStrategy
    {
        //CompareTo() para orden alfabetico. 0: Es igual, 1: Es mayor, -1: Es menor
        public bool EsIgual(Comparable comp1, Comparable comp2)
        {
            return (((Alumno)comp1).getNombre().CompareTo(((Alumno)comp2).getNombre()) == 0);
        }

        public bool EsMayor(Comparable comp1, Comparable comp2)
        {
            return (((Alumno)comp1).getNombre().CompareTo(((Alumno)comp2).getNombre()) == 1);
        }

        public bool EsMenor(Comparable comp1, Comparable comp2)
        {
            return (((Alumno)comp1).getNombre().CompareTo(((Alumno)comp2).getNombre()) == -1);
        }
    }
}
