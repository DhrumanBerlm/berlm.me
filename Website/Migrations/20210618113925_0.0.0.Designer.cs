﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Website.Data;

namespace Website.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20210618113925_0.0.0")]
    partial class _000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("BlogBlogTag", b =>
                {
                    b.Property<string>("BlogsTitle")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TagsTitle")
                        .HasColumnType("varchar(255)");

                    b.HasKey("BlogsTitle", "TagsTitle");

                    b.HasIndex("TagsTitle");

                    b.ToTable("BlogBlogTag");
                });

            modelBuilder.Entity("Website.Models.Blog", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Title");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Website.Models.BlogTag", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Title");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("BlogBlogTag", b =>
                {
                    b.HasOne("Website.Models.Blog", null)
                        .WithMany()
                        .HasForeignKey("BlogsTitle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Website.Models.BlogTag", null)
                        .WithMany()
                        .HasForeignKey("TagsTitle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}