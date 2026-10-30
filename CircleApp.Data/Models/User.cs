namespace CircleApp.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        //public string? ProfileImageUrl { get; set; }
        
        //L'initialiseur = string.Empty donne une chaîne vide par défaut aux nouveaux objets.
        public string ProfilePictureUrl { get; set; } = string.Empty;

        // Navigation properties for the likes made by the user
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        //public string ProfilePictureUrl { get; internal set; }
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}
