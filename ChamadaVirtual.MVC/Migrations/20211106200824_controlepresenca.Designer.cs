﻿// <auto-generated />
using System;
using ChamadaVirtual.MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChamadaVirtual.MVC.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211106200824_controlepresenca")]
    partial class controlepresenca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("aluno");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.ControlePresenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPresenca")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("controlePresenca");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeGrupo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("grupo");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("turma");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Aluno", b =>
                {
                    b.HasOne("ChamadaVirtual.MVC.Models.Grupo", null)
                        .WithMany("ListAlunos")
                        .HasForeignKey("GrupoId");

                    b.HasOne("ChamadaVirtual.MVC.Models.Turma", "oTurma")
                        .WithMany("ListAlunos")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oTurma");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.ControlePresenca", b =>
                {
                    b.HasOne("ChamadaVirtual.MVC.Models.Aluno", "oAluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oAluno");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Grupo", b =>
                {
                    b.Navigation("ListAlunos");
                });

            modelBuilder.Entity("ChamadaVirtual.MVC.Models.Turma", b =>
                {
                    b.Navigation("ListAlunos");
                });
#pragma warning restore 612, 618
        }
    }
}