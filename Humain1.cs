using HumainMecanique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumainMecanique
{
    public class Humain1 : IHumain
    {
        public Ibras Ibras { get; }

        public IJambes IJambes { get; }

        public IMain IMain { get; }

        public IDoigt IDoigt { get; }

        public IOrteil IOrteil { get; }

        public void GrefferBras()
        {
            throw new NotImplementedException();
        }

        public void GrefferJambes()
        {
            throw new NotImplementedException();
        }

        public void MarcherAvecJambeMecanique()
        {
            throw new NotImplementedException();
        }
    }
}
