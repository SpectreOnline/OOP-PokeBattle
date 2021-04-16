using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.classes
{
    public class PokemonClass
    {
        public string Name { get; set; }

        public string NickName { get; set; }

        public string EnergyType { get; set; }

        public int MaxHP { get; set; }

        public int CurrentHP { get; set; }

        public int Speed { get; set; }

        public string Weaknesses { get; set; }

        public string Resistences { get; set; }

        public List<AttackClass> Attacks { get; set; }
    }
}
