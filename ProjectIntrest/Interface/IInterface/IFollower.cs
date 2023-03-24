namespace ProjectIntrest.Interface.IInterface
{
    public interface IFollower
    {
         int followerId { get; set; }

         int? user_Id { get; set; }
         int? followed_Id { get; set; }
    }
}
