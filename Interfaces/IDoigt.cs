using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.Interfaces
{
    public interface IDoigt
    {
        public string Materiel { get; }
        public string Revetement { get; }
        int Longueur { get; }

    }
}
