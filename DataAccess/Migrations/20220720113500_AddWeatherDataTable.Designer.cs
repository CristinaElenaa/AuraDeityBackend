// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AuraDeityContext))]
    [Migration("20220720113500_AddWeatherDataTable")]
    partial class AddWeatherDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.UserAuthEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("HashPassword")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("KeyPassword")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("UserAuths");
                });

            modelBuilder.Entity("DataAccess.Entities.WeatherData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("QueryDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Temperature")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserAuthsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserAuthsId");

                    b.ToTable("WeatherDatas");
                });

            modelBuilder.Entity("DataAccess.Entities.WeatherData", b =>
                {
                    b.HasOne("DataAccess.Entities.UserAuthEntity", "UserAuths")
                        .WithMany()
                        .HasForeignKey("UserAuthsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAuths");
                });
#pragma warning restore 612, 618
        }
    }
}
