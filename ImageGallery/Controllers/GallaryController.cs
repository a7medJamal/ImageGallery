using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;
using SampleImageGallary.Models;

namespace ImageGallery.Controllers
{
    public class GallaryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();
            
            var tag1 = new ImageTag()
            {
                Description = " Adventure",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Description = " Mobile Phone",
                Id = 1
            };
            var tag3 = new ImageTag()
            {
                Description = " City",
                Id = 2
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag>{ tag2, tag3});
            var imagelist = new List<GallaryImage>()
            {
                new GallaryImage()
                {
                    Title="Iphone",
                    Url="https://images.pexels.com/photos/887751/pexels-photo-887751.jpeg?cs=srgb&dl=applications-cell-phone-device-887751.jpg&fm=jpg",
                    Created=DateTime.Now,
                    Tags=hikingImageTags
                },

                new GallaryImage()
                {
                    Title="Samsung",
                    Url="https://images.pexels.com/photos/50614/pexels-photo-50614.jpeg?cs=srgb&dl=android-applications-apps-50614.jpg&fm=jpg",
                    Created=DateTime.Now,
                    Tags=cityImageTags
                },
                new GallaryImage()
                {
                    Title="City img",
                    Url="https://images.pexels.com/photos/373912/pexels-photo-373912.jpeg?cs=srgb&dl=aerial-android-wallpaper-architectural-design-373912.jpg&fm=jpg",
                    Created=DateTime.Now,
                    Tags=hikingImageTags
                }


            };
            var model = new GallaryIndexModel()
            {
                Images=imagelist,
                SearchQuery= ""
            };
            return View(model);
        }
    }
}