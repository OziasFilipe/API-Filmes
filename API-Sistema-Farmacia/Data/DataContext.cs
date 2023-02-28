using API_Sistema_Farmacia.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Sistema_Farmacia.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {
        }

        public DbSet<FilmesModels> filmes { get; set; }
    }
}
