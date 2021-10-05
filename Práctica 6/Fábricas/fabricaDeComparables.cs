using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    abstract class fabricaDeComparables : FabricaDeComparables
    {
        private const int ALUMNOS = 1;
        private const int ALUMNOS_MUY_ESTUDIOSOS = 2;
        private const int ALUMNO_COMPUESTO = 3;
        private const int NUMEROS = 4;
        private const int VENDEDORES = 5;

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();

        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case ALUMNOS:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case NUMEROS:
                    fabrica = new FabricaDeNumeros();
                    break;
                case VENDEDORES:
                    fabrica = new FabricaDeVendedores();
                    break;
                case ALUMNOS_MUY_ESTUDIOSOS:
                    fabrica = new FabricaDeAlumnosEstudiosos();
                    break;
                case ALUMNO_COMPUESTO:
                    fabrica = new FabricaDeAlumnosCompuestos();
                    break;
                default:
                    break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case ALUMNOS:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case NUMEROS:
                    fabrica = new FabricaDeNumeros();
                    break;
                case VENDEDORES:
                    fabrica = new FabricaDeVendedores();
                    break;
                case ALUMNOS_MUY_ESTUDIOSOS:
                    fabrica = new FabricaDeAlumnosEstudiosos();
                    break;
                case ALUMNO_COMPUESTO:
                    fabrica = new FabricaDeAlumnosCompuestos();
                    break;
                default:
                    break;
            }
            return fabrica.crearPorTeclado();
        }

    }
}
