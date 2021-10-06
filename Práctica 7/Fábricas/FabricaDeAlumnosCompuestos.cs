using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class FabricaDeAlumnosCompuestos : fabricaDeComparables
    {
        Manejador handler = crearCadenaDeResponsabilidades();

        public override Comparable crearAleatorio()
        {
            AlumnoComposite AlumCompos = new AlumnoComposite();
            ProxyAlumno alumProxy = new ProxyAlumno(handler.stringAleatorio(15), handler.numeroAleatorio(1000), handler.numeroAleatorio(3));
            AlumCompos.AddAlum(alumProxy);
            return AlumCompos;

        }

        public override Comparable crearLeyendoDeArchivo()
        {
            AlumnoComposite AlumCompos = new AlumnoComposite();
            ProxyAlumno alumProxy = new ProxyAlumno(handler.stringDesdeArchivo(15), (int)handler.numeroDesdeArchivo(1000), (int)handler.numeroDesdeArchivo(3));
            AlumCompos.AddAlum(alumProxy);
            return AlumCompos;
        }

        public override Comparable crearPorTeclado()
        {
            AlumnoComposite AlumCompos = new AlumnoComposite();
            ProxyAlumno alumProxy = new ProxyAlumno(handler.stringPorTeclado(), handler.numeroPorTeclado(), handler.numeroAleatorio(3));
            AlumCompos.AddAlum(alumProxy);
            return AlumCompos;
        }
    }
}
