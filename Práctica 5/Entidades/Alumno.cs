using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    class Alumno : Persona, IAlumno
    {
        int legajo;
        double promedio;
        private IComparisonStrategy estrategia;
        private int calificación;

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new ComparacionPorLegajo();
        }

        /*PROPIEDADES*/
        public int getLegajo() { return this.legajo; }
        public double getPromedio() { return this.promedio; }
        public int getCalificación() { return this.calificación; }
        public void setCalificación(int calif) { this.calificación = calif; }

        /*ESTRATEGIAS DE COMPARACIÓN*/
        override public bool sosIgual(Comparable n)
        {
            return estrategia.EsIgual(this, n);
        }
        override public bool sosMayor(Comparable n)
        {
            return estrategia.EsMayor(this, n);
        }
        override public bool sosMenor(Comparable n)
        {
            return estrategia.EsMenor(this, n);
        }
        public void setEstrategia(IComparisonStrategy estrategia)
        {
            this.estrategia = estrategia;
        }

        /*MÉTODOS PROPIOS DE LA PRÁCTICA 4*/
        public virtual int responderPregunta(int pregunta)
        {
            Random rdn = new Random();
            return rdn.Next(1, 3);
        }
        public string mostrarCalificación()
        {
            return nombre + " " + calificación.ToString();
        }
        public override string ToString()
        {
            return (nombre, dni, legajo, promedio).ToString();
        }
    }
}
