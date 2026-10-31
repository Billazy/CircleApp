namespace CircleApp.Data.Models
{

    // Represents a report made by a user on a post
    // Simalar to a "like" or "favorite"
    public class Report
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

        public int PostId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public Post Post { get; set; }
        public User User { get; set; }
    }
}