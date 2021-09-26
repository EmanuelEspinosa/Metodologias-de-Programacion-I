using System;

namespace Práctica_1
{
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila = new Pila();
        private Cola cola = new Cola();
        
        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;
            this.cola = cola;
        }
        
        public void agregar(Comparable n) { }
        
        public int Cuantos()
        {
            return pila.Cuantos() + cola.Cuantos();
        }
        public Comparable minimo()
        {
            Comparable min;
            if(((Comparable)pila.minimo()).sosMenor((Comparable)cola.minimo()))
                min = ((Comparable)pila.minimo());
            else
                min = ((Comparable)cola.minimo());
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = null;
            if(((Comparable)pila.maximo()).sosMayor((Comparable)cola.maximo()))
                max = ((Comparable)pila.maximo());
            else
                max = ((Comparable)cola.maximo());
            return max;
        }
        public bool contiene(Comparable n)
        {
            bool esta = false;
            if(pila.contiene(n))
                esta = true;
            else{
                if(cola.contiene(n))
                    esta = true;
            }
            return esta;
        } 
	}
}
