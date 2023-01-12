using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.EntityFrameworrk
{
    public class YouTubeViewersDesignTimeDbContextFactory : IDesignTimeDbContextFactory<YouTubeViewersDbContext>
    {
        public YouTubeViewersDbContext CreateDbContext(string[] args = null)
        {
            return new YouTubeViewersDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=YouTubeViewers.db").Options);
        }
    }
}
