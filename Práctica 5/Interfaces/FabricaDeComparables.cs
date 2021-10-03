using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
    }
}
