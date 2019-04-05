﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ToDoList.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20190401125431_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ToDoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<bool>("IsDone");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ReminderDate");

                    b.Property<int?>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TagId");

                    b.ToTable("ToDo");
                });

            modelBuilder.Entity("ToDoList.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("ToDo_For_MembersEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int?>("TagId");

                    b.Property<int?>("ToDoId");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("ToDoId");

                    b.ToTable("ToDo_For_Members");
                });

            modelBuilder.Entity("ToDoEntity", b =>
                {
                    b.HasOne("CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ToDoList.Entities.TagEntity", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("ToDo_For_MembersEntity", b =>
                {
                    b.HasOne("ToDoList.Entities.TagEntity", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");

                    b.HasOne("ToDoEntity", "ToDo")
                        .WithMany()
                        .HasForeignKey("ToDoId");
                });
#pragma warning restore 612, 618
        }
    }
}
