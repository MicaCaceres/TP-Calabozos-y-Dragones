using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Basico
    {
        protected ArrayList jugadores = new ArrayList();
        public int CantJugadores { get {return jugadores.Count; } }
        
        public Basico(string nombre, int cantJug) 
        {
            jugadores.Add( new Caballero(nombre,-1));
            for(int i = 0;i<cantJug ; i++) 
            {
                jugadores.Add(new Caballero("Caballero" + AsignarColor(i + 1),i));
            }
        }
        public string AsignarColor(int num) 
        {
            string color="";
            switch (num) 
            {
                case 1: color = "Rojo";
                break;
                case 2: color = "Rosa";
                    break;
                case 3: color = "Verde"; 
                    break;
            }
            return color;
        }
        public virtual void Jugar() 
        {
            foreach(Caballero jugador in jugadores)
            {
                if (jugador.Turno < 1) 
                {
                    jugador.MoverPieza();
                } 
            }
        }
        public bool HayGanador() 
        {
            bool hayganador = false;
            foreach(Caballero jugador in jugadores) 
            {
                if (jugador.Posicion() >= 50) 
                {
                    hayganador = true;
                }
            }
            return hayganador;

        }
        public Caballero VerCaballero(int num) 
        {
            Caballero jugador = null;
            if (num >= 0 && num < jugadores.Count) 
            {

                jugador = (Caballero)jugadores[num];
            }
            return jugador;       
        }

    }
}
