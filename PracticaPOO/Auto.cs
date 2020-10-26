using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Auto : Transporte
    {
        public Auto(int cantPasajeros) : base(cantPasajeros)
        {
        }

        public override string TipoTransporte()
        {
            return "Auto ";
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
