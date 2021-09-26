using System;

namespace Práctica_1
{
	public class Alumno : Persona
	{
		int legajo;
        double promedio;
        
        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre,dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }
        
        public int getLegajo() {return this.legajo;}
        
        public double getPromedio() {return this.promedio;}
        
        override public bool sosIgual(Comparable n)
        {
            bool es = false;
            if(this.legajo == ((Alumno)n).getLegajo())
                es = true;
            return es;
        }
        override public bool sosMayor(Comparable n)
        {
            bool es = false;
            if(this.legajo > ((Alumno)n).getLegajo())
                es = true;
            return es;
        }
        override public bool sosMenor(Comparable n)
        {
            bool es = false;
            if(this.legajo < ((Alumno)n).getLegajo())
                es = true;
            return es;
        }
	}
}
