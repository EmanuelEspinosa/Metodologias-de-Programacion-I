using System;

namespace Práctica_1
{
	public class Persona : Comparable
	{
		protected string nombre;
        protected int dni;
        
        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        
        public string getNombre() {return this.nombre;}
        
        public int getDni() {return this.dni;}
        
        virtual public bool sosIgual(Comparable n)
        {
            bool es = false;
            if(this.dni == ((Persona)n).getDni())
                es = true;
            return es;
        }
        virtual public bool sosMayor(Comparable n)
        {
            bool es = false;
            if(this.dni > ((Persona)n).getDni())
                es = true;
            return es;
        }
        virtual public bool sosMenor(Comparable n)
        {
            bool es = false;
            if(this.dni < ((Persona)n).getDni())
                es = true;
            return es;
        }
	}
}
