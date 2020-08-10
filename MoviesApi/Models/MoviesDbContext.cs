using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;
namespace MoviesApi.Models
{
    public class MoviesDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MoviesDbContext(){}
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}
