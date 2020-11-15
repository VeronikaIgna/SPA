using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Models
{
    public class ShopService
    {
        private readonly AppDBContent appDBContent;
        public ShopService(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopServiceId { get; set; }

        public List<ShopServiceItem> listShopItems { get; set; }

        public static ShopService GetService(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopServiceId = session.GetString("ServiceId") ?? Guid.NewGuid().ToString();

            session.SetString("shopServiceId", shopServiceId);

            return new ShopService(context) { ShopServiceId = shopServiceId };
        }

        public void AddToService(Service service)
        {
            appDBContent.ShopServiceItem.Add(new ShopServiceItem
            {
                ShopServiceId = ShopServiceId,
                service = service,
                price = service.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopServiceItem> GetServiceItems()
        {
            return appDBContent.ShopServiceItem.Where(c => c.ShopServiceId == ShopServiceId).Include(s => s.service).ToList();
        }
    }
}
