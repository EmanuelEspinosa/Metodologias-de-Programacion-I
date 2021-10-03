using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    class GeneradorDeDatosAleatorios
    {
        private Random rdn = new Random();
        private string nuevaCadena;
        public int numeroAleatorio(int max)
        {
            Random rdn = new Random();
            int num = rdn.Next(0, max);
            return num;
        }
        public string stringAleatorio(int cant)
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
    }
}
