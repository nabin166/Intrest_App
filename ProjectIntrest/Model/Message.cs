using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Message
    {
        [Key]
        public int messageId { get; set; }

        public int? user_Id { get; set; }
        public int receiver { get; set; }


        public string actualMessage { get; set; }
        public string messegeFile { get; set; }

        public DateTime dateTime { get; set; }

        public User user { get; set; }

    }
}
