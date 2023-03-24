namespace ProjectIntrest.Interface.IInterface
{
    public interface IPost
    {
         int postId { get; set; }
         string text { get; set; }
         string audio { get; set; }
         int? user_Id { get; set; }
    }
}
