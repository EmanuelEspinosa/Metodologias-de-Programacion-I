using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class ProxyAlumno : IAlumno
    {
        private IAlumno alumnoReal = null;
        private string nombre;
        private int legajo, opcion;
        private IComparisonStrategy estrategia;

        public ProxyAlumno(string nombre, int legajo, int opcion)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.opcion = opcion;
            this.estrategia = new ComparacionPorLegajo();
        }

        public int getCalificación()
        {
            return alumnoReal.getCalificación();
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string mostrarCalificación()
        {
            return alumnoReal.mostrarCalificación();
        }

        public int responderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                if (opcion == 1)
                {
                    Console.Write("Instanciando a un Alumno:");
                    alumnoReal = (IAlumno)fabricaDeComparables.crearAleatorio(1);
                }

                if (opcion == 2)
                {
                    Console.Write("Instanciando a un Alumno muy estudioso:");
                    alumnoReal = (IAlumno)fabricaDeComparables.crearAleatorio(2);
                }

            }
            return alumnoReal.responderPregunta(pregunta);
        }

        public void setCalificación(int calif)
        {
            alumnoReal.setCalificación(calif);
        }

        public bool sosIgual(Comparable n)
        {
            return estrategia.EsIgual(this,n);
        }

        public bool sosMayor(Comparable n)
        {
            return estrategia.EsMayor(this, n);
        }

        public bool sosMenor(Comparable n)
        {
            return estrategia.EsMenor(this, n);
        }
        public override string ToString()
        {
            return string.Format("[Nombre: {0}, Legajo: {1}",nombre,legajo);
        }
    }
}
