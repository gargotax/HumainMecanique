using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.ClassesGenerales
{
    public class Bras : IBras
    {
        public int Longueur { get; }
        public Main Main { get; }
        public string Revetement { get; }

    }
}
