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

        public List<string> Weaknesses { get; set; }
    }
}
