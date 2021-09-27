using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
    }
}
