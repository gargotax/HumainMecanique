using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesHumaines
{
    public class BrasHumainDroit : IBras
    {
        public int Longueur { get; }
        public MainHumaineDroite MainHumaineDroite { get; }
    }
}
