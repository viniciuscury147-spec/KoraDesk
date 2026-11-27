using KoraDesk.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KoraDesk.Infrastructure.Persistence;

public class KoraDeskDbContext : DbContext
{
    public KoraDeskDbContext(
        DbContextOptions<KoraDeskDbContext>optins)
        : base(optins)
    {
    }
    public DbSet<Ticket> Tickets => Set<Ticket>();
}