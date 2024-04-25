using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesMecaniques
{
    public class PiedMecanique : IPied
    {
        OrteilMecanique Un { get; }
        OrteilMecanique Deux { get; }
        OrteilMecanique Trois { get; }
        OrteilMecanique Quatre { get; }
        OrteilMecanique Cinq { get; }

        public string Revetement { get; }

        public string Materiel { get; }
    }
}
