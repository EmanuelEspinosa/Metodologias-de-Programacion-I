using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class FabricaDeAlumnosCompuestos : fabricaDeComparables
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {
            AlumnoComposite AlumCompos = new AlumnoComposite();
            ProxyAlumno alumProxy = new ProxyAlumno(gen.stringAleatorio(15), gen.numeroAleatorio(1000), gen.numeroAleatorio(3));
            AlumCompos.AddAlum(alumProxy);
            return AlumCompos;

        }

        public override Comparable crearPorTeclado()
        {
            AlumnoComposite AlumCompos = new AlumnoComposite();
            ProxyAlumno alumProxy = new ProxyAlumno(lector.stringPorTeclado(), lector.numeroPorTeclado(),gen.numeroAleatorio(3));
            AlumCompos.AddAlum(alumProxy);
            return AlumCompos;
        }
    }
}
