﻿// <auto-generated />
using System;
using HospiCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospiCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220904050806_relacionHistoriaMedico2")]
    partial class relacionHistoriaMedico2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HospiCasa.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Auxiliares");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Enfermera", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horasLaboralesSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("targetaProfecional")
                        .HasColumnType("int");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Enfermeros");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Familiar", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("familiarid")
                        .HasColumnType("int");

                    b.Property<int>("pacienteid")
                        .HasColumnType("int");

                    b.Property<string>("parentescoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("pacienteid");

                    b.ToTable("Familiares");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.HistoriaMedica", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("entornoHospitalizacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.Property<int>("medicoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("medicoid");

                    b.ToTable("HistoriasMedicas");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Medico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("registroReTHUS")
                        .HasColumnType("int");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Paciente", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("direccionGeorreferenciada")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("pacienteid")
                        .HasColumnType("int");

                    b.Property<int>("tipoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Familiar", b =>
                {
                    b.HasOne("HospiCasa.App.Dominio.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("pacienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.HistoriaMedica", b =>
                {
                    b.HasOne("HospiCasa.App.Dominio.Medico", "medico")
                        .WithMany("listaHistorias")
                        .HasForeignKey("medicoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medico");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Medico", b =>
                {
                    b.Navigation("listaHistorias");
                });
#pragma warning restore 612, 618
        }
    }
}
