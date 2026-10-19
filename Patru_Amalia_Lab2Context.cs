global using Patru_Amalia_Lab2.Data;
using Microsoft.EntityFrameworkCore;

namespace Patru_Amalia_Lab2.Data
{
    public class Patru_Amalia_Lab2Context : DbContext
    {
        public Patru_Amalia_Lab2Context(DbContextOptions<Patru_Amalia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Patru_Amalia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Patru_Amalia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Patru_Amalia_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Patru_Amalia_Lab2.Models.Category> Category { get; set; } = default!;
    }
}