namespace ProjectIntrest.Interface.IInterface
{
    public interface IUser
    {
         int userId { get; set; }
        
        string photo { get; set; }
       
        string avatarPhoto { get; set; }
        
        string nickName { get; set; }
        
         string fullName { get; set; }
      
         int phoneNo { get; set; }
        
         DateTime dateTime { get; set; }
    }
}
