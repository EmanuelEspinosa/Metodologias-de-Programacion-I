using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_4
{
    class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre() { return this.nombre; }

        public int getDni() { return this.dni; }

        virtual public bool sosIgual(Comparable n)
        {
            bool es = false;
            if (this.dni == ((Persona)n).getDni())
                es = true;
            return es;
        }
        virtual public bool sosMayor(Comparable n)
        {
            bool es = false;
            if (this.dni > ((Persona)n).getDni())
                es = true;
            return es;
        }
        virtual public bool sosMenor(Comparable n)
        {
            bool es = false;
            if (this.dni < ((Persona)n).getDni())
                es = true;
            return es;
        }
        public override string ToString()
        {
            return (nombre, dni).ToString();
        }
    }
}
