﻿// <auto-generated />
using LICapp.LICDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LICapp.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20200223165240_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LICapp.Models.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bussiness");

                    b.Property<string>("Bussiness_Address");

                    b.Property<string>("Bussiness_Phone_Number");

                    b.Property<string>("MyProperty");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Carriers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bussiness_Address = "satish test business address",
                            Bussiness_Phone_Number = "12345678",
                            MyProperty = "testproperty1",
                            Name = "satish"
                        },
                        new
                        {
                            Id = 2,
                            Bussiness_Address = "parimi test business address",
                            Bussiness_Phone_Number = "12345678",
                            MyProperty = "testproperty2",
                            Name = "satish"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}