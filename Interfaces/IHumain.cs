using HumainMecanique.PartiesMecaniques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique.Interfaces
{
    public interface IHumain
    {
        Ibras Ibras { get; }
        IJambes IJambes { get; }
        IMain IMain { get; }
        IDoigt IDoigt { get; }
        IOrteil IOrteil { get; }
        void MarcherAvecJambeMecanique(JambesMecaniques jambesMecaniques);
        BrasMecanique GrefferBras(BrasMecanique brasMecanique);
        JambesMecaniques GrefferJambes(JambesMecaniques jambesMecaniques);
    }
}
