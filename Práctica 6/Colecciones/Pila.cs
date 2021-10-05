using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Pila : Coleccionable, Iterable, Ordenable
    {
        OrdenEnAula1 ordenInicio = null;
        OrdenEnAula1 ordenAulaLLena = null;
        OrdenEnAula2 ordenLLegadaAlumno = null;
        List<Comparable> coleccion;

        public Pila()
        {
            coleccion = new List<Comparable>();
        }

        public void agregar(Comparable dato)
        {
            if(coleccion.Count == 0)
            {
                if (ordenInicio != null)
                    ordenInicio.ejecutar();
            }
            if (ordenLLegadaAlumno != null)
                ordenLLegadaAlumno.ejecutar(dato);
            if(coleccion.Count == 40)
            {
                if (ordenAulaLLena != null)
                    ordenAulaLLena.ejecutar();
            }
            coleccion.Add(dato);
        }
        public Comparable desapilar()
        {
            Comparable aux;
            int tam = coleccion.Count;
            aux = (Comparable)coleccion[tam - 1];
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
            return new PilaIterador(coleccion);
        }

        public void setOrdenInicio(OrdenEnAula1 ordenIni)
        {
            ordenInicio = ordenIni;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenLLeAlum)
        {
            ordenLLegadaAlumno = ordenLLeAlum;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 ordenAula1)
        {
            ordenAulaLLena = ordenAula1;
        }
    }
}
