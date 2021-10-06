using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeAlumnosEstudiosos : fabricaDeComparables
    {
        Manejador handler = crearCadenaDeResponsabilidades();
        //GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        //LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {

            return new AlumnoMuyEstudioso(handler.stringAleatorio(15), handler.numeroAleatorio(1000), handler.numeroAleatorio(1000), handler.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(handler.stringPorTeclado(), handler.numeroPorTeclado(), handler.numeroPorTeclado(), handler.numeroPorTeclado());
        }
    }
}
