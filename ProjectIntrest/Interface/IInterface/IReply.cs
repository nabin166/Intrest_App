namespace ProjectIntrest.Interface.IInterface
{
    public interface IReply
    {
         int replyId { get; set; }
         int? user_Id { get; set; }
         int? post_Id { get; set; }
         string reply { get; set; }
    }
}
