using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Models
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options)
           : base(options)
        {
        }

        public DbSet<Badge> Badges { get; set; }

        public DbSet<UserSelection> ClientSelections { get; set; }

        public DbSet<DrinkType> DrinkTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Badge>()
                .HasOne(b => b.UserSelection)
                .WithOne(b => b.Badge)
                .HasForeignKey<UserSelection>(e => e.BadgeId); 
            
        }

    }
}
