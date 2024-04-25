using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class JambesHumaines : IJambes
    {
        public PiedHumain PiedGauche { get; }
        public PiedHumain PiedDroit { get; }

        public int Longueur { get; }

        public string Materiel { get; }

        public string Revetement { get; }
    }
}
