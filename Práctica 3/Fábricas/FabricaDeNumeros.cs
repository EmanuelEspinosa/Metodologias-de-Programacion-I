using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class FabricaDeNumeros : fabricaDeComparables
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {
            return new Numero(gen.numeroAleatorio(25000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(lector.numeroPorTeclado());
        }
    }
}
