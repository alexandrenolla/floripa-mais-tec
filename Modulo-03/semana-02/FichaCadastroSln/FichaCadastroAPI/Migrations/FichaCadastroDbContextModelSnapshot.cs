﻿// <auto-generated />
using System;
using FichaCadastroAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FichaCadastroAPI.Migrations
{
    [DbContext(typeof(FichaCadastroDbContext))]
    partial class FichaCadastroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("FichaCadastroAPI.Model.DetalheModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("FichaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FichaId");

                    b.ToTable("Detalhe");
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.FichaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Ficha");
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.DetalheModel", b =>
                {
                    b.HasOne("FichaCadastroAPI.Model.FichaModel", "Ficha")
                        .WithMany("Detalhes")
                        .HasForeignKey("FichaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ficha");
                });

            modelBuilder.Entity("FichaCadastroAPI.Model.FichaModel", b =>
                {
                    b.Navigation("Detalhes");
                });
#pragma warning restore 612, 618
        }
    }
}
