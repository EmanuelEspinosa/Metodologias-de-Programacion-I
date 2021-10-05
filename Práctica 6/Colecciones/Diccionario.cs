using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Diccionario : Coleccionable, Iterable
    {
        private Conjunto coleccion;
        Comparable key = new Numero(100);

        public Diccionario() { coleccion = new Conjunto(); }

        public void agregar(Comparable valor)
        {
            bool existe = false;
            ClaveValor keyValue = new ClaveValor(key, valor);
            foreach (ClaveValor item in coleccion.getConjunto())
            {
                if (item.sosIgual(keyValue))
                {
                    existe = true;
                    item.setValor(keyValue.getValor());
                }
            }
            if (!existe)
            {
                coleccion.getConjunto().Add(keyValue);
                Numero numAux = new Numero(((Numero)key).getValor() + 1);
                key = new Numero(numAux.getValor());
            }
        }
        public Comparable valorDe(Comparable clave)
        {
            Comparable valor = null;
            foreach (ClaveValor item in coleccion.getConjunto())
            {
                if (item.sosIgual(clave))
                {
                    valor = (Comparable)item.getValor();
                }
            }
            return valor;
        }
        public List<Comparable> getDiccionario()
        {
            return coleccion.getConjunto();
        }

        public int Cuantos()
        {
            return coleccion.Cuantos();
        }

        public Comparable minimo()
        {
            return coleccion.minimo();
        }

        public Comparable maximo()
        {
            return coleccion.maximo();
        }

        public bool contiene(Comparable n)
        {
            bool esta = false;
            if (key.sosIgual(n))
                esta = true;
            return esta;
        }

        public Iterador crearIterador()
        {
            return new DiccionarioIterador(this);
        }
    }
}
