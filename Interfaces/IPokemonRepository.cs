﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string pokemon);
        decimal GetPokemonRatings(int pokeId);
        bool PokemonExists(int pokemonId);

    }
}
