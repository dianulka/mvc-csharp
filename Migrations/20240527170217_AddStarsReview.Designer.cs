﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcGooodBoooks.Data;

#nullable disable

namespace MvcGooodBoooks.Migrations
{
    [DbContext(typeof(MvcGooodBoooksContext))]
    [Migration("20240527170217_AddStarsReview")]
    partial class AddStarsReview
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("MvcGooodBoooks.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jane",
                            Surname = "Austen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Anne",
                            Surname = "Kowalski"
                        });
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Genre = "Romance",
                            Title = "Pride and Prejudice"
                        });
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reader");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            Surname = "Doe"
                        });
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReaderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReviewDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("StarsGiven")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ReaderId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedDate = new DateTime(2024, 5, 27, 19, 2, 14, 243, DateTimeKind.Local).AddTicks(5902),
                            ReaderId = 1,
                            ReviewDescription = "Excellent book! I love this book.",
                            StarsGiven = 4
                        });
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Book", b =>
                {
                    b.HasOne("MvcGooodBoooks.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Review", b =>
                {
                    b.HasOne("MvcGooodBoooks.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcGooodBoooks.Models.Reader", "Reader")
                        .WithMany("Reviews")
                        .HasForeignKey("ReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MvcGooodBoooks.Models.Reader", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
