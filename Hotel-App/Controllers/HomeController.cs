using Hotel_App.Data;
using Hotel_App.Models;
using Hotel_App.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(new HomeViewModel { 
                Banners = await _dbContext.Banners.FirstOrDefaultAsync(),
                BannerImages = await _dbContext.BannerImages.FirstOrDefaultAsync()
            });
        }

    }
}
