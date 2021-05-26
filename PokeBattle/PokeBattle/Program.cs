using PokeBattle.classes;
using Utilities.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            readUserInput();

        }
        //This method asks an input from the user and then assigns the input as the nickname of the selected pokemon
        static void readUserInput()
        {
            foreach (var pokemon in PokemonUtility.PokemonList)
            {
                Console.WriteLine("Would you like to nickname " + pokemon.Name + "? Y / N");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse == "y")
                {
                    Console.WriteLine("What would you like your nickname for " + pokemon.Name + " to be?");
                    string newPokemonNickname = Console.ReadLine();
                    pokemon.NickName = newPokemonNickname;

                    Console.WriteLine("Alright " + pokemon.Name + " now has the nickname " + pokemon.NickName);
                }
                else
                {
                    Console.WriteLine("Alright " + pokemon.Name + " shall keep their normal name");
                }

            }
            pokemonFightSequence();
        }
        //This method plays out a fight sequence using contructed method that are present withing the pokemonclass
        static void pokemonFightSequence()
        {

            PokemonClass pikachu = PokemonUtility.PokemonList.Where(pokemon => pokemon.Name == "Pikachu").FirstOrDefault();

            PokemonClass charmeleon = PokemonUtility.PokemonList.Where(pokemon => pokemon.Name == "Charmeleon").FirstOrDefault();

            AttackClass electricRing = PokemonUtility.PikachuAttacks.Where(attack => attack.Name == "Electric Ring").FirstOrDefault();

            AttackClass flare = PokemonUtility.CharmeleonAttacks.Where(attack => attack.Name == "Flare").FirstOrDefault();

            Console.WriteLine(pikachu.Damage(charmeleon, electricRing));

            Console.WriteLine(charmeleon.Damage(pikachu, flare));

            getPopulation();

        }

        //The method fetches and writes down that are currently alive with their HP
        static void getPopulation() {

            foreach (PokemonClass alivePokemon in PokemonUtility.PokemonList.Where(pokemon => pokemon.CurrentHP > 0))
            {
                Console.WriteLine(alivePokemon.Name + " is currently alive and has " + alivePokemon.CurrentHP + " HP left");
            }
         
        }

    }
}
