using PokeBattle.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Pokemon 
{
    public class PokemonUtility {
        public static List<string> fireResistances = new List<string>(new string[] { "Lightning" });

        public static List<string> fireWeaknesses = new List<string>(new string[] { "Water" });

        public static List<string> lightningResistances = new List<string>(new string[] { "Fighting" });

        public static List<string> lightningWeaknesses = new List<string>(new string[] { "fire" });

        public static EnergyType Fire = new EnergyType("Fire", fireResistances, 10, fireWeaknesses, 2);
        public static EnergyType Lightning = new EnergyType("Lightning", lightningResistances, 20, lightningWeaknesses, 1.5);
        public static EnergyType Fighting = new EnergyType();
        public static EnergyType Water = new EnergyType();

        public static List<AttackClass> CharmeleonAttacks = new List<AttackClass>(new AttackClass[] { new AttackClass("Headbutt", 10, Fighting), new AttackClass("Flare", 30, Fire)});
        public static List<AttackClass> PikachuAttacks = new List<AttackClass>(new AttackClass[] { new AttackClass("Electric Ring", 50, Lightning), new AttackClass("Pika Punch", 20, Fighting) });

        public static List<PokemonClass> PokemonList = CreateStarterPokemon();


        private static List<PokemonClass> CreateStarterPokemon()
        {
            var pokemon = new List<PokemonClass>();

            pokemon.Add(new PokemonClass("Pikachu", "", Lightning, 60, 60, 1, PikachuAttacks));

            pokemon.Add(new PokemonClass("Charmeleon", "", Fire, 60, 60, 1, CharmeleonAttacks));

            return pokemon;
        }

        public static void UpdatePokemon() => PokemonList = CreateStarterPokemon();
    }
        
}