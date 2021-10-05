using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    abstract class JuegoDeCartas
    {
        protected Random rdn = new Random();
        protected Persona ganador;

        public abstract void mezclarmazo();
        public abstract void repartircartas();
        public abstract bool existeganador();
        public abstract void tomarCartas(Persona jugador);
        public abstract void descartarCartas(Persona jugador);
        public Persona jugar(List<Persona> jugador, int rondas)
        {
            int jugadas = 0;
            this.mezclarmazo();
            this.repartircartas();
            while(jugadas < rondas)
            {
                ganador = null;
                while(! this.existeganador())
                {
                    for (int i = 0; i < jugador.Count; i++)
                    {
                        this.tomarCartas(jugador[i]);
                        this.descartarCartas(jugador[i]);
                    }
                }
                Console.WriteLine("El jugador {0} gano la ronda\n", ganador.getNombre());
                rondas--;
            }
            return ganador;
        }
    }
}
