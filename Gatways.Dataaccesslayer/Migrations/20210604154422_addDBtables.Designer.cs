﻿// <auto-generated />
using System;
using Gatways.Dataaccesslayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gatways.Dataaccesslayer.Migrations
{
    [DbContext(typeof(GatewaysDbContext))]
    [Migration("20210604154422_addDBtables")]
    partial class addDBtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gatways.Dataaccesslayer.Infrastructure.Entities.GatewayEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IP4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gateways");
                });

            modelBuilder.Entity("Gatways.Dataaccesslayer.Infrastructure.Entities.PeripheralDeviceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GatewayId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GatewayId");

                    b.HasIndex("StatusId");

                    b.ToTable("PeripheralDevices");
                });

            modelBuilder.Entity("Gatways.Dataaccesslayer.Infrastructure.Entities.PeripheralDeviceStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PeripheralDeviceStatus");
                });

            modelBuilder.Entity("Gatways.Dataaccesslayer.Infrastructure.Entities.PeripheralDeviceEntity", b =>
                {
                    b.HasOne("Gatways.Dataaccesslayer.Infrastructure.Entities.GatewayEntity", "Gateway")
                        .WithMany("AssociatedPeripheralDevices")
                        .HasForeignKey("GatewayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gatways.Dataaccesslayer.Infrastructure.Entities.PeripheralDeviceStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}