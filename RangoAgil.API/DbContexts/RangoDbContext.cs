namespace RangoAgil.API.DbContexts;

using Microsoft.EntityFrameworkCore;
using RangoAgil.API.Entities;



// Classe de contexto do banco de dados que configura as opções do Entity Framework e gerencia as entidades Rango e Ingrediente
public class RangoDbContext(DbContextOptions < RangoDbContext > options) : DbContext(options)

{
    //Usar null! é uma forma de dizer ao compilador que você garante que esses valores não serão nulos em tempo de execução.
    public DbSet<Rango> Rangos { get; set; } = null!;
    public DbSet<Ingrediente> Ingredientes { get; set; } = null!;

    // Sobrescreve o método OnModelCreating para configurar os modelos das entidades.
    // Chama a implementação base para manter as configurações padrão do Entity Framework.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}

