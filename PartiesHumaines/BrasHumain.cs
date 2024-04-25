using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesHumaines
{
    public class BrasHumain:Ibras
    {
        public int Longueur { get; }
        public MainHumaine MainGauche { get; }
        public MainHumaine MainDroite { get; }

        public string Materiel => throw new NotImplementedException();

        public string Revetement => throw new NotImplementedException();
    }
}
