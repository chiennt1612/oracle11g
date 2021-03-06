﻿// <auto-generated />
using System;
using IdentityServer.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace WebApplication1.Migrations.LogDb
{
    [DbContext(typeof(LogDbContext))]
    partial class LogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("IdentityServer.Entities.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Level")
                        .HasColumnType("NVARCHAR2(128)")
                        .HasMaxLength(128);

                    b.Property<string>("LogEvent")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Message")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Properties")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                    b.HasKey("Id");

                    b.ToTable("Logs","ORC_USR");
                });
#pragma warning restore 612, 618
        }
    }
}
