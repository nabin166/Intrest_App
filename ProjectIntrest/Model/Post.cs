using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Post
    {
        public Post()
        {
            pins = new HashSet<Pin>();
            replies = new HashSet<Reply>();
        }

        [Key]
        public int postId { get; set; }

        public string text { get; set; }

        public string audio { get; set; }

        
        public int user_Id { get; set; }
        public virtual User user { get; set; }

        public virtual ICollection<Pin> pins { get; set; }
        public virtual ICollection<Reply> replies { get; set; }

    }
}
