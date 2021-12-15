﻿// <auto-generated />
using System;
using December.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace December.Migrations
{
    [DbContext(typeof(EmployeContext))]
    partial class EmployeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("December.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CompanyTypes")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("December.Models.Employe", b =>
                {
                    b.Property<int>("EmployeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avd")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Stad")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EmployeId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("December.Models.Employe", b =>
                {
                    b.HasOne("December.Models.Company", null)
                        .WithMany("Employes")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("December.Models.Company", b =>
                {
                    b.Navigation("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}
