using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.Interfaces;
using HumainMecanique.PartiesHumaines;

namespace HumainMecanique.PartiesMecaniques
{
    public class BrasMecanique : Ibras
    {
        public int Longueur { get; }

        public string Materiel { get; }

        public string Revetement { get; }
    }
}
