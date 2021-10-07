using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    public abstract class Manejador
    {
		private Manejador sucesor = null;

		public Manejador(Manejador sucesor)
		{
			this.sucesor = sucesor;
		}
		virtual public string stringAleatorio(int cant)
		{
			string valor = null;
			if (sucesor != null)
				valor = sucesor.stringAleatorio(cant);
			return valor;
		}
		virtual public int numeroAleatorio(int max)
		{
			int valor = 0;
			if (sucesor != null)
				valor = sucesor.numeroAleatorio(max);
			return valor;
		}
		virtual public int numeroPorTeclado()
		{
			int valor = 0;
			if (sucesor != null)
				valor = sucesor.numeroPorTeclado();
			return valor;
		}
		virtual public string stringPorTeclado()
        {
			string valor = null;
			if (sucesor != null)
                valor = sucesor.stringPorTeclado();
			return valor;
        }
		virtual public double numeroDesdeArchivo(double max)
        {
			double valor = 0;
			if (sucesor != null)
				valor = sucesor.numeroDesdeArchivo(max);
			return valor;
        }
		virtual public string stringDesdeArchivo(int cant)
        {
			string valor = null;
			if (sucesor != null)
				valor = sucesor.stringDesdeArchivo(cant);
			return valor;
        }
	}
}
