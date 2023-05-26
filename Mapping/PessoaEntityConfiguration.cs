using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class PessoaEntityConfiguration : IEntityTypeConfiguration<PessoaModel>
    {
        public void Configure(EntityTypeBuilder<PessoaModel> entity)
        {
            entity.ToTable("pessoa");

            entity.HasKey(p => p.id);

            entity.Property(p => p.data_cadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            entity.Property(p => p.nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.data_nascimento)
                .HasColumnName("data_nascimento")
                .IsRequired();

            entity.Property(p => p.email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.cpf)
                .HasColumnName("cpf")
                .HasMaxLength(11)
                .IsRequired();

            entity.Property(p => p.telefone)
                .HasColumnName("telefone")
                .HasMaxLength(11)
                .IsRequired();

            entity.Property(p => p.logradouro)
                .HasColumnName("logradouro")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.numero)
                .HasColumnName("numero")
                .IsRequired();

            entity.Property(p => p.complemento)
                .HasColumnName("complemento")
                .HasMaxLength(50);

            entity.Property(p => p.bairro)
                .HasColumnName("bairro")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.cidade)
                .HasColumnName("cidade")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.uf)
                .HasColumnName("uf")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(p => p.cep)
                .HasColumnName("cep")
                .HasMaxLength(8)
                .IsRequired();
        }
    }
}