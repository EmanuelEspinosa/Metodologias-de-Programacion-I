using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_5
{
    interface IAlumno : Comparable
    {
        string mostrarCalificación();
        void setCalificación(int calif);
        int responderPregunta(int pregunta);
        string getNombre();
        int getLegajo();
        int getCalificación();


    }
}
