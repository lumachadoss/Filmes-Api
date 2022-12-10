using api1.Modelos;
using Microsoft.EntityFrameworkCore;

namespace api1.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt)
                            :base(opt)
        {

        }
        public DbSet<Filmes> Filmes { get; set; }
    }
}
