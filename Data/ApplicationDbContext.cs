using Lab7.Entities;
using Lab7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab7.Data
{

    public class ApplicationDbContext:IdentityDbContext<IdentityUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {    }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);
            builder.Entity<Party>().ToTable("Party");
            builder.Seed();
        }

        public DbSet<Party> Parties { get; set; }
        public DbSet<User> Users { get; set; }
    }

}