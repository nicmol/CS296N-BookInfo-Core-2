﻿// <auto-generated />
using BookInfo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BookInfo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookInfo.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("BookID");

                    b.Property<string>("Name");

                    b.HasKey("AuthorID");

                    b.HasIndex("BookID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookInfo.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookInfo.Models.Author", b =>
                {
                    b.HasOne("BookInfo.Models.Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookID");
                });
#pragma warning restore 612, 618
        }
    }
}
