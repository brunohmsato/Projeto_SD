using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class TutorEntityConfiguration : IEntityTypeConfiguration<TutorModel>
    {
        public void Configure(EntityTypeBuilder<TutorModel> entity)
        {
            entity.ToTable("Tutor");

            entity.HasKey(t => t.Id);

            entity.Property(t => t.NotificacaoEmail)
                .HasColumnName("notificacao_email")
                .IsRequired();

            entity.Property(t => t.NotificacaoWhats)
                .HasColumnName("notificacao_whats")
                .IsRequired();

            entity.Property(t => t.PessoaId)
                .HasColumnName("pessoa_id")
                .IsRequired();

            entity.HasOne(t => t.Pessoa)
                .WithOne()
                .HasForeignKey<TutorModel>(t => t.PessoaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}