using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using System.Data;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext dataContext) 
        {
            this._context = dataContext;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();        }
    }
}
