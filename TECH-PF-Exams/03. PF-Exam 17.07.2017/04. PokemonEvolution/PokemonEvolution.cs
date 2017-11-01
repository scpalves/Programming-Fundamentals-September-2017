namespace _04.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonEvolution
    {
        public static void Main()
        {
            var pokemonData = new Dictionary<string, List<KeyValuePair<string, long>>>();

            while (true)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "wubbalubbadubdub")
                {
                    break;
                }

                string pokemonName = inputTokens[0];

                if (inputTokens.Length != 1)
                {
                    string pokemonType = inputTokens[1];
                    long pokemonPower = long.Parse(inputTokens[2]);
                    AddToPokemonData(pokemonData, pokemonName, pokemonType, pokemonPower);
                }
                else
                {
                    PrintingCurrentPokemonNameData(pokemonData, pokemonName);
                }
            }
            PrintingFinalPokemonData(pokemonData);
        }

        private static void PrintingCurrentPokemonNameData(Dictionary<string, List<KeyValuePair<string, long>>> pokemonData, string pokemonName)
        {
            if (pokemonData.ContainsKey(pokemonName))
            {
                Console.WriteLine($"# {pokemonName}");
                foreach (var pokemonTypesAndPower in pokemonData[pokemonName])
                {
                    string pokeType = pokemonTypesAndPower.Key;
                    long pokePower = pokemonTypesAndPower.Value;
                    Console.WriteLine($"{pokeType} <-> {pokePower}");
                }
            }
        }

        private static void PrintingFinalPokemonData(Dictionary<string, List<KeyValuePair<string, long>>> pokemonData)
        {
            foreach (var pokemonNameAndMoreData in pokemonData)
            {
                string pokemonName = pokemonNameAndMoreData.Key;
                var pokemonTypesAndPowers = pokemonNameAndMoreData.Value;
                Console.WriteLine($"# {pokemonName}");

                foreach (var pokemonTypesAndPower in pokemonTypesAndPowers
                    .OrderByDescending(x => x.Value))
                {
                    string type = pokemonTypesAndPower.Key;
                    long power = pokemonTypesAndPower.Value;
                    Console.WriteLine($"{type} <-> {power}");
                }
            }
        }

        public static void AddToPokemonData(Dictionary<string, List<KeyValuePair<string, long>>> pokemonData,
            string pokemonName, string pokemonType, long pokemonPower)
        {
            if (!pokemonData.ContainsKey(pokemonName))
            {
                pokemonData.Add(pokemonName, new List<KeyValuePair<string, long>>());
            }
            pokemonData[pokemonName].Add(new KeyValuePair<string, long>(pokemonType, pokemonPower));
        }
    }
}
