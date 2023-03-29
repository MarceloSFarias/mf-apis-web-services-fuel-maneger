using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_fuel_maneger.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Veiculo>  Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
