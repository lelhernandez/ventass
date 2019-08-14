using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Perro : Mamifero
    {
        public bool EstaCorriendo { get; set; }
        public int VecesLadra { get; set; }
        public int CantidadLbsComidas { get; set; }
        public Perro()
        {
            Patas = 4;
        }
        public string Raza { get; set; }

        public abstract void Ladrar();

    }
}
