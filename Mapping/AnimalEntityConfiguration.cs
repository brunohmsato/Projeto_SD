using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class AnimalEntityConfiguration : IEntityTypeConfiguration<AnimalModel>
    {
        public void Configure(EntityTypeBuilder<AnimalModel> builder)
        {
            builder.ToTable("animal");

            builder.HasKey(a => a.id);

            builder.Property(a => a.data_cadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            builder.Property(a => a.nome)
                .HasColumnName("nome")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.especie)
                .HasColumnName("especie")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.raca)
                .HasColumnName("raca")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.sexo)
                .HasColumnName("sexo")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(a => a.cor)
                .HasColumnName("cor")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.data_nascimento)
                .HasColumnName("data_nascimento")
                .IsRequired();

            builder.Property(a => a.peso)
                .HasColumnName("peso")
                .IsRequired();

            builder.Property(a => a.alergia)
                .HasColumnName("alergia")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(a => a.tutor_id)
                .HasColumnName("tutor_id")
                .IsRequired();

            builder.HasOne(a => a.Tutor)
                .WithMany()
                .HasForeignKey(a => a.tutor_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}