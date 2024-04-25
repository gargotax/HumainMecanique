using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class MainHumaine :IMain
    {
        public DoigtHumain Pouce { get; }
        public DoigtHumain Index { get; }
        public DoigtHumain Majeur { get; }
        public DoigtHumain Annulaire { get; }
        public DoigtHumain Auriculaire { get; }

        public string Revetement { get; }

        public string Materiel { get; }
    }
}
