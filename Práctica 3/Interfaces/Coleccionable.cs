﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    interface Coleccionable
    {
        int Cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable n);
        bool contiene(Comparable n);
    }
}
