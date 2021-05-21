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

        public EnergyType EnergyType { get; set; }

        public int MaxHP { get; set; }

        public int CurrentHP { get; set; }

        public int Speed { get; set; }

        public List<AttackClass> Attacks { get; set; }

        public PokemonClass() { }

        public PokemonClass(string name, string nickname, EnergyType energytype, int maxhp, int currenthp, int speed, List<AttackClass> attacks)
        {
            Name = name;

            NickName = nickname;

            EnergyType = energytype;

            MaxHP = maxhp;

            CurrentHP = currenthp;

            Speed = speed;

            Attacks = attacks;
        }
    }
}
