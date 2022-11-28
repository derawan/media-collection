using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MediaCollection.Models;

namespace MediaCollection.Models
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;  
        }

        public DbSet<Media> Medias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>().Property(obj => obj.Price).HasPrecision(12, 2);

            modelBuilder.Entity<Media>()
                .HasData(
                    new Media { AlbumName = "On Through the Night", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1980, 3, 14), ArtistId = 1, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Def_Leppard_-_On_Through_the_Night.jpg/220px-Def_Leppard_-_On_Through_the_Night.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "High 'n' Dry", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1981, 7, 6), ArtistId = 2, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/Def_Leppard_-_High_%27n%27_Dry.jpg/220px-Def_Leppard_-_High_%27n%27_Dry.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Pyromania", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1983, 1, 20), ArtistId = 3, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Def_Leppard_-_Pyromania.jpg/220px-Def_Leppard_-_Pyromania.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Hysteria", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1987, 8, 3), ArtistId = 4, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg/220px-Def_Leppard_-_Hysteria_%28vinyl_version%29.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Adrenalize", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1992, 3, 31), ArtistId = 5, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Def_Leppard_-_Adrenalize.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Slang", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1996, 5, 14), ArtistId = 6, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e4/Def_Leppard_-_Slang.jpg", Price = 16, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Euphoria", ArtistName = "Def Leppard", ReleaseDate = new DateTime(1999, 6, 8), ArtistId = 7, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4e/Def_Leppard_-_Euphoria.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "X", ArtistName = "Def Leppard", ReleaseDate = new DateTime(2002, 7, 30), ArtistId = 8, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/48/Def_Leppard_-_X.jpg", Price = 14, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Yeah", ArtistName = "Def Leppard", ReleaseDate = new DateTime(2005, 9, 20), ArtistId = 9, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/04/YEAH-Def_Leppard.jpg", Price = 18, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Songs from the sparkle lounge", ArtistName = "Def Leppard", ReleaseDate = new DateTime(2008, 4, 25), ArtistId = 10, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5d/Def_Leppard_-_Songs_from_the_Sparkle_Lounge.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Def Leppard", ArtistName = "Def Leppard", ReleaseDate = new DateTime(2015, 10, 30), ArtistId = 11, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Def_Leppard_%28album%29.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" },
                    new Media { AlbumName = "Diamond Star Halos", ArtistName = "Def Leppard", ReleaseDate = new DateTime(2022, 5, 27), ArtistId = 12, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9a/Def_Leppard_-_Diamond_Star_Halos.jpg", Price = 15, SampleUrl = "http://www.noiseaddicts.com/samples_1w72b820/4210.mp3" }
                );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }


    public class Media
    {
        [Key]
        public int ArtistId { get; set; }

        [MaxLength(200)]
        [Required]
        public string ArtistName { get; set; }

        [MaxLength(200)]
        [Required]
        public string AlbumName { get; set; }

        [MaxLength(200)]
        public string? ImageUrl { get; set; }
        public DateTime? ReleaseDate { get; set; }
        [Precision(2)]
        public decimal? Price { get; set; }
        [MaxLength(200)]
        public string? SampleUrl { get; set; }
    }

    public class Nedia
    {
        [Key]
        public int artistId { get; set; }

        [MaxLength(200)]
        [Required]
        public string artistName { get; set; }

        [MaxLength(200)]
        [Required]
        public string albumName { get; set; }

        [MaxLength(200)]
        public string? imageUrl { get; set; }
        public DateTime? releaseDate { get; set; }
        [Precision(2)]
        public decimal? price { get; set; }
        [MaxLength(200)]
        public string? sampleUrl { get; set; }
    }


    /*public static class MediaEndpoints
    {
        public static void MapMediaEndpoints (this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/Media", async (DataContext db) =>
            {
                return await db.Medias.ToListAsync();
            })
            .WithName("GetAllMedias")
            .Produces<List<Media>>(StatusCodes.Status200OK);

            routes.MapGet("/api/Media/{id}", async (int ArtistId, DataContext db) =>
            {
                return await db.Medias.FindAsync(ArtistId)
                    is Media model
                        ? Results.Ok(model)
                        : Results.NotFound();
            })
            .WithName("GetMediaById")
            .Produces<Media>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            routes.MapPut("/api/Media/{id}", async (int ArtistId, Media media, DataContext db) =>
            {
                var foundModel = await db.Medias.FindAsync(ArtistId);

                if (foundModel is null)
                {
                    return Results.NotFound();
                }
                //update model properties here

                await db.SaveChangesAsync();

                return Results.NoContent();
            })   
            .WithName("UpdateMedia")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status204NoContent);

            routes.MapPost("/api/Media/", async (Media media, DataContext db) =>
            {
                db.Medias.Add(media);
                await db.SaveChangesAsync();
                return Results.Created($"/Medias/{media.ArtistId}", media);
            })
            .WithName("CreateMedia")
            .Produces<Media>(StatusCodes.Status201Created);


            routes.MapDelete("/api/Media/{id}", async (int ArtistId, DataContext db) =>
            {
                if (await db.Medias.FindAsync(ArtistId) is Media media)
                {
                    db.Medias.Remove(media);
                    await db.SaveChangesAsync();
                    return Results.Ok(media);
                }

                return Results.NotFound();
            })
            .WithName("DeleteMedia")
            .Produces<Media>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
        }
    */
}
//}
