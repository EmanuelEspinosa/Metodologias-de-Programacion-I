using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_2
{
    class Cola : Coleccionable, Iterable
    {
        List<Comparable> coleccion;

        public Cola()
        {
            coleccion = new List<Comparable>();
        }
        public void agregar(Comparable dato)
        {
            coleccion.Add(dato);
        }
        public Comparable desencolar()
        {
            Comparable aux;
            aux = (Comparable)coleccion[0];
            coleccion.Remove(aux);
            return aux;
        }
        public bool vacia()
        {
            return coleccion.Count == 0;
        }
        public int Cuantos()
        {
            return coleccion.Count;
        }
        public Comparable minimo()
        {
            Comparable min = coleccion[0];
            foreach (Comparable item in coleccion)
                if (item.sosMenor(min))
                    min = item;
            return min;
        }
        public Comparable maximo()
        {
            Comparable max = coleccion[0];
            foreach (Comparable item in coleccion)
                if (item.sosMayor(max))
                    max = item;
            return max;
        }
        public bool contiene(Comparable dato)
        {
            bool esta = false;
            foreach (Comparable item in coleccion)
                if (item.sosIgual(dato))
                    esta = true;
            return esta;
        }

        public Iterador crearIterador()
        {
            return new ColaIterador(coleccion);
        }
    }
}
