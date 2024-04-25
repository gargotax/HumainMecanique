using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesMecaniques
{
    public class JambesMecaniques : IJambes
    {
        public PiedMecanique PiedMecaniqueGauche { get;  }
        public PiedMecanique PiedMecaniqueDroit { get; }
        public int Longueur { get; }
        public string Materiel { get; }
        public string Revetement { get; }
    }
}
