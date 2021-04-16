using PokeBattle.classes;
using System;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pokemon = new PokemonClass();
            pokemon.Name = "pikachu";
            Console.WriteLine(pokemon.Name);
        }
    }
}
