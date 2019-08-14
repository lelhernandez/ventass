using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Chiguagua:Perro
    {
        public override void comer()
        {
            CantidadLbsComidas=1;
        }

        public override void Ladrar()
        {
            EstaCorriendo = true;
            VecesLadra = 10;
        }


    }
}
