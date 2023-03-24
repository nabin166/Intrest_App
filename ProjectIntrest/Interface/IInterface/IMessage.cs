namespace ProjectIntrest.Interface.IInterface
{
    public interface IMessage
    {
         int messageId { get; set; }

         int? user_Id { get; set; }
         int? receiver_Id { get; set; }


         string actualMessage { get; set; }
         string messegeFile { get; set; }

          DateTime dateTime { get; set; }
    }
}
