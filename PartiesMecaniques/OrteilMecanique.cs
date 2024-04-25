using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesMecaniques
{
    public class OrteilMecanique : IOrteil
    {
        public string Longueur { get; }

        public string Materiel { get; }

        public string Revetement { get; }
    }
}
