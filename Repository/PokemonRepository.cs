using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using System.Data;
using PokemonReviewApp.Interfaces;
using System.Linq;
namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext dataContext) 
        {
            this._context = dataContext;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string pokemon)
        {
            return _context.Pokemon.Where(p => p.Name == pokemon).FirstOrDefault();
        }

        public decimal GetPokemonRatings(int pokeId)
        {
            var reviews = _context.Reviews.Where(r => r.Pokemon.Id == pokeId);

            if (reviews.Count() <= 0)
                return 0;

            return((decimal)reviews.Sum(r => r.Rating) / reviews.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExists(int pokemonId)
        {
            return _context.Pokemon.Any(p => p.Id == pokemonId);
        }
    }
}
