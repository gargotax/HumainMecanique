using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HumainMecanique.ClassesGenerales;
using HumainMecanique.Interfaces;

namespace HumainMecanique.PartiesMecaniques
{
    public class BrasMecanique : Bras
    {
        public int Longueur { get; }

        public string Revetement { get; }
    }
}
