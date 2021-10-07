using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class GeneradorDeDatosAleatorios : Manejador
    {
        private GeneradorDeDatosAleatorios(Manejador sucesor) : base(sucesor) { }

        private static GeneradorDeDatosAleatorios unicoGeneradorDeDatosAleatorios = null;

        private Random rdn = new Random();
        private string nuevaCadena;
        override public int numeroAleatorio(int max)
        {
            Random rdn = new Random(); 
            int num = rdn.Next(1, max);
            return num;
        }
        override public string stringAleatorio(int cant)
        {
            
            string Cadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char nuevaLetra;
            nuevaCadena = string.Empty;

            for(int i = 0; i < cant; i++)
            {
                nuevaLetra = Cadena[rdn.Next(0, Cadena.Length)];
                nuevaCadena += nuevaLetra.ToString();
            }
            return nuevaCadena;
        }
        public override string ToString()
        {
            return nuevaCadena.ToString();
        }

        public static GeneradorDeDatosAleatorios getInstance()
        {
            if (unicoGeneradorDeDatosAleatorios == null)
                unicoGeneradorDeDatosAleatorios = new GeneradorDeDatosAleatorios(null);
            return unicoGeneradorDeDatosAleatorios;
        }
    }
}
