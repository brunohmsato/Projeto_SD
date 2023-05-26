using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class VeterinarioEntityConfiguration : IEntityTypeConfiguration<VeterinarioModel>
    {
        public void Configure(EntityTypeBuilder<VeterinarioModel> entity)
        {
            entity.ToTable("veterinario");

            entity.HasKey(v => v.id);

            entity.Property(v => v.data_contratacao)
                .HasColumnName("data_contratacao")
                .IsRequired();

            entity.Property(v => v.data_demissao)
                .HasColumnName("data_demissao");

            entity.Property(v => v.ctps_numero)
                .HasColumnName("ctps_numero")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.ctps_serie)
                .HasColumnName("ctps_serie")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.ctps_estado)
                .HasColumnName("ctps_estado")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(v => v.pis_pasesp)
                .HasColumnName("pis_pasesp")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.salario)
                .HasColumnName("salario")
                .IsRequired();

            entity.Property(v => v.crmv_numero)
                .HasColumnName("crmv_numero")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.crmv_estado)
                .HasColumnName("crmv_estado")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(v => v.pessoa_id)
                .HasColumnName("pessoa_id")
                .IsRequired();

            entity.HasOne(v => v.Pessoa)
                .WithOne()
                .HasForeignKey<VeterinarioModel>(v => v.pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}