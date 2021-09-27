using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class Alumno : Persona
    {
        int legajo;
        double promedio;
        private IComparisonStrategy estrategia;

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new ComparacionPorLegajo();
        }

        public int getLegajo() { return this.legajo; }

        public double getPromedio() { return this.promedio; }

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
        public override string ToString()
        {
            return (nombre, dni, legajo, promedio).ToString();
        }
    }
}
