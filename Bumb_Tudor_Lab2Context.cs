using Bumb_Tudor_Lab2.Models;
using Microsoft.EntityFrameworkCore;

public class Bumb_Tudor_Lab2Context(DbContextOptions<Bumb_Tudor_Lab2Context> options) : DbContext(options)
{
    public DbSet<Bumb_Tudor_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Bumb_Tudor_Lab2.Models.Publisher> Publisher { get; set; } = default!;
}
