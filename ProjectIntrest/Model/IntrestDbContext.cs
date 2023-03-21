using Microsoft.EntityFrameworkCore;

namespace ProjectIntrest.Model
{
    public partial class IntrestDbContext : DbContext
    {
        public IntrestDbContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<IntrestsCategory> IntrestsCategories { get; set; } = null!;
        public virtual DbSet<Intrest> Intrests { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Pin> Pins { get; set; } = null!;
        public virtual DbSet<Reply> Replies { get; set; } = null!;
        public virtual DbSet<Follower> Followers { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server= DESKTOP-SC4NGQA\\SQLEXPRESS;Database=Intrest;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<IntrestsCategory>(entity =>
            {
                entity.ToTable("IntrestsCategory");
                entity.HasOne(p => p.user)
                .WithMany(e => e.intrestCategories)
                .HasForeignKey(m => m.user_Id);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");
                entity.HasOne(p => p.user)
                .WithMany(e => e.posts)
                .HasForeignKey(m => m.user_Id);
            });
            modelBuilder.Entity<Pin>(entity =>
            {
                entity.ToTable("Pin");

               /* entity.HasOne(p => p.user)
                .WithMany(e => e.pins)
                .HasForeignKey(m => m.user_Id);*/

                entity.HasOne(p => p.post)
                .WithMany(e => e.pins)
                .HasForeignKey(m => m.post_Id);
            });

            modelBuilder.Entity<Reply>(entity =>
            {
                entity.ToTable("Reply");
            /*    entity.HasOne(p => p.user)
                .WithMany(e => e.replies)
                .HasForeignKey(m => m.user_Id);*/

                entity.HasOne(p => p.post)
                .WithMany(e => e.replies)
                .HasForeignKey(m => m.post_Id);
           
            });
            modelBuilder.Entity<Intrest>(entity =>
            {
                entity.ToTable("Intrest");
                entity.HasOne(p => p.intrestsCategorie)
                .WithMany(e => e.intrests)
                .HasForeignKey(m => m.intrestCategory_Id);


            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");
                entity.HasOne(p => p.user)
                .WithMany(e => e.messages)
                .HasForeignKey(m => m.user_Id);


            });

            modelBuilder.Entity<Follower>(entity =>
            {
                entity.ToTable("Follower");
                entity.HasOne(p => p.user)
                .WithMany(e => e. )
                .HasForeignKey(m => m.user_Id);


            });

            OnModelCreatingPartial(modelBuilder);
            }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
