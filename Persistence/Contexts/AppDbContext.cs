using System;
using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace users.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.EmailAddress);
            builder.Entity<User>().Property(p => p.EmailAddress).IsRequired();
            builder.Entity<User>().Property(p => p.Title).IsRequired().HasMaxLength(4);
            builder.Entity<User>().Property(p => p.FirstName).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.DateOfBirth).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.EmailAddress).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.PhoneNumber).IsRequired().HasMaxLength(30);
            builder.Entity<User>().Property(p => p.ProfilePicture).IsRequired().HasMaxLength(30);

            builder.Entity<User>().HasData
            (
                new User { FirstName = "Alice", LastName = "Smith", DateOfBirth = "03/04/1992", EmailAddress = "alices@gmail.com", PhoneNumber = "0219876543", ProfilePicture = "alicesmith.png", Title = "Mrs" },
                new User { FirstName = "Bob", LastName = "Roberts", DateOfBirth = "03/04/1979", EmailAddress = "roberts@gmail.com", PhoneNumber = "021123456", ProfilePicture = "bobroberts.png", Title = "Mr" }
            //readData()
            );
        }

        private User[] readData()
        {
            throw new NotImplementedException();
        }
    }
}
