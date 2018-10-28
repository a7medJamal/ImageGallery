using SampleImageGallary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleImageGallary
{
     public interface IImage
     {
        IEnumerable<GallaryImage> GetAll();
        IEnumerable<GallaryImage> GetWithTag (string tag);
        GallaryImage GetById(int id);

     }
}
