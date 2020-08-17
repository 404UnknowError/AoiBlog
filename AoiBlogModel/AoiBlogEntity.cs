using System;
using Microsoft.EntityFrameworkCore;

namespace AoiBlogModel
{
    public class AoiBlogEntity : DbContext
    {
        public AoiBlogEntity(DbContextOptions<AoiBlogEntity> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(a => a.Account);
            modelBuilder.Entity<User>().HasIndex(a => a.Status);

            modelBuilder.Entity<Work>().HasIndex(a => a.Author);
            modelBuilder.Entity<Work>().HasIndex(a => a.Status);
            modelBuilder.Entity<Work>().HasIndex(a => a.Upvote);
            modelBuilder.Entity<Work>().HasIndex(a => a.Type);
            //modelBuilder.Entity<Work>().HasIndex(a => a.TagList);

            modelBuilder.Entity<Message>().HasIndex(a => a.ReplyNo);
            modelBuilder.Entity<Message>().HasIndex(a => a.Type);

            modelBuilder.Entity<Picture>().HasIndex(a => a.Type);
            modelBuilder.Entity<Picture>().HasIndex(a => a.RegTime);

        }
        public DbSet<User> User { get; set; }
        public DbSet<Work> Work { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Tag> Tag { get; set; }
    }
}
