using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace Entities
{
    public class TweetDbContext: DbContext
    {
        public TweetDbContext(DbContextOptions<TweetDbContext> options): base(options)
        {
            
        }
        public DbSet<Tweet> Tweets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tweet>().ToTable("Tweets");

            // seed data
            modelBuilder.Entity(typeof(Tweet)).HasData(new Tweet() { Content="Tweet enregistré à l'initialisation",
            IdTweet=Guid.NewGuid()});
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                "Host=localhost; Database=TwitterClone; Username=postgres; Password=123@Passer;");
            }
        }
    }
}
