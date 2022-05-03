﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projetos_Delta.Data;

#nullable disable

namespace Projetos_Delta.Migrations
{
    [DbContext(typeof(Projetos_DeltaContext))]
    [Migration("20220503014218_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeesID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectsID")
                        .HasColumnType("int");

                    b.HasKey("EmployeesID", "ProjectsID");

                    b.HasIndex("ProjectsID");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("Projetos_Delta.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Projetos_Delta.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Projeto", (string)null);
                });

            modelBuilder.Entity("Projetos_Delta.Models.Request", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestNuber")
                        .HasColumnType("int");

                    b.Property<int?>("projectID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("projectID");

                    b.ToTable("Request", (string)null);
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("Projetos_Delta.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projetos_Delta.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projetos_Delta.Models.Request", b =>
                {
                    b.HasOne("Projetos_Delta.Models.Employee", null)
                        .WithMany("Requests")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("Projetos_Delta.Models.Project", "project")
                        .WithMany("Request")
                        .HasForeignKey("projectID");

                    b.Navigation("project");
                });

            modelBuilder.Entity("Projetos_Delta.Models.Employee", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Projetos_Delta.Models.Project", b =>
                {
                    b.Navigation("Request");
                });
#pragma warning restore 612, 618
        }
    }
}