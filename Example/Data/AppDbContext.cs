using Bogus;
using Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Example.Data;

public class AppDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Contact>().HasQueryFilter(c => !c.IsDeleted);
        
        var stock = new Faker<Contact>()
            .RuleFor(c => c.Email, f => $"{f.Name.FullName()}@gmail.com")
            .RuleFor(c => c.FullName, f => f.Name.FullName())
            .RuleFor(c => c.NumberPhone, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.Country, f => f.Name.JobArea());
        
        modelBuilder.Entity<Contact>().HasData(stock.Generate(10));
    }
}