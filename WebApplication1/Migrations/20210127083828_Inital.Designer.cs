﻿// <auto-generated />
using System;
using IdentityServer.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AuditLogDbContext))]
    [Migration("20210127083828_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("IdentityServer.Entities.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Category")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Data")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Event")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Source")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SubjectAdditionalData")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SubjectIdentifier")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SubjectName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SubjectType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("AuditLog");
                });
#pragma warning restore 612, 618
        }
    }
}
