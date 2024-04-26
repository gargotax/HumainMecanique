using HumainMecanique.ClassesGenerales;
using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class PiedHumain : Pied
    {
        public int Pointure { get; }

        public OrteilHumainDroit Un { get; }
        public OrteilHumainDroit Deux { get; }
        public OrteilHumainDroit Trois { get; }
        public OrteilHumainDroit Quattre { get; }
        public OrteilHumainDroit Cinq { get; }

    }
}
