using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Avion : Transporte
    {

        public Avion(int cantPasajeros): base(cantPasajeros)
        {
        }

        public override string TipoTransporte()
        {
            return "Avion ";
        }

        public override string Avanzar()
        {
            return base.Avanzar() + " con " + this.CantPasajeros + " pasajeros";
        }

        public override string Detener()
        {
            return base.Detener() + " con " + this.CantPasajeros + " pasajeros";
        }

    }
}
