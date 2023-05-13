using Microsoft.EntityFrameworkCore;
#nullable disable
class Contexto : DbContext
{
    public DbSet<Prioridades> prioridades { get; set; }
    public Contexto(DbContextOptions<Contexto> opcion) : base(opcion)
    {
        
    }
}