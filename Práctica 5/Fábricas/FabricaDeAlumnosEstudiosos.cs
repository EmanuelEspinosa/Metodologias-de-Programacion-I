using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    class FabricaDeAlumnosEstudiosos : fabricaDeComparables
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {

            return new AlumnoMuyEstudioso(gen.stringAleatorio(15), gen.numeroAleatorio(1000), gen.numeroAleatorio(1000), gen.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
