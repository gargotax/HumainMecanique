using HumainMecanique.ClassesGenerales;
using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class JambeHumaineGauche : Jambe
    {
        public PiedHumainGauche PiedHumainGauche { get; }
        public int Longueur { get; }
    }
}
