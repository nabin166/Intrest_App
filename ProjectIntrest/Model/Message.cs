using System.ComponentModel.DataAnnotations;

namespace ProjectIntrest.Model
{
    public class Message
    {
    
        [Key]
        public int messageId { get; set; }

        public int? user_Id { get; set; }
        public int? receiver_Id { get; set; }


        public string actualMessage { get; set; }
        public string messegeFile { get; set; }

        public DateTime dateTime { get; set; }

        public virtual User user { get; set; }

        public virtual User ruser { get; set; }
       
        

    }
}
