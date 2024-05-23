﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valaki.Persistence.Context;

#nullable disable

namespace Valaki.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240523113957_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Valaki.Domain.Entities.KiteSpot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateDeleted")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KiteSpots");
                });
#pragma warning restore 612, 618
        }
    }
}
