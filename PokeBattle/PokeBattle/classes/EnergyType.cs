using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle.classes
{
    public class EnergyType
    {
        public string Name { get; set; }

        public List<string> Resistances { get; set; }

        public int ResistanceValue { get; set; }

        public List<string> Weaknesses { get; set; }

        public double WeaknessMultiplier { get; set; }

        public EnergyType() { }

        public EnergyType(string name, List<string> resistances, int resistancevalue , List<string> weaknesses, double weaknessmultiplier) {
            Name = name;

            Resistances = resistances;

            ResistanceValue = resistancevalue;

            Weaknesses = weaknesses;

            WeaknessMultiplier = weaknessmultiplier;
        
        }
    }
}
