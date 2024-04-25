using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesHumaines
{
    public class DoigtHumain : IDoigt
    {
        public string Materiel { get; }

        public int Longueur { get; }

        public string Revetement { get; }
    }
}
