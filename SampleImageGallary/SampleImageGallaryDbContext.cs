using Microsoft.EntityFrameworkCore;
using SampleImageGallary.Models;
using System;

namespace SampleImageGallary
{
    public class SampleImageGallaryDbContext :DbContext
    {
        public SampleImageGallaryDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<GallaryImage>GallaryImages { set; get; }
        public DbSet<ImageTag> ImageTags { set; get; }
    }
}
