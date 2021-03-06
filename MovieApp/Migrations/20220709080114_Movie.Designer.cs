// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Models;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220709080114_Movie")]
    partial class Movie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieApp.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnName("ActorID")
                        .HasColumnType("int");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("MovieId")
                        .HasColumnName("MovieID")
                        .HasColumnType("int");

                    b.HasIndex("MovieId");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("MovieApp.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnName("MovieID")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Plot")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime>("Release")
                        .HasColumnType("date");

                    b.HasKey("MovieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieApp.Models.Producer", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnName("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnName("ProducerID")
                        .HasColumnType("int");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasIndex("MovieId");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("MovieApp.Models.Actor", b =>
                {
                    b.HasOne("MovieApp.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK__Actor__MovieID__25869641")
                        .IsRequired();
                });

            modelBuilder.Entity("MovieApp.Models.Producer", b =>
                {
                    b.HasOne("MovieApp.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK__Producer__MovieI__276EDEB3")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
