using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.classes
{
    public class AttackClass
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public EnergyType Energytype { get; set; }

        public int Priority { get; set; }

        public AttackClass() { }

        public AttackClass(string name, int damage, EnergyType energytype, int priority = 1) 
        {
            Name = name;

            Damage = damage;

            Energytype = energytype;

            Priority = priority;
        }
    }
}
