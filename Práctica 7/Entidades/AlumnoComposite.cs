using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    class AlumnoComposite : IAlumno
    {
         List<IAlumno> listaAlum = new List<IAlumno>();

        public List<IAlumno> getLista()
        {
            return listaAlum;
        }
        public void AddAlum(IAlumno alum)
        {
            listaAlum.Add(alum);
        }

        public void RemoveAlum(IAlumno alum)
        {
            listaAlum.Remove(alum);
        }

        public int getCalificación()
        {
            return 0;
        }

        public int getLegajo()
        {
            return 0;
        }

        public string getNombre()
        {
            string nombre = null;

            foreach (IAlumno item in listaAlum)
            {
                nombre += item.getNombre() + " ";
            }
            return nombre;
        }

        public string mostrarCalificación()
        {
            string calificacion = null;
            foreach (IAlumno item in listaAlum)
                calificacion += item.getCalificación();
            return calificacion;
        }

        public int responderPregunta(int pregunta)
        {
            /*La posición 0 del arreglo : Respuesta 1*/
            /*La posición 1 del arreglo : Respuesta 2*/
            /*La posición 2 del arreglo : Respuesta 3*/
            int resp1 = 0, resp2 = 0, resp3 = 0, respFinal = 0, max = 0;
            Random rdn = new Random();
            
            foreach (IAlumno item in listaAlum)
            {
                int respuesta = item.responderPregunta(pregunta);
                if (respuesta == 1)
                    resp1++;
                if (respuesta == 2)
                    resp2++;
                if (respuesta == 3)
                    resp3++;
            }
            int[] vot = new int[3] { resp1, resp2, resp3 };

            /*Se obtiene la respuesta mas votada*/
            for (int i = 0; i < vot.Length; i++)
            {
                if (vot[i] > max)
                {
                    max = vot[i];
                    //respFinal = max;
                }
            }
            if (max == vot[0])
                respFinal = 1;
            if (max == vot[1])
                respFinal = 2;
            if (max == vot[2])
                respFinal = 3;

            return respFinal;
        }

        public void setCalificación(int calif)
        {
            foreach (IAlumno item in listaAlum) 
                item.setCalificación(calif);
        }

        public bool sosIgual(Comparable n)
        {
            bool flag = false;
            foreach (IAlumno item in listaAlum)
            {
                if (item.sosIgual(n))
                    flag = true;
            }
            return flag;
        }

        public bool sosMayor(Comparable n)
        {
            bool flag = false;
            foreach (IAlumno item in listaAlum)
            {
                if (item.sosMayor(n))
                    flag = true;
            }
            return flag;
        }

        public bool sosMenor(Comparable n)
        {
            bool flag = false;
            foreach (IAlumno item in listaAlum)
            {
                if (item.sosMenor(n))
                    flag = true;
            }
            return flag;
        }
    }
}
