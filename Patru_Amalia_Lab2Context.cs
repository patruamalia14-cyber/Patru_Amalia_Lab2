using Microsoft.EntityFrameworkCore;

public class Patru_Amalia_Lab2Context(DbContextOptions<Patru_Amalia_Lab2Context> options) : DbContext(options)
{
    public DbSet<Patru_Amalia_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Patru_Amalia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Patru_Amalia_Lab2.Models.Author> Author { get; set; } = default!;
}
