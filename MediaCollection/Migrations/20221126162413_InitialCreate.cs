using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediaCollection.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AlbumName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SampleUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.ArtistId);
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "ArtistId", "AlbumName", "ArtistName", "ImageUrl", "Price", "ReleaseDate", "SampleUrl" },
                values: new object[,]
                {
                    { 1, "On Through the Night", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Def_Leppard_-_On_Through_the_Night.jpg/220px-Def_Leppard_-_On_Through_the_Night.jpg", 15m, new DateTime(1980, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 2, "High 'n' Dry", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Def_Leppard_-_High_%27n%27_Dry.jpg/220px-Def_Leppard_-_High_%27n%27_Dry.jpg", 15m, new DateTime(1981, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 3, "Pyromania", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Def_Leppard_-_Pyromania.jpg/220px-Def_Leppard_-_Pyromania.jpg", 15m, new DateTime(1983, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 4, "Hysteria", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg/220px-Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg", 15m, new DateTime(1987, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 5, "Adrenalize", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/8/8f/Def_Leppard_-_Adrenalize.jpg", 15m, new DateTime(1992, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 6, "Slang", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/e/e4/Def_Leppard_-_Slang.jpg", 16m, new DateTime(1996, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 7, "Euphoria", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/4/4e/Def_Leppard_-_Euphoria.jpg", 15m, new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 8, "X", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/4/48/Def_Leppard_-_X.jpg", 14m, new DateTime(2002, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 9, "Yeah", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/0/04/YEAH-Def_Leppard.jpg", 18m, new DateTime(2005, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 10, "Songs from the sparkle lounge", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/5/5d/Def_Leppard_-_Songs_from_the_Sparkle_Lounge.jpg", 15m, new DateTime(2008, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 11, "Def Leppard", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/4/45/Def_Leppard_%28album%29.jpg", 15m, new DateTime(2015, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    { 12, "Diamond Star Halos", "Def Leppard", "https://upload.wikimedia.org/wikipedia/en/9/9a/Def_Leppard_-_Diamond_Star_Halos.jpg", 15m, new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
