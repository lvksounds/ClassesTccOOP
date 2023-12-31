﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Waise.Portal.Data;

#nullable disable

namespace Waise.Portal.Migrations
{
    [DbContext(typeof(WaiseAcademicoContext))]
    partial class WaiseAcademicoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Waise.Portal.Models.Academico.Curso", b =>
                {
                    b.Property<long>("IDCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IDCurso"));

                    b.Property<long?>("InstituicaoId")
                        .HasColumnType("bigint");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDCurso");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Waise.Portal.Models.Academico.Instituicao", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Waise.Portal.Models.Academico.Curso", b =>
                {
                    b.HasOne("Waise.Portal.Models.Academico.Instituicao", "Instituicao")
                        .WithMany("Cursos")
                        .HasForeignKey("InstituicaoId");

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("Waise.Portal.Models.Academico.Instituicao", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
