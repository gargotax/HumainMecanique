using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesHumaines
{
    public class BrasHumainGauche:IBras
    {
        public int Longueur { get; }
        public MainHumaineGauche MainGauche { get; }

    }
}
