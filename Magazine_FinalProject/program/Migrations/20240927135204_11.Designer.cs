﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using program.Models.Context;

#nullable disable

namespace program.Migrations
{
    [DbContext(typeof(MagazineContext))]
    [Migration("20240927135204_11")]
    partial class _11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("program.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateOnly>("CategoryDate")
                        .HasColumnType("date");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("program.Models.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("PostBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("program.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddresss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("UserDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("UserSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("UserId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("program.Models.Entities.Post", b =>
                {
                    b.HasOne("program.Models.Entities.Category", "PostCategory")
                        .WithMany("posts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("program.Models.Entities.User", "PostUser")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("PostCategory");

                    b.Navigation("PostUser");
                });

            modelBuilder.Entity("program.Models.Entities.User", b =>
                {
                    b.HasOne("program.Models.Entities.Category", "category")
                        .WithMany("users")
                        .HasForeignKey("CategoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("program.Models.Entities.Category", b =>
                {
                    b.Navigation("posts");

                    b.Navigation("users");
                });

            modelBuilder.Entity("program.Models.Entities.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
