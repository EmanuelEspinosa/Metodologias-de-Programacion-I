using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeAlumnosEstudiosos : fabricaDeComparables
    {
        Manejador handler = crearCadenaDeResponsabilidades();

        public override Comparable crearAleatorio()
        {

            return new AlumnoMuyEstudioso(handler.stringAleatorio(15), handler.numeroAleatorio(1000), handler.numeroAleatorio(1000), handler.numeroAleatorio(10));
        }

        public override Comparable crearLeyendoDeArchivo()
        {
            return new AlumnoMuyEstudioso(handler.stringDesdeArchivo(15), (int)handler.numeroDesdeArchivo(1000), (int)handler.numeroDesdeArchivo(1000), handler.numeroDesdeArchivo(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(handler.stringPorTeclado(), handler.numeroPorTeclado(), handler.numeroPorTeclado(), handler.numeroPorTeclado());
        }
    }
}
