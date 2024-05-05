﻿// <auto-generated />
using System;
using ForumApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForumApp.Infrastructure.Migrations
{
    [DbContext(typeof(ForumAppDbContext))]
    partial class ForumAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ForumApp.Infrastructure.Data.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Post identifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Post content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Post title");

                    b.HasKey("Id");

                    b.ToTable("Posts", t =>
                        {
                            t.HasComment("Popsts table");
                        });

                    b.HasData(
                        new
                        {
                            Id = new Guid("d01c49f8-bb2b-43f1-9970-26b6062c5815"),
                            Content = "This is the content of my first post.",
                            Title = "My first post"
                        },
                        new
                        {
                            Id = new Guid("63710ac3-7982-4d4b-96df-e71f766b06e5"),
                            Content = "This is the content of my second post.",
                            Title = "My second post"
                        },
                        new
                        {
                            Id = new Guid("7d8290bf-a957-43c7-8029-071a987e1fd6"),
                            Content = "This is the content of my third post.",
                            Title = "My third post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}