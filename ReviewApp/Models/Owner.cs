using System.Diagnostics.Metrics;

namespace ReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
=======
        public string Name { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
>>>>>>> 314928b89da248f26f567ca35a001016bb415ec8
    }
}
