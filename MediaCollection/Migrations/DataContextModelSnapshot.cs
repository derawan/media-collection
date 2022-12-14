// <auto-generated />
using System;
using MediaCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediaCollection.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MediaCollection.Models.Media", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal?>("Price")
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SampleUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ArtistId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            AlbumName = "On Through the Night",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Def_Leppard_-_On_Through_the_Night.jpg/220px-Def_Leppard_-_On_Through_the_Night.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1980, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 2,
                            AlbumName = "High 'n' Dry",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Def_Leppard_-_High_%27n%27_Dry.jpg/220px-Def_Leppard_-_High_%27n%27_Dry.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1981, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 3,
                            AlbumName = "Pyromania",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Def_Leppard_-_Pyromania.jpg/220px-Def_Leppard_-_Pyromania.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1983, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 4,
                            AlbumName = "Hysteria",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg/220px-Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1987, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 5,
                            AlbumName = "Adrenalize",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Def_Leppard_-_Adrenalize.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1992, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 6,
                            AlbumName = "Slang",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e4/Def_Leppard_-_Slang.jpg",
                            Price = 16m,
                            ReleaseDate = new DateTime(1996, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 7,
                            AlbumName = "Euphoria",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4e/Def_Leppard_-_Euphoria.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 8,
                            AlbumName = "X",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/48/Def_Leppard_-_X.jpg",
                            Price = 14m,
                            ReleaseDate = new DateTime(2002, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 9,
                            AlbumName = "Yeah",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/04/YEAH-Def_Leppard.jpg",
                            Price = 18m,
                            ReleaseDate = new DateTime(2005, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 10,
                            AlbumName = "Songs from the sparkle lounge",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5d/Def_Leppard_-_Songs_from_the_Sparkle_Lounge.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(2008, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 11,
                            AlbumName = "Def Leppard",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Def_Leppard_%28album%29.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        },
                        new
                        {
                            ArtistId = 12,
                            AlbumName = "Diamond Star Halos",
                            ArtistName = "Def Leppard",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9a/Def_Leppard_-_Diamond_Star_Halos.jpg",
                            Price = 15m,
                            ReleaseDate = new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
