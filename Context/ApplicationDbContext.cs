using Microsoft.EntityFrameworkCore;
using SistDist.Mapping;
using SistDist.Models;

namespace SistDist.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AnimalModel> Animals { get; set; }
        public DbSet<ConsultaModel> Consultas { get; set; }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<TutorModel> Tutores { get; set; }
        public DbSet<VeterinarioModel> Veterinarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            //optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=SistemasDistribuidos1;User Id=postgres;Password=admin"); //Bruno
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection")); //Bruno
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PessoaEntityConfiguration());
        }
    }
}