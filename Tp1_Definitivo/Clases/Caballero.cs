using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Caballero:Piezas
    {
        public int Turno = 0;
        public int Movimiento { get; set; }
        public bool Gano { get; set; }
        public int Casillero { get { return casillero=41; } }
        public int CasAnt { get; set; }
        public bool Avanza { get; set; }
        public bool Retrocede { get; set; }
        public bool Muere { get; set;}
        public string Nombre { get { return nombre; } }
        private string nombre;
        public Caballero(string nombre, int tipo):base(tipo) 
        {
            this.nombre = nombre;
            casillero = 1;
        }
        public int Posicion() 
        {
            return Casillero  ;
        }
        public override void MoverPieza() 
        {
            Movimiento = jugada.Next(1,7);
            CasAnt = casillero;
            casillero += Movimiento;
            if (casillero > 49) 
            {
                casillero = 50;
                Gano= true;
            }
        }
        public void Avanzar() 
        {
            Avanza = true;
            casillero += 5;
            if (casillero > 49) 
            {
                casillero = 50;
                Gano = true;
            }
        }
        public void Retroceder() 
        {
            Retrocede= true;
            casillero -= 5;
            if (casillero <= 1) 
            {
                casillero = 1;          
            }
        }
        public void MuereJugador() 
        {
            Muere = true;
        }
        public void ReiniciarTurno() 
        {
            Avanza = false;
            Retrocede = false;
        }
        
    }
}
