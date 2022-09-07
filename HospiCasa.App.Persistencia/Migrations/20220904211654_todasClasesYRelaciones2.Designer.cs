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
    [Migration("20220904211654_todasClasesYRelaciones2")]
    partial class todasClasesYRelaciones2
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

            modelBuilder.Entity("HospiCasa.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("emfermeraid")
                        .HasColumnType("int");

                    b.Property<string>("estadoGeneralPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaYHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("frecuenciaCardiaca")
                        .HasColumnType("int");

                    b.Property<int>("frecuenciaRespiratoria")
                        .HasColumnType("int");

                    b.Property<string>("glicemias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("historiaMedicaid")
                        .HasColumnType("int");

                    b.Property<int>("idEnfermera")
                        .HasColumnType("int");

                    b.Property<int>("idHistoriaMedica")
                        .HasColumnType("int");

                    b.Property<int>("oximetria")
                        .HasColumnType("int");

                    b.Property<string>("presionArterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("temperatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("emfermeraid");

                    b.HasIndex("historiaMedicaid");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("historiaMedicaid")
                        .HasColumnType("int");

                    b.Property<int>("idHistoriaMedica")
                        .HasColumnType("int");

                    b.Property<string>("sugerencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("historiaMedicaid");

                    b.ToTable("SugerenciasCuidados");
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

            modelBuilder.Entity("HospiCasa.App.Dominio.SignoVital", b =>
                {
                    b.HasOne("HospiCasa.App.Dominio.Enfermera", "emfermera")
                        .WithMany("signosVitales")
                        .HasForeignKey("emfermeraid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospiCasa.App.Dominio.HistoriaMedica", "historiaMedica")
                        .WithMany("listadeSignos")
                        .HasForeignKey("historiaMedicaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("emfermera");

                    b.Navigation("historiaMedica");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("HospiCasa.App.Dominio.HistoriaMedica", "historiaMedica")
                        .WithMany("listaDeSugerencias")
                        .HasForeignKey("historiaMedicaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("historiaMedica");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Enfermera", b =>
                {
                    b.Navigation("signosVitales");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.HistoriaMedica", b =>
                {
                    b.Navigation("listaDeSugerencias");

                    b.Navigation("listadeSignos");
                });

            modelBuilder.Entity("HospiCasa.App.Dominio.Medico", b =>
                {
                    b.Navigation("listaHistorias");
                });
#pragma warning restore 612, 618
        }
    }
}
