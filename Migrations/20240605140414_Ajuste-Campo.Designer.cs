﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEncontro.Models;

#nullable disable

namespace ProjetoEncontro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240605140414_Ajuste-Campo")]
    partial class AjusteCampo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoEncontro.Models.Observacoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Observacoes");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<DateTime>("ObservacoesData")
                        .HasColumnType("datetime2")
                        .HasColumnName("ObservacoesData");

                    b.Property<string>("ObservacoesLocal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesLocal");

                    b.Property<string>("OnservacoesDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ObservacoesDescricao");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Observacoes");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Pessoa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("PessoaCor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaCor");

                    b.Property<DateTime>("PessoaDtDesaparecimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaDtDesaparecimento");

                    b.Property<DateTime?>("PessoaDtEncontro")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaDtEncontro");

                    b.Property<string>("PessoaFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaFoto");

                    b.Property<string>("PessoaLocoalDesaparecimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaLocoalDesaparecimento");

                    b.Property<string>("PessoaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaNome");

                    b.Property<string>("PessoaObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaObservacao");

                    b.Property<string>("PessoaRoupa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaRoupa");

                    b.Property<string>("PessoaSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaSexo");

                    b.Property<byte>("PessoaStatus")
                        .HasColumnType("tinyint")
                        .HasColumnName("PessoaStatus");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Usuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.Property<string>("UsuarioTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioTelefone");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Observacoes", b =>
                {
                    b.HasOne("ProjetoEncontro.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");

                    b.HasOne("ProjetoEncontro.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Pessoa");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProjetoEncontro.Models.Pessoa", b =>
                {
                    b.HasOne("ProjetoEncontro.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
