using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class TutorEntityConfiguration : IEntityTypeConfiguration<TutorModel>
    {
        public void Configure(EntityTypeBuilder<TutorModel> entity)
        {
            entity.ToTable("tutor");

            entity.HasKey(t => t.id);

            entity.Property(t => t.notificacao_email)
                .HasColumnName("notificacao_email")
                .IsRequired();

            entity.Property(t => t.notificacao_whats)
                .HasColumnName("notificacao_whats")
                .IsRequired();

            entity.Property(t => t.pessoa_id)
                .HasColumnName("pessoa_id")
                .IsRequired();

            entity.HasOne(t => t.Pessoa)
                .WithOne()
                .HasForeignKey<TutorModel>(t => t.pessoa_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}