using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    interface IComparisonStrategy
    {
        bool EsIgual(Comparable comp1, Comparable comp2);
        bool EsMenor(Comparable comp1, Comparable comp2);
        bool EsMayor(Comparable comp1, Comparable comp2);
    }
}
