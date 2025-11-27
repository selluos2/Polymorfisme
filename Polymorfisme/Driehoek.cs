using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    public class Driehoek : Vorm
    {
        public int Hoogte { get; set; }
        public int Basis { get; set; }

        public Driehoek(string name, int hoogte, int basis)
        {
            Name = name;
            Hoogte = hoogte;
            Basis = basis;
        }

        public override double BerekenOppervlakte()
        {
            return (Basis * Hoogte) / 2.0;
        }

        public override double BerekenOmtrek()
        {
            return Hoogte + Basis + Math.Sqrt((Basis * Basis) + (Hoogte * Hoogte));
        }
    }
}
