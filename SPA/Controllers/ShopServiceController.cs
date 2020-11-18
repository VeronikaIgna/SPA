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
    public class ShopServiceController: Controller
    {
        private IAllService _serRep;
        private readonly ShopService _shopService;

        public ShopServiceController(IAllService serRep, ShopService shopService){
            _serRep = serRep;
            _shopService = shopService;
        }

        public ViewResult Index()
        {
            var items = _shopService.getServiceItems();
            _shopService.listShopItems = items;

            var obj = new ShopServiceViewModel
            {
                shopService = _shopService

            };
            return View(obj);
        }

        public RedirectToActionResult addToService(int id)
        {
            var item = _serRep.Services.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopService.AddToService(item);
            }
            return RedirectToAction("Index");
        }

    }
}
