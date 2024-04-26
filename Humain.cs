using HumainMecanique.Interfaces;
using HumainMecanique.PartiesHumaines;
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
        public string Name { get; }
        public JambeHumaineDroite JambeHumaineDroite { get; } = new JambeHumaineDroite();
        public JambeHumaineGauche JambeHumaineGauche { get; } = new JambeHumaineGauche();
        public BrasHumainDroit BrasHumainDroit { get; } = new BrasHumainDroit();
        public BrasHumainGauche BrasHumainGauche { get; } = new BrasHumainGauche();
        public Humain(string name)
        {
            Name = name;
        }
        public BrasMecanique GrefferBras(BrasMecanique brasMecanique)
        {
            return new BrasMecanique();
        }
        public void MarcherAvecJambeMecanique(JambeMecanique jambesMecaniques)
        {
            throw new NotImplementedException();
        }
        public JambeMecanique GrefferJambes(JambeMecanique jambesMecaniques)
        {
            throw new NotImplementedException();
        }
    }
}
