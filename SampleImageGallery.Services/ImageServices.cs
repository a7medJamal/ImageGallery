using Microsoft.EntityFrameworkCore;
using SampleImageGallary;
using SampleImageGallary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleImageGallery.Services
{
    public class ImageServices : IImage
    {
        private readonly SampleImageGallaryDbContext _ctx;
        public ImageServices( SampleImageGallaryDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<GallaryImage> GetAll()
        {
            return _ctx.GallaryImages
                  .Include(img => img.Tags);
        }

        public GallaryImage GetById(int id)
        {
            return GetAll().Where(img => img.Id == id).First();
        }

        public IEnumerable<GallaryImage> GetWithTag(string tag)
        {
           return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
