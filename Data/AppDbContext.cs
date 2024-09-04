using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApi_02.Models;

namespace WebApi_02.Data;

public class AppDbContext : DbContext // herdandp DbContext para trabalhar com o entity framework
{
    public DbSet<Estudante> Estudantes { get; set; } // criando a tabela estudantes
    
    public AppDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // instanciando optionsBuilder para config
    {
            base.OnModelCreating(modelBuilder);
    }
}