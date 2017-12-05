﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Trabalho.Models;

namespace Trabalho.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trabalho.Models.Answer", b =>
                {
                    b.Property<int>("AnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerToClient")
                        .IsRequired();

                    b.Property<int>("ClientID");

                    b.HasKey("AnswerID");

                    b.HasIndex("ClientID");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Trabalho.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("ClientName");

                    b.Property<bool?>("ClientState");

                    b.Property<string>("Email");

                    b.Property<int>("Emergency_Contact");

                    b.Property<bool?>("Genre");

                    b.Property<int>("NIF");

                    b.Property<int>("PhoneNumber");

                    b.Property<int>("Type_ClientID");

                    b.HasKey("ClientID");

                    b.HasIndex("Type_ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Trabalho.Models.Diseases", b =>
                {
                    b.Property<int>("DiseasesID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Care");

                    b.Property<string>("Description");

                    b.Property<string>("DiseasesName");

                    b.HasKey("DiseasesID");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("Trabalho.Models.Que_Dis", b =>
                {
                    b.Property<int>("Que_DisID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DiseasesID");

                    b.Property<int>("QuestionID");

                    b.Property<bool?>("YES_NO");

                    b.HasKey("Que_DisID");

                    b.HasIndex("DiseasesID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Que_Dis");
                });

            modelBuilder.Entity("Trabalho.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("QuestionState");

                    b.Property<string>("QuestionToClient");

                    b.HasKey("QuestionID");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Trabalho.Models.Type_Answer", b =>
                {
                    b.Property<int>("Type_AnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerID");

                    b.Property<int>("QuestionID");

                    b.Property<bool?>("Type");

                    b.HasKey("Type_AnswerID");

                    b.HasIndex("AnswerID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Type_Answer");
                });

            modelBuilder.Entity("Trabalho.Models.Type_Client", b =>
                {
                    b.Property<int>("Type_ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeClient");

                    b.HasKey("Type_ClientID");

                    b.ToTable("Type_Client");
                });

            modelBuilder.Entity("Trabalho.Models.Answer", b =>
                {
                    b.HasOne("Trabalho.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabalho.Models.Client", b =>
                {
                    b.HasOne("Trabalho.Models.Type_Client", "Type_Client")
                        .WithMany("Client")
                        .HasForeignKey("Type_ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabalho.Models.Que_Dis", b =>
                {
                    b.HasOne("Trabalho.Models.Diseases", "Diseases")
                        .WithMany("Que_Dis")
                        .HasForeignKey("DiseasesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trabalho.Models.Question", "Question")
                        .WithMany("Que_Dis")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabalho.Models.Type_Answer", b =>
                {
                    b.HasOne("Trabalho.Models.Answer", "Answer")
                        .WithMany("Type_Answer")
                        .HasForeignKey("AnswerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trabalho.Models.Question", "Question")
                        .WithMany("Type_Answer")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
