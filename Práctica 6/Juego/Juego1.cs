using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_6
{
    class Juego1 : JuegoDeCartas
    {
        public override void descartarCartas(Persona jugador)
        {
            int cartasDelJuegador = rdn.Next(1, 12);
            Console.WriteLine($"El jugador {jugador.getNombre()} descarto {cartasDelJuegador} cartas: ");
            if(cartasDelJuegador > 2)
            {
                ganador = jugador;
            }
        }

        public override bool existeganador()
        {
            if (ganador != null)
                return true;
            else
                return false;
        }

        public override void mezclarmazo()
        {
            Console.WriteLine("<<< Mezclando el mazo >>>");
        }

        public override void repartircartas()
        {
            Console.WriteLine("<<< Repartiendo cartas >>>");
        }

        public override void tomarCartas(Persona jugador)
        {
            Console.WriteLine($"El juegador {jugador.getNombre()} tomo una carta");
        }
    }
}
