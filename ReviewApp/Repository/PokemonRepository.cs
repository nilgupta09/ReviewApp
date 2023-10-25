
using ReviewApp.Data;
using ReviewApp.Models;

namespace ReviewApp.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p =>p.Id).ToList();
        }
    }
}
