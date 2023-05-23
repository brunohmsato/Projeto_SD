﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistDist.Context;

#nullable disable

namespace SistDist.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230523190321_updatedReadMe")]
    partial class updatedReadMe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SistDist.Models.AnimalModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alergia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TutorId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("SistDist.Models.ConsultaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("HorarioConsulta")
                        .HasColumnType("interval");

                    b.Property<float>("ValorConsulta")
                        .HasColumnType("real");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("SistDist.Models.PessoaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("cep");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_cadastro");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("telefone");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("SistDist.Models.TutorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("NotificacaoEmail")
                        .HasColumnType("boolean");

                    b.Property<bool>("NotificacaoWhats")
                        .HasColumnType("boolean");

                    b.Property<int>("PessoaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("SistDist.Models.VeterinarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CRMVEstado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CRMVNumero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CTPSEstado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CTPSNumero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CTPSSerie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataDemissao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("NotificacaoEmail")
                        .HasColumnType("boolean");

                    b.Property<bool>("NotificacaoWhats")
                        .HasColumnType("boolean");

                    b.Property<string>("PISPasesp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PessoaId")
                        .HasColumnType("integer");

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("SistDist.Models.AnimalModel", b =>
                {
                    b.HasOne("SistDist.Models.TutorModel", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("SistDist.Models.ConsultaModel", b =>
                {
                    b.HasOne("SistDist.Models.AnimalModel", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistDist.Models.VeterinarioModel", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("SistDist.Models.TutorModel", b =>
                {
                    b.HasOne("SistDist.Models.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("SistDist.Models.VeterinarioModel", b =>
                {
                    b.HasOne("SistDist.Models.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
