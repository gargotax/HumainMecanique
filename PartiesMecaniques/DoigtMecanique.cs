using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesMecaniques
{
    public class DoigtMecanique:IDoigt
    {
        public string Revetement { get;}
        public string Materiel { get;}
        public int Longueur { get; }
    }
}
