using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Definitivo
{
    internal class Intermedio:Basico
    {
        protected ArrayList Dragones = new ArrayList();
        Dragon dragon;
        public int CantidadDragones { get { return Dragones.Count; } }
        public Intermedio(string nombre, int cantJug):base(nombre, cantJug) 
        {
            for (int i = -1; i < jugadores.Count - 1; i++) 
            {
                dragon = new Dragon(1);
                Dragones.Add(dragon);
                dragon = new Dragon(1);
                Dragones.Add(dragon);          
            }       
        }
        public override void Jugar()
        {
            base.Jugar();
            foreach(Dragon dragones in Dragones) 
            {
                foreach (Caballero caballero in jugadores) 
                {
                    dragones.MoverPieza();
                    dragones.SituacionDrag(caballero);              
                }
            }
        }
        public Dragon VerDragon(int num) 
        {
            Dragon drag = null;
            if (num >= 0 && num < Dragones.Count) 
            {
                drag=(Dragon)Dragones[num];
            }
            return drag;       
        }

    }
}
