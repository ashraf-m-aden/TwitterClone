﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(TweetDbContext))]
    partial class TweetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Tweet", b =>
                {
                    b.Property<Guid>("IdTweet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Media")
                        .HasColumnType("bytea");

                    b.Property<string>("Tag")
                        .HasColumnType("text");

                    b.HasKey("IdTweet");

                    b.ToTable("Tweets", (string)null);

                    b.HasData(
                        new
                        {
                            IdTweet = new Guid("ae86ae1c-a2be-418d-9bbb-c50ca36518f9"),
                            Content = "Tweet enregistré à l'initialisation",
                            IdUser = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}