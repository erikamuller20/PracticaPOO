using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public abstract class Transporte
    {
        #region atributos
        private int cantPasajeros;
        #endregion

        #region Constructor
        public Transporte(int cantPasajeros)
        {

            this.cantPasajeros = cantPasajeros;

        }
        #endregion

        #region Metodos publicos
        public int CantPasajeros
        {
            get { return this.cantPasajeros; }
        }

        public abstract string TipoTransporte();

        public virtual string Avanzar()
        {
            return "Avanza";
        }

        public virtual string Detener()
        {
            return "Se detiene";
        }
        #endregion

    }
}
