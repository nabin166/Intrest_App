using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Follower
    {
        [Key]
        public int followerId { get; set; }

        public int? user_Id { get; set; }
        public int followedTo { get; set; }

        public User user { get; set; }
    }
}
