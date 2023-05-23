using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<AnimalModel> Animals { get; set; }
        public DbSet<ConsultaModel> Consultas { get; set; }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<TutorModel> Tutores { get; set; }
        public DbSet<VeterinarioModel> Veterinarios { get; set; }
    }
}
