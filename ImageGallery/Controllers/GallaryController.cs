using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class GallaryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GallaryIndexModel()
            {

            };
            return View(model);
        }
    }
}