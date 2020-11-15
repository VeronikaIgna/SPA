using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopService shopService;

        public OrdersRepository(AppDBContent appDBContent, ShopService shopService)
        {
            this.appDBContent = appDBContent;
            this.shopService = shopService;
        }
      public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopService.listShopItems;


            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ServiceID = el.service.id,
                    orderID = order.id,
                    price = el.service.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
           

        }
        
    }
}
