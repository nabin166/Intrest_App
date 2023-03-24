namespace ProjectIntrest.Interface.IInterface
{
    public interface IIntrestDbContext
    {
        IUser user { get; }
        IPin pin { get; }
        IReply reply { get; }
        IPost post { get; }
        IMessage message { get; }
        IIntrest intrest  { get; }
        IIntrestCategory category { get; }
        IFollower follower { get; }

        /*public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<IntrestsCategory> IntrestsCategories { get; set; } = null!;
        public virtual DbSet<Intrest> Intrests { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Pin> Pins { get; set; } = null!;
        public virtual DbSet<Reply> Replies { get; set; } = null!;
        public virtual DbSet<Follower> Followers { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;*/

    }
}
