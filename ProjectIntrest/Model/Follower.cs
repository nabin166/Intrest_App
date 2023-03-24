using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Follower
    {
   
        [Key]
        public int followerId { get; set; }

        public int? user_Id { get; set; }
        public int? followed_Id { get; set; }

        public virtual User user { get; set; }
        public virtual User fuser { get; set; }

        


    }
}
