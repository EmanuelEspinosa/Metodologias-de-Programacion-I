using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public string stringPorTeclado()
        {
            return Console.ReadLine();
        }
    }
}
