using DbHelper;
using Microsoft.EntityFrameworkCore;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<User> Users { get; set; } = new();
}

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }

    public int CompanyId { get; set; }
    public Company? Company { get; set; }
}

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Config.ConnectionString);
    }
}