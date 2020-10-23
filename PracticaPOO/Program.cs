using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            int p = 100;
            int paut = 4;

            do
            {
                Transporte auto = new Auto(paut);
                Transporte avion = new Avion(p);

                Console.WriteLine("Transporte: " + auto.TipoTransporte() + " {0}", i);
                Console.WriteLine("Acción: " + auto.Avanzar());
                Console.WriteLine("Acción: " + auto.Detener());
                Console.WriteLine();
                Console.WriteLine("Transporte: " + avion.TipoTransporte() + " {0}", i);
                Console.WriteLine("Acción: " + avion.Avanzar());
                Console.WriteLine("Acción: " + avion.Detener());
                Console.WriteLine();

                p = p - 20;
                paut = paut - 1;

                if (paut < 1)
                {
                    paut = 4;
                }

                if (i >= 5)

                    Console.ReadKey();

                i++;

            } while (i <= 5);
        }
    }
}
