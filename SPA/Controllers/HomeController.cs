using Microsoft.AspNetCore.Mvc;
using SPA.Data.Interfaces;
using SPA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Controllers
{
    public class HomeController:Controller
    {
        private IAllService _serRep;

        public HomeController(IAllService serRep)
        {
            _serRep = serRep;
 
        }

        public ViewResult Index()
        {
            var homeServices = new HomeViewModel
            {
                favServices = _serRep.getFavServices
            };
            return View(homeServices);
        }
    }
}
