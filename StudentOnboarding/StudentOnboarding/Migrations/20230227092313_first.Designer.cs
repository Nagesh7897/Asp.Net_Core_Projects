﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentOnboarding.Models;

#nullable disable

namespace StudentOnboarding.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230227092313_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentOnboarding.Models.StdEducationDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("SchoolorCollege")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("StudentDetailsGenerateUID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("StudentDetailsGenerateUID");

                    b.ToTable("StdEducations");
                });

            modelBuilder.Entity("StudentOnboarding.Models.StudentDetails", b =>
                {
                    b.Property<string>("GenerateUID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ABCID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cluster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FMobile")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MMobile")
                        .HasColumnType("int");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("SEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("SGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("SMobileNo")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenerateUID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentOnboarding.Models.StdEducationDetails", b =>
                {
                    b.HasOne("StudentOnboarding.Models.StudentDetails", null)
                        .WithMany("StdEducation")
                        .HasForeignKey("StudentDetailsGenerateUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentOnboarding.Models.StudentDetails", b =>
                {
                    b.Navigation("StdEducation");
                });
#pragma warning restore 612, 618
        }
    }
}
