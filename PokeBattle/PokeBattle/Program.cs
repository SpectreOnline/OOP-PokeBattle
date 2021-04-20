using PokeBattle.classes;
using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int questionNum = 0;
            string pokemonNickname = "";
            string selectedPokemon = askPokemonQuestion(questionNum).ToLower();
            questionNum++;

            string hasNickname = askPokemonQuestion(questionNum).ToLower();
            questionNum++;

            if (hasNickname == "yes")
            {
                pokemonNickname = askPokemonQuestion(questionNum).ToLower();
                questionNum++;
            }

            var pokemon = new PokemonClass();
            pokemon.Name = selectedPokemon;
            Console.WriteLine(pokemon.Name);

            Console.WriteLine("Does it have a nickname? \n" + hasNickname);
            if (hasNickname == "yes") {
                pokemon.NickName = pokemonNickname;
                Console.WriteLine(pokemon.NickName);
            }
            
            
        }

        static string askPokemonQuestion(int questionNum)
        {
            string[] userInputQuestion = {
            "Please select a pokemon",
            "Would you like to give them a nickname?",
            "What would you like their nickname to be?",
            };
            Console.WriteLine(userInputQuestion[questionNum]);
            string userResponse = Console.ReadLine();

            return userResponse;
        }
    }
}
