using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_3
{
    class Gerente : Persona, observador
    {
        private Coleccionable mejores;
        private int IDsucursal;

        public Gerente(string nombre, int dni, int IDsucursal) : base(nombre,dni)
        {
            this.IDsucursal = IDsucursal;
            mejores = new Cola();
        }
        public void venta(double monto, Vendedor vendedor)
        {
            if(monto > 5000)
            {
                if (!mejores.contiene(vendedor))
                    mejores.agregar(vendedor);
                vendedor.aumentoBonus();
            }
        }
        public void cerrar()
        {
            Iterador it = ((Iterable)mejores).crearIterador();
            while(! it.fin())
            {
                Console.WriteLine(it.actual());
                it.siguiente();
            }
        }
        public void actualizar(observado o)
        {
            double monto = ((Vendedor)o).getMonto();
            venta(monto, ((Vendedor)o));
        }
    }
}
