using System;
using System.Collections.Generic;
using System.Text;

namespace SampleImageGallary.Models
{
    public class GallaryImage 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public virtual IEnumerable<ImageTag> Tags { get; set; }
    }
}
