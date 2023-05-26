using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class ConsultaEntityConfiguration : IEntityTypeConfiguration<ConsultaModel>
    {
        public void Configure(EntityTypeBuilder<ConsultaModel> builder)
        {
            builder.ToTable("consulta");

            builder.HasKey(c => c.id);

            builder.Property(c => c.data_cadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            builder.Property(c => c.data_consulta)
                .HasColumnName("data_consulta")
                .IsRequired();

            builder.Property(c => c.horario_consulta)
                .HasColumnName("horario_consulta")
                .IsRequired();

            builder.Property(c => c.valor_consulta)
                .HasColumnName("valor_consulta")
                .IsRequired();

            builder.Property(c => c.diagnostico)
                .HasColumnName("diagnostico")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(c => c.animal_id)
                .HasColumnName("animal_id")
                .IsRequired();

            builder.Property(c => c.veterinario_id)
                .HasColumnName("veterinario_id")
                .IsRequired();


            builder.HasOne(c => c.Animal)
                .WithMany()
                .HasForeignKey(c => c.animal_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Veterinario)
                .WithMany()
                .HasForeignKey(c => c.veterinario_id)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}