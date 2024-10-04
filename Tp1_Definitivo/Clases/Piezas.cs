using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
   
    abstract class Piezas
    {
        protected static Random jugada = new Random();
        protected int casillero;
        protected int tipo;
        public Piezas(int tipo) { this.tipo = tipo; }
        public int VerTipo() { return tipo; }
        abstract public void MoverPieza();
        
    }

}
