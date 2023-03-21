using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Reply
    {
        [Key]
        public int reply_Id { get; set; }



        public int user_Id { get; set; }
        public int post_Id { get; set; }
        public virtual Post post { get; set; }

        //  public virtual User user { get; set; }


    }
}
