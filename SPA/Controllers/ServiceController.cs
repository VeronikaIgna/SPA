using Microsoft.AspNetCore.Mvc;
using SPA.Data.Interfaces;
using SPA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Controllers
{
    public class ServiceController: Controller
    {
        private readonly IAllService _allService;
        private readonly IServiceCategory _allCategories;

        public ServiceController(IAllService iAllService, IServiceCategory iServiceCategory)
        {
            _allService = iAllService;
            _allCategories = iServiceCategory;
        }
        public ViewResult List()
        {
            ViewBag.Title = "BeautySpa";
            ServiceListViewModel obj = new ServiceListViewModel();
            obj.AllService = _allService.Services;
            obj.currCategory = "Услуги";
            return View(obj);
        }
    }
}
