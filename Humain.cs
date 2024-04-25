using HumainMecanique.Interfaces;
using HumainMecanique.PartiesMecaniques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique
{
    public class Humain : IHumain
    {
        public Ibras Ibras { get; }

        public IJambes IJambes { get; }

        public IMain IMain { get; }

        public IDoigt IDoigt { get; }

        public IOrteil IOrteil { get; }

        public BrasMecanique GrefferBras(BrasMecanique brasMecanique)
        {
            return new BrasMecanique();
        }
        public void MarcherAvecJambeMecanique(JambesMecaniques jambesMecaniques)
        {
            throw new NotImplementedException();
        }
        public JambesMecaniques GrefferJambes(JambesMecaniques jambesMecaniques)
        {
            throw new NotImplementedException();
        }
    }
}
