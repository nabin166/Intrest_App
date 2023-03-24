using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class User
    {
        public User()
        {
            intrestCategories = new HashSet<IntrestsCategory>();
            posts = new HashSet<Post>();
            messages = new HashSet<Message>();
            rmessages = new HashSet<Message>();
            followers = new HashSet<Follower>();
            ffollowers = new HashSet<Follower>();
            pins = new HashSet<Pin>();
            replies = new HashSet<Reply>();
         
        }

        [Key]
        public int userId { get; set; }
        [Required]
        public string photo { get; set; }
        [Required]
        public string avatarPhoto { get; set; }
        [Required]
        public string nickName { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public int phoneNo { get; set; }
        [Required]
        public DateTime dateTime { get; set; }

        public virtual ICollection<IntrestsCategory> intrestCategories { get; set; }
        public virtual ICollection<Post> posts { get; set; }
        public virtual ICollection<Message> messages { get; set; }

        public virtual ICollection<Message> rmessages { get; set; }
        public virtual ICollection<Follower> followers { get; set; }
        public virtual ICollection<Follower> ffollowers { get; set; }

        public virtual ICollection<Pin> pins { get; set; }
        public virtual ICollection<Reply> replies { get; set; }
    
    }
}
