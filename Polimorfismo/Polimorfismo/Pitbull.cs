using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Pitbull : Perro
    {
        public override void comer()
        {
            CantidadLbsComidas = 5;
        }

        public override void Ladrar()
        {
            EstaCorriendo = false;
            VecesLadra = 4;
        }

        public void Pelear()
        {

        }
    }
}
