using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Calabozo:Piezas
    {
        public int Casillero { get { return casillero; } }
        public Calabozo(int tipo):base(tipo)
        {
           casillero=jugada.Next(2, 50);
        }
        public override void MoverPieza()
        {
        }
        public int Posicion() 
        {
            return Casillero;
        }
    }
}
