using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class ConsultaEntityConfiguration : IEntityTypeConfiguration<ConsultaModel>
    {
        public void Configure(EntityTypeBuilder<ConsultaModel> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.DataCadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            builder.Property(c => c.DataConsulta)
                .HasColumnName("data_consulta")
                .IsRequired();

            builder.Property(c => c.HorarioConsulta)
                .HasColumnName("horario_consulta")
                .IsRequired();

            builder.Property(c => c.ValorConsulta)
                .HasColumnName("valor_consulta")
                .IsRequired();

            builder.Property(c => c.Diagnostico)
                .HasColumnName("diagnostico")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(c => c.VeterinarioId)
                .HasColumnName("veterinario_id")
                .IsRequired();

            builder.Property(c => c.AnimalId)
                .HasColumnName("animal_id")
                .IsRequired();

            builder.HasOne(c => c.Veterinario)
                .WithMany()
                .HasForeignKey(c => c.VeterinarioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Animal)
                .WithMany()
                .HasForeignKey(c => c.AnimalId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}