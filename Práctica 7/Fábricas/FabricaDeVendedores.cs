using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeVendedores : fabricaDeComparables
    {
        Manejador handler = crearCadenaDeResponsabilidades();

        public override Comparable crearAleatorio()
        {
            return new Vendedor(handler.stringAleatorio(10), handler.numeroAleatorio(1000000), handler.numeroAleatorio(35000));
        }

        public override Comparable crearLeyendoDeArchivo()
        {
            return new Vendedor(handler.stringDesdeArchivo(10), (int)handler.numeroDesdeArchivo(1000000), handler.numeroDesdeArchivo(35000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Vendedor(handler.stringPorTeclado(), handler.numeroPorTeclado(), handler.numeroPorTeclado());
        }
    }
}
