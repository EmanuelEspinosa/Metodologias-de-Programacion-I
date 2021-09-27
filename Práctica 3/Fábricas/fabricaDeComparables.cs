using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    abstract class fabricaDeComparables : FabricaDeComparables
    {
        private const int ALUMNOS = 1;
        private const int NUMEROS = 2;
        private const int VENDEDORES = 3;

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
                default:
                    break;
            }
            return fabrica.crearPorTeclado();
        }

    }
}
