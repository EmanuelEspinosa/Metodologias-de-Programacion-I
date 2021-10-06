using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class LectorDeDatos : Manejador
    {
        public LectorDeDatos(Manejador sucesor) : base(sucesor) { }
        override public int numeroPorTeclado()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        override public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}
