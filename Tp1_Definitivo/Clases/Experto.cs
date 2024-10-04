using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Experto:Intermedio
    {
        ArrayList Calabozos = new ArrayList();
        
        public Experto(string nombre, int cantJug) : base(nombre, cantJug) 
        {
            Calabozo calabozo1 = new Calabozo(2);
            Calabozos.Add(calabozo1);
            Calabozo calabozo2 = new Calabozo(2);
            Calabozos.Add(calabozo2);
            Calabozo calabozo3 = new Calabozo(2);
            Calabozos.Add(calabozo3);
        }
        public int Posicion(int num) 
        {
            Calabozo calabozo = (Calabozo)Calabozos[num];
            return calabozo.Casillero;
        }
        public override void Jugar()
        {
            base.Jugar();
            for (int i = 0; i < jugadores.Count; i++) 
            {
                Caballero caballero= (Caballero)jugadores[i];
                if (caballero.Turno <= 0)
                {
                    for (int j = 0; j < Calabozos.Count && caballero.Turno <= 0; j++)
                    {
                        foreach (Dragon dragon in Dragones)
                        {
                            Calabozo calabozo = (Calabozo)Calabozos[j];
                            if (calabozo.Posicion() == caballero.Posicion())
                            {
                                caballero.Turno = 1;
                                if (caballero.Posicion() == dragon.Posicion() && caballero.VerTipo() == dragon.VerTipo())
                                {
                                    caballero.Turno = 0;
                                }
                                else if (caballero.Posicion() == dragon.Posicion() && caballero.VerTipo() != dragon.VerTipo())
                                {
                                    jugadores.Remove(caballero);
                                }
                            }
                        }

                    }

                }
                else { caballero.Turno--; }
            }
        }
        public Calabozo VerCalabozo(int num)
        {
            Calabozo jug = null;
            if (num >= 0 && num < Calabozos.Count)
            {
                jug = (Calabozo)Calabozos[num];
            }
            return jug;
        }
    }
}
