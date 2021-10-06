using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();
        Comparable crearPorTeclado();
        Comparable crearLeyendoDeArchivo();
    }
}
