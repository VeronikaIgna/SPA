using Microsoft.EntityFrameworkCore;
using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Repository
{
    public class ServiceRepository : IAllService
    {
        private readonly AppDBContent appDBContent;
        public ServiceRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
    
    
        public IEnumerable<Service> Services => appDBContent.Service.Include(c => c.Category);

        public IEnumerable<Service> getFavServices => appDBContent.Service.Where(p => p.isFavourite).Include(c=> c.Category);

        public Service getObjectService(int serviceId) => appDBContent.Service.FirstOrDefault(p => p.id == serviceId);
      
    }
}
