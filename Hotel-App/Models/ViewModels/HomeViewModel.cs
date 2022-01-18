using Hotel_App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.ViewModels
{
    public class HomeViewModel
    {
        public Banner Banners { get; set; }
        public BannerImage BannerImages { get; set; }
    }
}
