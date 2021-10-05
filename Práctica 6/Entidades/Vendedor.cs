using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Vendedor : Persona//, observado
    {
        private double ultimoMonto;
        private double SueldoBasico,bonus;
        private IComparisonStrategy estrategia;
        //private List<observador> observadores;

        public Vendedor(string nombre, int dni, double SueldoBasico) : base(nombre, dni)
        {
            this.SueldoBasico = SueldoBasico;
            this.bonus = 1;
            //this.estrategia = new ComparacionPorBonus();
            //observadores = new List<observador>();
        }
        public void venta(double monto)
        {
            //Console.WriteLine(monto);
            ultimoMonto = monto;
            //this.notificar();

        }
        public void aumentoBonus()
        {
            bonus += 0.1;
        }
        public double getSueldoBasico() { return SueldoBasico; }
        public double getBonus() { return bonus; }

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
        public override string ToString()
        {
            return (nombre,bonus).ToString();
        }
        public double getMonto()
        {
            return ultimoMonto;
        }

        //public void agregarObservador(observador o)
        //{
        //    if(! observadores.Contains(o))
        //    {
        //        observadores.Add(o);
        //    }
            
        //}
        //public void quitarObservador(observador o)
        //{
        //    if(observadores.Contains(o))
        //    {
        //        observadores.Remove(o);
        //    }
        //}
        //public void notificar()
        //{
        //    foreach (observador item in observadores)
        //    {
        //        item.actualizar(this);
        //    }
        //}
    }
}
