﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecureWeb.Data;

#nullable disable

namespace SecureWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002095019_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SecureWeb.Models.Student", b =>
                {
                    b.Property<string>("nim")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("nim");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
