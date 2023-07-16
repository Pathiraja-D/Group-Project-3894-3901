﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRS_GROUP;

#nullable disable

namespace PRS_GROUP.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230715112558_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("PRS_GROUP.Models.Admin", b =>
                {
                    b.Property<int>("AId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PRS_GROUP.Models.Patient", b =>
                {
                    b.Property<string>("PNIC")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<double>("DoctorFee")
                        .HasColumnType("REAL");

                    b.Property<double>("HospitalFee")
                        .HasColumnType("REAL");

                    b.Property<double>("MedicineFee")
                        .HasColumnType("REAL");

                    b.Property<string>("PatientFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PatientLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("T_Number")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalFee")
                        .HasColumnType("REAL");

                    b.HasKey("PNIC");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PRS_GROUP.Models.User", b =>
                {
                    b.Property<string>("NIC")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NIC");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
