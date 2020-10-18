﻿// <auto-generated />
using System;
using Festify.Promotion.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Festify.Promotion.Migrations
{
    [DbContext(typeof(PromotionContext))]
    [Migration("20201018172649_AddContent")]
    partial class AddContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Festify.Promotion.DataAccess.Entities.Content", b =>
                {
                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(88)")
                        .HasMaxLength(88);

                    b.Property<byte[]>("Binary")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Hash");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("Festify.Promotion.DataAccess.Entities.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ShowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShowId");

                    b.HasAlternateKey("ShowGuid");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("Festify.Promotion.DataAccess.Entities.ShowDescription", b =>
                {
                    b.Property<int>("ShowDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageHash")
                        .HasColumnType("nvarchar(88)")
                        .HasMaxLength(88);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ShowDescriptionId");

                    b.HasAlternateKey("ShowId", "ModifiedDate");

                    b.ToTable("ShowDescription");
                });

            modelBuilder.Entity("Festify.Promotion.DataAccess.Entities.ShowDescription", b =>
                {
                    b.HasOne("Festify.Promotion.DataAccess.Entities.Show", "Show")
                        .WithMany("Descriptions")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
