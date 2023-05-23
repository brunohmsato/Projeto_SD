using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistDist.Models;

namespace SistDist.Mapping
{
    public class PessoaEntityConfiguration : IEntityTypeConfiguration<PessoaModel>
    {
        public void Configure(EntityTypeBuilder<PessoaModel> entity)
        {
            entity.ToTable("Pessoa");

            entity.HasKey(p => p.Id);

            entity.Property(p => p.DataCadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();

            entity.Property(p => p.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(p => p.DataNascimento)
                .HasColumnName("data_nascimento")
                .IsRequired();

            entity.Property(p => p.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.CPF)
                .HasColumnName("cpf")
                .HasMaxLength(11)
                .IsRequired();

            entity.Property(p => p.Telefone)
                .HasColumnName("telefone")
                .HasMaxLength(11)
                .IsRequired();

            entity.Property(p => p.Logradouro)
                .HasColumnName("logradouro")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.Numero)
                .HasColumnName("numero")
                .IsRequired();

            entity.Property(p => p.Complemento)
                .HasColumnName("complemento")
                .HasMaxLength(50);

            entity.Property(p => p.Bairro)
                .HasColumnName("bairro")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(p => p.UF)
                .HasColumnName("uf")
                .HasMaxLength(2)
                .IsRequired();

            entity.Property(p => p.CEP)
                .HasColumnName("cep")
                .HasMaxLength(8)
                .IsRequired();
        }
    }
}