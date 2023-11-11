﻿// <auto-generated />
using System;
using Extranet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Extranet.Migrations
{
    [DbContext(typeof(ExtranetDbContext))]
    [Migration("20231111150137_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Extranet.Models.Profile", b =>
                {
                    b.Property<int>("profile_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("profile_id"));

                    b.Property<string>("competencesJson")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("current_position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationJson")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienceJson")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("localization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profile_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("profile_id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Extranet.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_del")
                        .HasColumnType("bit");

                    b.Property<DateTime>("modifited_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Extranet.Models.Profile", b =>
                {
                    b.HasOne("Extranet.Models.User", "user")
                        .WithOne("profile")
                        .HasForeignKey("Extranet.Models.Profile", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Extranet.Models.User", b =>
                {
                    b.Navigation("profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
