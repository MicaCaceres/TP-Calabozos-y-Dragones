using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Dragon : Piezas
    {
        public int Casillero { get { return casillero; } }
        public override void MoverPieza()
        {
            casillero = jugada.Next(2, 50);
        }
        public Dragon(int tipo) : base(tipo)
        {
            casillero = 0;
        }
        public int Posicion()
        {
            return Casillero;
        }
        public void SituacionDrag(Caballero caballero)
        {
            if (this.casillero == caballero.Posicion())
            {
                if (tipo == caballero.VerTipo())
                {
                    caballero.Avanzar();

                }
                else
                {
                    caballero.Retroceder();

                }

            }
        }
    }
}
