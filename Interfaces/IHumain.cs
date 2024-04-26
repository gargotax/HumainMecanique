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
        void MarcherAvecJambeMecanique(JambeMecanique jambesMecaniques);
        BrasMecanique GrefferBras(BrasMecanique brasMecanique);
        JambeMecanique GrefferJambes(JambeMecanique jambesMecaniques);
    }
}
