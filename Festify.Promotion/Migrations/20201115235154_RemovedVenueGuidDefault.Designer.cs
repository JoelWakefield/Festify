﻿// <auto-generated />
using System;
using Festify.Promotion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Festify.Promotion.Migrations
{
    [DbContext(typeof(PromotionContext))]
    [Migration("20201115235154_RemovedVenueGuidDefault")]
    partial class RemovedVenueGuidDefault
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Festify.Promotion.Venues.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("VenueGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VenueId");

                    b.HasAlternateKey("VenueGuid");

                    b.ToTable("Venue");
                });
#pragma warning restore 612, 618
        }
    }
}
