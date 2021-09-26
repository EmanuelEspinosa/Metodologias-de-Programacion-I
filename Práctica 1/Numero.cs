using System;

namespace Práctica_1
{
	public class Numero : Comparable
	{
		private int numero;
		
		public Numero(int numero)
        {
            this.numero = numero;
        }
		
		public int getValor() {return this.numero;}
		
		public bool sosIgual(Comparable n)
        {
            bool es = false;
            if(this.numero == ((Numero)n).getValor())
                es = true;
            return es;
        }
		public bool sosMayor(Comparable n)
        {
            bool es = false;
            if(this.numero > ((Numero)n).getValor())
                es = true;
            return es;
        }
		public bool sosMenor(Comparable n)
        {
            bool es = false;
            if(this.numero < ((Numero)n).getValor())
                es = true;
            return es;
        }
		
	}
}
