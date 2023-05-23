using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class VeterinarioEntityConfiguration : IEntityTypeConfiguration<VeterinarioModel>
    {
        public void Configure(EntityTypeBuilder<VeterinarioModel> entity)
        {
            entity.ToTable("Veterinario");

            entity.HasKey(v => v.Id);

            entity.Property(v => v.DataContratacao)
                .HasColumnName("data_contratacao")
                .IsRequired();

            entity.Property(v => v.DataDemissao)
                .HasColumnName("data_demissao")
                .IsRequired();

            entity.Property(v => v.CTPSNumero)
                .HasColumnName("ctps_numero")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.CTPSSerie)
                .HasColumnName("ctps_serie")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.CTPSEstado)
                .HasColumnName("ctps_estado")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(v => v.PISPasesp)
                .HasColumnName("pis_pasesp")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.Salario)
                .HasColumnName("salario")
                .IsRequired();

            entity.Property(v => v.CRMVNumero)
                .HasColumnName("crmv_numero")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(v => v.CRMVEstado)
                .HasColumnName("crmv_estado")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(v => v.NotificacaoEmail)
                .HasColumnName("notificacao_email")
                .IsRequired();

            entity.Property(v => v.NotificacaoWhats)
                .HasColumnName("notificacao_whats")
                .IsRequired();

            entity.Property(v => v.PessoaId)
                .HasColumnName("pessoa_id")
                .IsRequired();

            entity.HasOne(v => v.Pessoa)
                .WithOne()
                .HasForeignKey<VeterinarioModel>(v => v.PessoaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}