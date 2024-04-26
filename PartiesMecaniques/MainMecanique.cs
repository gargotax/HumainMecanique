using HumainMecanique.ClassesGenerales;
using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.PartiesMecaniques
{
    public class MainMecanique: Main
    {
        public DoigtMecanique Un { get; }
        public DoigtMecanique Deux { get; }

        public DoigtMecanique Trois { get; }

        public DoigtMecanique Quatre { get; }

        public DoigtMecanique Cinq { get; }

        public string Revetement { get; }

        public string Materiel { get; }
    }
}
