using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.Interfaces
{
    public interface IJambes
    {
        public int Longueur { get; }
        public string Materiel { get; }
        public string Revetement { get; }
    }
}
