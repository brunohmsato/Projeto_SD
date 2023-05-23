using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class AnimalEntityConfiguration : IEntityTypeConfiguration<AnimalModel>
    {
        public void Configure(EntityTypeBuilder<AnimalModel> builder)
        {
            builder.ToTable("Animal");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataCadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            builder.Property(a => a.Nome)
                .HasColumnName("nome")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Especie)
                .HasColumnName("especie")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Raca)
                .HasColumnName("raca")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Sexo)
                .HasColumnName("sexo")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(a => a.Cor)
                .HasColumnName("cor")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.DataNascimento)
                .HasColumnName("data_nascimento")
                .IsRequired();

            builder.Property(a => a.Peso)
                .HasColumnName("peso")
                .IsRequired();

            builder.Property(a => a.Alergia)
                .HasColumnName("alergia")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(a => a.TutorId)
                .HasColumnName("tutor_id")
                .IsRequired();

            builder.HasOne(a => a.Tutor)
                .WithMany()
                .HasForeignKey(a => a.TutorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}