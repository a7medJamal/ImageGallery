using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageGallery.Models
{
    public class GallaryDetailModel
    {
       public int Id { set; get; }
        public string Title  { get; set; }
        public DateTime CreateOn { get; set; }
        public string Url { get; set; }
        public List<string> Tags { get; set; }
    }
}
