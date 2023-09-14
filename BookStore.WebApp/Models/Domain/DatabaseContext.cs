using Microsoft.EntityFrameworkCore;

namespace BookStore.WebApp.Models.Domain;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=BookStore_Db; Trusted_Connection=true");//true=> güvenli bağlantı

    }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Book> Books { get; set; }

}
