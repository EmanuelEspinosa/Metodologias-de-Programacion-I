using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class LectorDeDatos : Manejador
    {
        private LectorDeDatos(Manejador sucesor) : base(sucesor) { }

        private static LectorDeDatos unicoLectorDeDatos = null;
        override public int numeroPorTeclado()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        override public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
        public static LectorDeDatos getInstance()
        {
            if (unicoLectorDeDatos == null)
                unicoLectorDeDatos = new LectorDeDatos(GeneradorDeDatosAleatorios.getInstance());
            return unicoLectorDeDatos;
        }
    }
}
