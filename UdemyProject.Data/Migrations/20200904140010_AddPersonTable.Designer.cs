﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyProject.Data;

namespace UdemyProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200904140010_AddPersonTable")]
    partial class AddPersonTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyProject.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kalemler",
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "Defterler",
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("UdemyProject.Core.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("UdemyProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Pilot Kalem",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Kursun Kalem",
                            Price = 42.50m,
                            Stock = 200,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Tukenmez Kalem",
                            Price = 32.50m,
                            Stock = 300,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Defter",
                            Price = 12.50m,
                            Stock = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Orta Defter",
                            Price = 42.50m,
                            Stock = 200,
                            isDeleted = false
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Buyuk Defter",
                            Price = 62.50m,
                            Stock = 200,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("UdemyProject.Core.Models.Product", b =>
                {
                    b.HasOne("UdemyProject.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
