﻿// <auto-generated />
using System;
using EFDataAccessLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFDataAccessLibrary.Migrations
{
    [DbContext(typeof(SurveyContext))]
    [Migration("20210511134752_InitialDbCreation")]
    partial class InitialDbCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFDataAccessLibrary.Models.Choice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChoiceText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Choice", b =>
                {
                    b.HasOne("EFDataAccessLibrary.Models.Question", null)
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Question", b =>
                {
                    b.HasOne("EFDataAccessLibrary.Models.Survey", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Question", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Survey", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}