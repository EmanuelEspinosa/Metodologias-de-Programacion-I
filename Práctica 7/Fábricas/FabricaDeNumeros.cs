using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeNumeros : fabricaDeComparables
    {
        Manejador handler = crearCadenaDeResponsabilidades();

        public override Comparable crearAleatorio()
        {
            return new Numero(handler.numeroAleatorio(25000));
        }

        public override Comparable crearLeyendoDeArchivo()
        {
            return new Numero((int)handler.numeroDesdeArchivo(25000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(handler.numeroPorTeclado());
        }
    }
}
