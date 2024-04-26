using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class PiedHumainGauche : IPied
    {
        public int Pointure { get; }
        OrteilHumainGauche Un { get; }
        OrteilHumainGauche Deux { get; }

        OrteilHumainGauche Trois { get; }

        OrteilHumainGauche Quatre { get; }

        OrteilHumainGauche Cinq { get; }

    }
}
