using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPA.Data.Mocks;

namespace SPA.Data.Mocks
{
    public class MockService : IAllService
    {
        private readonly IServiceCategory _CategoryService = new MockCategory();
        public IEnumerable<Service> Services
        {
            get
            {
                return new List<Service>
                {
                    new Service { name = " SPA-уход Нежность лотоса", 
                                  img = "/img/12.png" , 
                                  price = 6700, isFavourite = true, 
                                  Category = _CategoryService.AllCategories.First() },
                    new Service { name = " Шоколадное обертывание", 
                                  img = "/img/spa.png" , 
                                  price = 5000, isFavourite = true, 
                                  Category = _CategoryService.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Service> getFavServices { get; set; }

        public Service getObjectService(int serviceId)
        {
            throw new NotImplementedException();
        }
    }
}
