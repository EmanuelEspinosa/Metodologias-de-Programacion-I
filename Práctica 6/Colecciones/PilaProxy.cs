using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class PilaProxy : Coleccionable
    {
        private Coleccionable coleccion = null;
        Comparable min = null, max = null;
        int cuantos = 0;
        bool cont = false;
        public void agregar(Comparable n)
        {
            if (coleccion == null)
                coleccion = new Pila();
            coleccion.agregar(n);   
        }

        public bool contiene(Comparable n)
        {
            if (coleccion != null)
                cont = coleccion.contiene(n);
            return cont;

        }

        public int Cuantos()
        {
            if (coleccion != null)
            {
                cuantos = coleccion.Cuantos();
                max = coleccion.maximo();
                min = coleccion.minimo();
            }     
            return cuantos;
        }

        public Comparable maximo()
        {
            if(coleccion != null && cuantos != coleccion.Cuantos())
            {
                max = coleccion.maximo();
                min = coleccion.minimo();
                cuantos = coleccion.Cuantos();
            }
            return max;
        }

        public Comparable minimo()
        {
            if (coleccion != null && cuantos != coleccion.Cuantos())
            {
                min = coleccion.minimo();
                max = coleccion.maximo();
                cuantos = coleccion.Cuantos();
            }
            return min;
        }
    }
}
