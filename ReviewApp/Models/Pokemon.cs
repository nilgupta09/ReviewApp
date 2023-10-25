namespace ReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Review> Reviews { get; set; }
<<<<<<< HEAD
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
=======
>>>>>>> 314928b89da248f26f567ca35a001016bb415ec8
    }
}
