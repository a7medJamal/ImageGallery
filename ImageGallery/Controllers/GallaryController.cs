using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;
using SampleImageGallary;
using SampleImageGallary.Models;

namespace ImageGallery.Controllers
{
    public class GallaryController : Controller
    {
        private readonly IImage _imageService;
        public GallaryController(IImage imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {
            var imagelist = _imageService.GetAll();
            var model = new GallaryIndexModel()
            {
                Images=imagelist,
                SearchQuery= ""
            };
            return View(model);
        }
    }
}