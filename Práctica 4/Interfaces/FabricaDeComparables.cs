using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_4
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
    }
}
