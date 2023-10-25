namespace ReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public int Rating { get; set; }
=======
>>>>>>> 314928b89da248f26f567ca35a001016bb415ec8
        public string Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon{ get; set; }
    }
}
