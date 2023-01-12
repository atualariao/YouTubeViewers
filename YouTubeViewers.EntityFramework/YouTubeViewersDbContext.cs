using Microsoft.EntityFrameworkCore;
using YouTubeViewers.EntityFrameworrk.DTOs;

namespace YouTubeViewers.EntityFrameworrk
{
    public class YouTubeViewersDbContext : DbContext
    {
        public YouTubeViewersDbContext(DbContextOptions options) : base(options) { }

        public DbSet<YouTubeViewerDto>? YouTubeViewers { get; set; }
    }
}
