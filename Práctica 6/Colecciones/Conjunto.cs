using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Conjunto : Coleccionable, Iterable
    {
        List<Comparable> elementos = new List<Comparable>();

        public bool pertenece(Comparable dato)
        {
            bool esta = false;
            foreach (Comparable item in elementos)
            {
                if (item.sosIgual(dato) == true)
                    esta = true;
            }
            return esta;
        }
        public void agregar(Comparable dato)
        {
            if (!pertenece(dato))
            {
                elementos.Add(dato);
            }
        }
        public List<Comparable> getConjunto() { return elementos; }

        public int Cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable min = elementos[0];
            foreach (Comparable item in elementos)
            {
                if (item.sosMenor(min))
                    min = item;
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = elementos[0];
            foreach (Comparable item in elementos)
            {
                if (item.sosMayor(max))
                    max = item;
            }
            return max;
        }

        public bool contiene(Comparable n)
        {
            bool esta = false;
            foreach (Comparable item in elementos)
            {
                if (item.sosIgual(n))
                    esta = true;
            }
            return esta;
        }

        public Iterador crearIterador()
        {
            return new ConjuntoIterador(elementos);
        }
    }
}
