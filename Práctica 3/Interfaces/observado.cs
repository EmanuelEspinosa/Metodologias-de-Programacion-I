using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    interface observado
    {
        void agregarObservador(observador o);
        void quitarObservador(observador o);
        void notificar();
    }
}
