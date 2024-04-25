using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class OrteilHumain : IOrteil
    {

        public string Longueur { get; }

        public string Materiel { get; }

        public string Revetement { get; }
    }
}
