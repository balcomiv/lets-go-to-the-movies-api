using Microsoft.EntityFrameworkCore;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Name = "Alien: Covenant",
                Genre = "Sci-Fi, Thriller",
                Director = "Ridley Scott"
            },
            new Movie
            {
                Id = 4,
                Name = "The Lord Of The Rings",
                Genre = "Adventure, Drama, Fantasy",
                Director = "Peter Jackson"
            },
            new Movie
            {
                Id = 6,
                Name = "Original Sin",
                Genre = "Drama, Mystery, Romance",
                Director = "Michael Cristofer"
            });
        }
    }
}
