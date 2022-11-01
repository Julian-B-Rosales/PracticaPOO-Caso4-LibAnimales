using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimales.Animales
{
    public class Conejo : Animal
    {
        public Conejo(int edad, double altura, double peso) : base(edad, altura, peso)
        {
        }

        public override string ImprimirComida()
        {
            return "Come pasto";
        }
    }
}
