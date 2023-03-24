using ProjectIntrest.Interface.IInterface;

namespace ProjectIntrest.Interface.IImplement
{
    public class IntrestDbContext : IIntrestDbContext
    {
        public IUser user => throw new NotImplementedException();

        public IPin pin => throw new NotImplementedException();

        public IReply reply => throw new NotImplementedException();

        public IPost post => throw new NotImplementedException();

        public IMessage message => throw new NotImplementedException();

        public IIntrest intrest => throw new NotImplementedException();

        public IIntrestCategory category => throw new NotImplementedException();

        public IFollower follower => throw new NotImplementedException();
    }
}
