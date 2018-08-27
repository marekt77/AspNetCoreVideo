using AspNetCoreVideo.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Data
{
    public class VideoDBContext : IdentityDbContext<User>
    {
        public DbSet<Video> Videos { get; set; }

        public VideoDBContext(DbContextOptions<VideoDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
