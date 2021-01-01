﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MiniProject.Models;
using System;

namespace MiniProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200421130756_OneToOneRelationShips")]
    partial class OneToOneRelationShips
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiniProject.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("MiniProject.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("MiniProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("InstructorId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<decimal>("price");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MiniProject.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContactId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("MiniProject.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("MiniProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MiniProject.Models.StudentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAddress");
                });

            modelBuilder.Entity("MiniProject.Models.Contact", b =>
                {
                    b.HasOne("MiniProject.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("MiniProject.Models.Course", b =>
                {
                    b.HasOne("MiniProject.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MiniProject.Models.Instructor", b =>
                {
                    b.HasOne("MiniProject.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");
                });

            modelBuilder.Entity("MiniProject.Models.StudentAddress", b =>
                {
                    b.HasOne("MiniProject.Models.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("MiniProject.Models.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
