using Microsoft.AspNetCore.Mvc;
using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Controllers
{
    public class OrderController: Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopService shopService;

        public OrderController(IAllOrders allOrders, ShopService shopService)
        {
            this.allOrders = allOrders;
            this.shopService = shopService;
        }
        public IActionResult Checkout()
        {
            return View();
        }
            [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopService.listShopItems = shopService.getServiceItems();
            if(shopService.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","Должны находиться услуги!");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Запись отправлена! В ближайшее время с Вами свяжется администратор.  ";
            return View();
        }


    }
}
