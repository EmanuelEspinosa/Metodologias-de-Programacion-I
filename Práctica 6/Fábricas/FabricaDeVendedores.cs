using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class FabricaDeVendedores : fabricaDeComparables
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {
            return new Vendedor(gen.stringAleatorio(10), gen.numeroAleatorio(1000000), gen.numeroAleatorio(35000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Vendedor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
