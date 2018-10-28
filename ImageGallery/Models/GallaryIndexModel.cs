using SampleImageGallary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Models
{
    public class GallaryIndexModel
    {
        public IEnumerable<GallaryImage> Images { set; get; }
        public string SearchQuery { set; get; }
    }
}
