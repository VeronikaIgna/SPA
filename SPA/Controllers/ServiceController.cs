using Microsoft.AspNetCore.Mvc;
using SPA.Data.Interfaces;
using SPA.Data.Models;
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
        [Route("Service/List")]
        [Route("Service/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Service> services = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                services = _allService.Services.OrderBy(i => i.id);
            } else
            {
                if (string.Equals("Балийский SPA-кабинет", category, StringComparison.OrdinalIgnoreCase))
                {
                    services = _allService.Services.Where(i => i.Category.categoryName.Equals("Балийский SPA-кабинет")).OrderBy(i => i.id);
                }
                else if (string.Equals("SPA-день", category, StringComparison.OrdinalIgnoreCase))
                {
                    services = _allService.Services.Where(i => i.Category.categoryName.Equals("SPA-день")).OrderBy(i => i.id);

                }
                currCategory = _category;

               
            }
            var serviceObj = new ServiceListViewModel
            {
                AllService = services,
                currCategory = currCategory
            };

            ViewBag.Title = "BeautySpa";
           
            return View(serviceObj);
        }
    }
}
