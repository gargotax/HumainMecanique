using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class MainHumaineGauche : IMain
    {
        public DoigtHumainGauche Pouce { get; }
        public DoigtHumainGauche Index { get; }
        public DoigtHumainGauche Majeur { get; }
        public DoigtHumainGauche Annulaire { get; }
        public DoigtHumainGauche Auriculaire { get; }

    }
}
