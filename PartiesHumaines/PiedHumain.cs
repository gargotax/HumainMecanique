using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class PiedHumain:IPied
    {
        public OrteilHumain Un { get; }
        public OrteilHumain Deux { get; }
        public OrteilHumain Trois { get; }
        public OrteilHumain Quattre { get; }
        public OrteilHumain Cinq { get; }

        public string Revetement { get; }

        public string Materiel { get; }
    }
}
