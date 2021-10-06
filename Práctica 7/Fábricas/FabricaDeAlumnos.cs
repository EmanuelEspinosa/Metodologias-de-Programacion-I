using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeAlumnos : fabricaDeComparables
    {

        Manejador handler = crearCadenaDeResponsabilidades();
        //GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        //LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {
            
            return new Alumno(handler.stringAleatorio(15),handler.numeroAleatorio(40000000),handler.numeroAleatorio(1000),handler.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno(handler.stringPorTeclado(),handler.numeroPorTeclado(),handler.numeroPorTeclado(),handler.numeroPorTeclado());
        }
    }
}
